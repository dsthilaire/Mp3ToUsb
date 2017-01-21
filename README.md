# Mp3ToUsb
Utility for copying files into a folder heirarchy based on their filename.  I created this application to help me fill a USB drive with MP3's for my car stereo.  On my computer, I keep my MP3 files on one folder with filenames formatted _Artist - Album - Track# - Title.mp3_ .  For my stereo, I wanted separate folders for each artist, with folders for each album under the artist's folder.  Inside the album folders, the files should have names formatted _Track# - Title.mp3_.  I added configuration options to give some flexibility to the input filename format, the output folder structure, and the output filename format.  There is some explanation in the dialog itself, but more detail is below.

## Input files
This is a listbox for the files that are going to be copied.  Just drag files from Windows Explorer and drop them in.  They will be sorted by filename.

## Input filename field separator
This lets you specify a string that separates the fields in the filename.  It defaults to "-", but for the format I have above I change it to " - ".

## Heirarchy structure
This allows you to define the output directory structure.  This should be integers speparated by "/".  The integers are an index into the fields of the filename after it is split on the input filename field separator.  The default is "1/2" which results in a directory structure _Artist/Album_, using the input filename format above with an input filename separator " - ".

## Output filename format
This is where you specify the format of the output filenames.  Again, integers in the filename will be treated as indexes of fields in the input filename.  If the integer is higher than the number of fields in the input filename, then it will just be left as a hard-coded integer in the ouput filename.  The default is "3 - 4", which will result in a format of _Track# - Title_ using the above input filename.  If you changed it to "4 (by 1) 8" for some reason, then the output format would be _Title (by Artist) 8_.  The output file gets the same extension as the input file.

## Destination root folder
This is where you specify the root folder where the output directory structure will be created.  For me, I selected my USB drive.

## Copy Files
This button launches the operation.

## Remove Selected
This button can be used to remove files that were dropped in the listbox erroneously.  Select one or more files in the listbox, then click Remove Selected to remove them from the list.
