namespace Mp3ToUsb
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            System.Windows.Forms.TextBox textBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Button btnBrowseDest;
            System.Windows.Forms.GroupBox groupBox1;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.GroupBox groupBox2;
            System.Windows.Forms.Button btnRun;
            System.Windows.Forms.Button btnRemove;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.TextBox textBox2;
            this.txtDestPath = new System.Windows.Forms.TextBox();
            this.txtSeparator = new System.Windows.Forms.TextBox();
            this.lbFiles = new System.Windows.Forms.ListBox();
            this.txtFolderStructure = new System.Windows.Forms.TextBox();
            this.txtFilenameFormat = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            btnBrowseDest = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label3 = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            btnRun = new System.Windows.Forms.Button();
            btnRemove = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            textBox2 = new System.Windows.Forms.TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 51);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(145, 13);
            label1.TabIndex = 0;
            label1.Text = "Input filename field separator:";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox1.Location = new System.Drawing.Point(29, 128);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new System.Drawing.Size(256, 61);
            textBox1.TabIndex = 2;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 285);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(113, 13);
            label2.TabIndex = 7;
            label2.Text = "Destination root folder:";
            // 
            // btnBrowseDest
            // 
            btnBrowseDest.Location = new System.Drawing.Point(125, 280);
            btnBrowseDest.Name = "btnBrowseDest";
            btnBrowseDest.Size = new System.Drawing.Size(75, 23);
            btnBrowseDest.TabIndex = 8;
            btnBrowseDest.Text = "Browse";
            btnBrowseDest.UseVisualStyleBackColor = true;
            btnBrowseDest.Click += new System.EventHandler(this.btnBrowseDest_Click);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(this.txtFilenameFormat);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(this.txtFolderStructure);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(this.txtDestPath);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnBrowseDest);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(this.txtSeparator);
            groupBox1.Location = new System.Drawing.Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(291, 357);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Settings";
            // 
            // txtDestPath
            // 
            this.txtDestPath.Location = new System.Drawing.Point(24, 309);
            this.txtDestPath.Name = "txtDestPath";
            this.txtDestPath.ReadOnly = true;
            this.txtDestPath.Size = new System.Drawing.Size(233, 20);
            this.txtDestPath.TabIndex = 9;
            // 
            // txtSeparator
            // 
            this.txtSeparator.Location = new System.Drawing.Point(157, 48);
            this.txtSeparator.Name = "txtSeparator";
            this.txtSeparator.Size = new System.Drawing.Size(128, 20);
            this.txtSeparator.TabIndex = 1;
            this.txtSeparator.Text = "-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 24);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(269, 13);
            label3.TabIndex = 12;
            label3.Text = "Drag and drop files from Windows Explorer onto list box.";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnRun);
            groupBox2.Controls.Add(btnRemove);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(this.lbFiles);
            groupBox2.Location = new System.Drawing.Point(309, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(571, 357);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Input Files";
            // 
            // btnRun
            // 
            btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnRun.Location = new System.Drawing.Point(430, 328);
            btnRun.Name = "btnRun";
            btnRun.Size = new System.Drawing.Size(135, 23);
            btnRun.TabIndex = 14;
            btnRun.Text = "Copy Files";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnRemove
            // 
            btnRemove.Location = new System.Drawing.Point(296, 328);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new System.Drawing.Size(128, 23);
            btnRemove.TabIndex = 13;
            btnRemove.Text = "Remove Selected";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lbFiles
            // 
            this.lbFiles.AllowDrop = true;
            this.lbFiles.FormattingEnabled = true;
            this.lbFiles.Location = new System.Drawing.Point(6, 40);
            this.lbFiles.Name = "lbFiles";
            this.lbFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbFiles.Size = new System.Drawing.Size(559, 277);
            this.lbFiles.Sorted = true;
            this.lbFiles.TabIndex = 11;
            this.lbFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbFiles_DragDrop);
            this.lbFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbFiles_DragEnter);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(6, 24);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(252, 13);
            label4.TabIndex = 10;
            label4.Text = "Sample filename format:  Artist - Album - Track - Title";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(26, 76);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(125, 13);
            label5.TabIndex = 11;
            label5.Text = "In sample separator is \"-\"";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(6, 105);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(99, 13);
            label6.TabIndex = 12;
            label6.Text = "Heirarchy structure:";
            // 
            // txtFolderStructure
            // 
            this.txtFolderStructure.Location = new System.Drawing.Point(111, 102);
            this.txtFolderStructure.Name = "txtFolderStructure";
            this.txtFolderStructure.Size = new System.Drawing.Size(174, 20);
            this.txtFolderStructure.TabIndex = 13;
            this.txtFolderStructure.Text = "1/2";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(6, 198);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(116, 13);
            label7.TabIndex = 14;
            label7.Text = "Output filename format:";
            // 
            // txtFilenameFormat
            // 
            this.txtFilenameFormat.Location = new System.Drawing.Point(125, 195);
            this.txtFilenameFormat.Name = "txtFilenameFormat";
            this.txtFilenameFormat.Size = new System.Drawing.Size(160, 20);
            this.txtFilenameFormat.TabIndex = 15;
            this.txtFilenameFormat.Text = "3 - 4";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox2.Location = new System.Drawing.Point(29, 221);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new System.Drawing.Size(256, 51);
            textBox2.TabIndex = 16;
            textBox2.Text = "Output filename defined by field indexes.  Using the sample format, entering \"3 -" +
    " 4\" will create output filenames of the format Track - Title.\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 381);
            this.Controls.Add(groupBox2);
            this.Controls.Add(groupBox1);
            this.Name = "Form1";
            this.Text = "Mp3 2 USB";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSeparator;
        private System.Windows.Forms.TextBox txtDestPath;
        private System.Windows.Forms.ListBox lbFiles;
        private System.Windows.Forms.TextBox txtFilenameFormat;
        private System.Windows.Forms.TextBox txtFolderStructure;
    }
}

