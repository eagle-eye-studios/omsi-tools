using System;
using System.Collections.Generic;
using System.IO;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OmsiTools.Distributor
{
    public partial class Distributor : Telerik.WinControls.UI.RadForm
    {
        protected volatile List<BusEntry> userBusFiles;

        public Distributor()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Walks the OMSI 2 Vehicles directory and collects Name and Path of the first .bus file in each directory
        /// </summary>
        /// <returns>List containing Name and Path of the first .bus file of each directory</returns>
        public List<BusEntry> WalkDirectories()
        {
            var res = new List<BusEntry>();
            var dInfo = new DirectoryInfo(Path.Combine(Properties.Settings.Default.OmsiPath, "Vehicles")); //Root path for dir walking.
            Parallel.ForEach<DirectoryInfo>(dInfo.GetDirectories(), dir =>
            {
                foreach (FileInfo busFile in dir.GetFiles("*.bus")) //Scan all .bus files in this directory
                {
                    string content = File.ReadAllText(busFile.FullName); //File content in one long string
                    string[] lines = content.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None); // split on new line
                    for (int i = 0; i < lines.Length; i++)
                    {
                        if (lines[i].StartsWith("[friendlyname]")) // Check if line starts with the [friendlyname] tag; indented ones will be ignored.
                        {
                            var name = string.Format("{0} {1}", lines[i + 1], lines[i + 2]); // assemble name from the next two lines below the tag
                            res.Add(new BusEntry() { Name = name, Path = busFile.DirectoryName });
                            return; //Only test until the first bus file is found. No need to continue as HOF files are used per directory.
                        }
                    }
                }
            });

            return res;
        }

        /// <summary>
        /// Called when Form was created and is being initialized.
        /// </summary>
        private void Distributor_Load(object sender, EventArgs e)
        {
            var dlg = new InfoDlg(); //Display InfoDialog that the program is walking the Vehicles directory
            dlg.Show(this);
            var task = Task.Factory.StartNew<List<BusEntry>>(WalkDirectories); //Begin walking on a seperate Thread to prevent GUI lockup
            Application.DoEvents();
            task.Wait(); // Wait until task has finished
            this.userBusFiles = task.Result; // Retrieve .bus file list; one for each directory
            this.listView.DataSource = this.userBusFiles; // Set the retrieved list as DataSource, ListView will update automatically.
            dlg.Hide(); // As we do not need the InfoDlg anymore hide & destroy it
            GC.Collect();
            // If you ask why I dispose them manually: I do not fully trust the GC times :P
        }

        /// <summary>
        /// Gets the bus entry based on its name
        /// </summary>
        /// <param name="name"></param>
        /// <returns>bus entry with the specified name</returns>
        private BusEntry GetBusEntryByName(string name)
        {
            foreach (var be in this.userBusFiles)
            {
                if (be.Name.Equals(name))
                {
                    return be;
                }
            }
            return null;
        }

        /// <summary>
        /// Invoked when Distribute button was clicked
        /// </summary>
        private void BtnStartClick(object sender, EventArgs e)
        {
            if (this.listView.CheckedItems.Count < 1) // If nothing is selected, display error and do nothing
            {
                this.lblStatus.Text = "ERROR: No targets selected!";
                SystemSounds.Exclamation.Play();
            }
            else if (String.IsNullOrEmpty(this.fileSelector.Value)) // If no HOF file is selected, display error and skip
            {
                this.lblStatus.Text = "ERROR: No HOF file selected";
                SystemSounds.Exclamation.Play();
            }
            else //start copy process
            {
                try
                {
                    int counter = 1;
                    this.lblStatus.Text = "Starting copy process...";
                    this.progressBar.Value1 = 0;
                    this.progressBar.Step = 100 / this.listView.CheckedItems.Count;
                    this.progressBar.Text = string.Format("(0/{0})", this.listView.CheckedItems.Count);
                    FileInfo hofFile = new FileInfo(this.fileSelector.Value);
                    this.lblStatus.Text = "Copy in progress";
                    foreach (var name in this.listView.CheckedItems)
                    {
                        this.progressBar.Text = string.Format("({0}/{1})", counter.ToString(), this.listView.CheckedItems.Count);
                        var entry = this.GetBusEntryByName(name.Text); // turn text value from the listView into a BusEntry
                        File.Copy(hofFile.FullName, Path.Combine(entry.Path, hofFile.Name), this.checkOverwrite.Checked); //assemble new path and copy HOF file there
                        if (!String.IsNullOrEmpty(dirSelector.Value)) // check if we have got some textures to copy
                        {
                            CopyDirectory(dirSelector.Value, Path.Combine(entry.Path, "Texture\\Linienlisten\\"), true); //Copy files from the line list dir to the selected bus dirs
                        }
                        this.progressBar.PerformStepValue1(); //increment progressBar
                        counter++;
                    }
                    MessageBox.Show(string.Format("HOF file has been successfully distributed to {0} directories.", (counter-1).ToString()), "Distribution complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.lblStatus.Text = "Done"; // Cave Johnson, We're done here!
                }
                catch (Exception ex)
                {
                    this.lblStatus.Text = string.Format("ERROR: {0}", ex.Message); //Only display message on error, Trace will be dumped to console
                    Console.Write(ex);
                    SystemSounds.Hand.Play();
                }
            }
        }

        /// <summary>
        /// Copies a directory, if desired, recursively
        /// </summary>
        /// <param name="sourceDirName">The source directory</param>
        /// <param name="destDirName">the destination directory</param>
        /// <param name="copySubDirs">recursive?</param>
        public void CopyDirectory(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            DirectoryInfo[] dirs = dir.GetDirectories();

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                                                     "Source directory does not exist or could not be found: " +
                                                     sourceDirName);
            }

            // If the destination directory doesn't exist, create it. 
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string tp = Path.Combine(destDirName, file.Name);
                file.CopyTo(tp, checkOverwrite.Checked);
            }

            // If copying subdirectories, copy them and their contents to new location. 
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string tp = Path.Combine(destDirName, subdir.Name);
                    CopyDirectory(subdir.FullName, tp, copySubDirs);
                }
            }
        }
    }
}