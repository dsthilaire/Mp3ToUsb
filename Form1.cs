using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Mp3ToUsb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowseDest_Click(object sender, EventArgs e)
        {
            var dlg = new FolderBrowserDialog();
            dlg.ShowNewFolderButton = true;
            dlg.RootFolder = Environment.SpecialFolder.Desktop;
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtDestPath.Text = dlg.SelectedPath;
            }
        }

        private void lbFiles_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void lbFiles_DragDrop(object sender, DragEventArgs e)
        {
            // Ensure that the list item index is contained in the data. 
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var files = e.Data.GetData(DataFormats.FileDrop) as string[];
                lbFiles.Items.AddRange(files.Distinct().Where(f => !lbFiles.Items.Contains(f)).ToArray());
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                lbFiles.BeginUpdate();
                for (int i = lbFiles.SelectedItems.Count - 1; i >= 0; i--)
                    lbFiles.Items.Remove(lbFiles.SelectedItems[i]);
            }
            finally
            {
                lbFiles.EndUpdate();
            }
        }

        class InputFile
        {
            public static string FilenameFormat { get; set; }
            public string FilePath { get; set; }
            public List<string> Fields { get; set; }
            private string _filename = null;
            public string FileName
            {
                get
                {
                    if (_filename == null)
                    {
                        if (string.IsNullOrWhiteSpace(FilenameFormat))
                            _filename = Path.GetFileName(FilePath);
                        else
                        {
                            _filename = FilenameFormat;
                            for (int i = Fields.Count - 1; i >= 0; i--)
                                _filename = _filename.Replace("*" + (i + 1).ToString() + "*", Fields[i]);
                            // any tokens that weren't replaced must be numbers, not tokens, so get rid of '*'
                            _filename = _filename.Replace("*", "") + Path.GetExtension(FilePath);
                        }
                    }
                    return _filename;
                }
            }
        }

        enum Overwrite { Undefined, Yes, No, Prompt }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (!GoodToGo())
                return;

            // Get directory structure
            var parts = txtFolderStructure.Text.Split('\\', '/').Where(x => !string.IsNullOrWhiteSpace(x));
            int n, nMax = 0;
            List<int> folders = new List<int>();
            foreach (var part in parts)
            {
                if (!int.TryParse(part, out n))
                {
                    MessageBox.Show("Invalid directory structure.  Error at '" + part + "'");
                    return;
                }
                folders.Add(n);
                if (n > nMax)
                    nMax = n;
            }

            // init some other stuff
            var sep = new string [] { txtSeparator.Text };
            InputFile.FilenameFormat = GetTokenizedFilenameFormat();
            if (InputFile.FilenameFormat.Length > 0 && !InputFile.FilenameFormat.Contains('*'))
            {
                MessageBox.Show("Invalid output filename format.  No field indexes specified!");
                return;
            }

            var overwrite = Overwrite.Undefined;

            // Build list of input file objects
            var files = from li in lbFiles.Items.Cast<string>()
                        select new InputFile
                        {
                            FilePath = li,
                            Fields = Path.GetFileNameWithoutExtension(li)
                                        .Split(sep, StringSplitOptions.None)
                                        .Select(x => x.Trim())
                                        .ToList()
                        };

            var filelist = files.ToList();
            if (files.Any(x => x.Fields.Count < nMax))
            {
                MessageBox.Show("Filenames found with fewer fields than required by the Heirarchy Structure.");
                return;
            }
            // sort by each folder level from the top down, then finally by filename.  These must be applied in reverse order
            files = files.OrderBy(f => f.FileName);
            foreach (int i in folders.Reverse<int>())
            {
                int index = i-1;
                files = files.OrderBy(f => f.Fields[index]);
            }
            filelist = files.ToList();

            var sb = new StringBuilder(256);
            string folder;
            foreach (var f in files)
            {
                sb.Clear();
                sb.Append(txtDestPath.Text + "\\");
                foreach (int i in folders)
                    sb.Append(f.Fields[i-1] + "\\");
                folder = sb.ToString();
                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);
                folder = folder + f.FileName;
                bool bCopy = true;
                if (File.Exists(folder))
                {
                    if (overwrite == Overwrite.No)
                        bCopy = false;
                    else if (overwrite == Overwrite.Undefined || overwrite == Overwrite.Prompt)
                    {
                        switch (MessageBox.Show("Overwrite " + folder + "?", "File Exists", MessageBoxButtons.YesNoCancel))
                        {
                            case System.Windows.Forms.DialogResult.Cancel: return;
                            case System.Windows.Forms.DialogResult.No: bCopy = false; break;
                            case System.Windows.Forms.DialogResult.Yes: bCopy = true; break;
                            default: MessageBox.Show("Invalid button??"); return;
                        }

                        if (overwrite == Overwrite.Undefined)
                        {
                            if (MessageBox.Show("Apply this action to all duplicates?", "Remember answer?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                                overwrite = (bCopy ? Overwrite.Yes : Overwrite.No);
                            else
                                overwrite = Overwrite.Prompt;
                        }
                    }
                }
                if (bCopy)
                {
                    try
                    {
                        File.Copy(f.FilePath, folder, true);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Exception copying to " + folder + ":\n" + ex.ToString());
                    }
                }
            }

            if (MessageBox.Show("Operation completed.  Clear Input Files list?", "Done", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                lbFiles.Items.Clear();
        }

        private string GetTokenizedFilenameFormat()
        {
            //  Take the filename format and wrap any numbers in it with '*'.  '*' cannot be used in filenames, so there should be no conflicts.
            var chars = txtFilenameFormat.Text.ToList();
            bool bInNumber = false;
            for (int i = 0; i < chars.Count; i++)
            {
                bool bIsNumber = (chars[i] >= '0' && chars[i] <= '9');
                if (bIsNumber != bInNumber)
                {
                    chars.Insert(i, '*');
                    bInNumber = !bInNumber;
                    i++;
                }
            }
            if (bInNumber)
                chars.Add('*');
            return new string(chars.ToArray());
        }

        private bool GoodToGo()
        {
            if (txtSeparator.Text.Trim().Length == 0 && txtFolderStructure.Text.Trim().Length > 0)
            {
                MessageBox.Show("If Heirarchy Structure is specified, a separator must also be specified.");
                return false;
            }
            if (txtSeparator.Text.Trim().Length == 0 && txtFilenameFormat.Text.Trim().Length > 0)
            {
                MessageBox.Show("If Output Filename Format is specified, a separator must also be specified.");
                return false;
            }
            if (txtDestPath.Text.Trim().Length == 0)
            {
                MessageBox.Show("A Destination Root Folder must be selected.");
                return false;
            }
            if (lbFiles.Items.Count == 0)
            {
                MessageBox.Show("No Input Files have been added.");
                return false;
            }
            return true;
        }

    }

}
