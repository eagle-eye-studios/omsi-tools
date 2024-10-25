using System.Windows.Forms;
using OmsiTools.Common.Backups;

namespace OmsiTools.Mono.Backups;

public partial class BackupTool : Form
{
    #region Fields
    private volatile List<Backup> backups;
    private volatile List<BackupDisplay> backupsForDisplay;
    private volatile Backup currentBackup;
    private bool uiDisabled = false;
    #endregion

    public BackupTool()
    {
        InitializeComponent();
    }

    #region Privates
    /// <summary>
    /// Starts the interactive backup creation process.
    /// </summary>
    private void CreateBackup(object sender, EventArgs e)
    {
        // Create and display wizard dialogue and get the return value
        var cdlg = new NewBackup();
        if (cdlg.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            return;
        var targetDirs = cdlg.SelectedDirectories;

        DisableUi();
        // Create Backup instance on seperate thread because it is time consuming to walk directories
        // This way the GUI won't lock up.
        Thread thread0;
        if (targetDirs.Count == 1) //Do this if we backup the OMSI 2 main directory
        {
            thread0 = new Thread(() => { currentBackup = Backup.Create((targetDirs[0]).Replace("OMSI 2\\", ""));}); //Create backup instance; remove one "OMSI 2\\" because it is already included in the path
        }
        else //Otherwise we need to get all the files from the seperate directories.
        {
            thread0 = new Thread(() => { 
                var files = new List<string>();
                foreach (var targetDir in targetDirs) // Walk every directory
                    files.AddRange(GetFiles(new DirectoryInfo(Path.Combine(Properties.Settings.Default.OmsiPath, (targetDir).Replace("OMSI 2\\", ""))))); //Add all files in the subdirectories; Again remove the spare "OMSI 2\\" part.
                currentBackup = Backup.Create(files); //Finally create backup instance from file list.
            });
        }
        thread0.Start();
        while (thread0.IsAlive)
        {
            lblStatus.Text = "Initializing backup process..."; //Twidle thumbs while thread is working
            Application.DoEvents();
        }
        lblStatus.Text = "Backup process running...";
        Thread thread1 = new Thread(currentBackup.Perform); //Start the actual backup routine in a new thread, 7zip will also scale to additional threads in the background.
        thread1.Start();
        while (thread1.IsAlive)
        {
            progressBar.Value = currentBackup.Progress; //Update the progress bar.
            progressBar.Text = currentBackup.Progress + " %";
            Application.DoEvents(); //Twiddle thumbs
        }
        Thread thread2 = new Thread(currentBackup.Save); //Backup is done, save the backup class instance to file
        thread2.Start();
        while (thread2.IsAlive)
        {
            lblStatus.Text = "Saving backup information...";
            Application.DoEvents(); //Twiddle thumbs
        }
        lblStatus.Text = "Finished"; 
        GC.Collect(); //Cleanup the thread mess
        RefreshView(); //Re-read the info directory to display the new backup in the list
        EnableUi();
        //Cave Johnson, we're done here!
    }

    /// <summary>
    /// Gets all files inside the specified directory and
    /// its subdirectories.
    /// </summary>
    /// <param name="dir">The directory to work in</param>
    /// <returns>List of all files found</returns>
    private List<string> GetFiles(DirectoryInfo dir)
    {
        return GetFiles(dir, true);
    }

    /// <summary>
    /// Gets all files inside the specified directory and
    /// its subdirectories.
    /// </summary>
    /// <param name="dir">The directory to work in</param>
    /// <returns>List of all files found</returns>
    private List<string> GetFiles(DirectoryInfo dir, bool recursive)
    {
        var ret = new List<string>();
        FileInfo[] files;
        if (recursive)
            files = dir.GetFiles("*.*", SearchOption.AllDirectories);
        else
            files = dir.GetFiles("*.*", SearchOption.TopDirectoryOnly);
        foreach (var file in files)
        {
            if (file.FullName.EndsWith("Thumbs.db"))
                continue;
            ret.Add(file.FullName);
        }
        return ret;
    }

    /// <summary>
    /// Starts the interactive restore process
    /// </summary>
    private void RestoreBackup(object sender, EventArgs e)
    {
        if (listView.SelectedItems.Count == 0)
        {
            MessageBox.Show("You need to select a backup first!", "No backup selected");
            return;
        }
        // var selection = listView.SelectedItems[0].DataSource as BackupDisplay; TODO
        /*backups.ForEach(delegate(Backup backup)
        { 
            if (backup.Date == selection.Timestamp)
                currentBackup = backup;
        });*/
        var rsdlg = new RestoreDialog(currentBackup);
        if (rsdlg.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            return;

        DisableUi();
        Thread worker = new Thread(currentBackup.Restore);
        worker.Start();
        lblStatus.Text = "Restoring backup...";
        while (worker.IsAlive)
        {
            progressBar.Value = currentBackup.Progress; //Update the progress bar.
            progressBar.Text = currentBackup.Progress + " %";
            Application.DoEvents(); //Twiddle thumbs
        }
        lblStatus.Text = "Finished.";
        EnableUi();
    }

    /// <summary>
    /// Called when the form is being loaded
    /// </summary>
    private void BackupTool_Loaded(object sender, EventArgs e)
    {
        DisableUi();
        lblStatus.Text = "Initializing Backup Manager...";
        progressBar.Value = 0;
        progressBar.Text = progressBar.Value + " %";
        Properties.Settings.Default.BackupLocation = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Eagle Eye Studios" + Path.DirectorySeparatorChar + "OmsiTools" + Path.DirectorySeparatorChar + "user.backupdb");
        if (!Directory.Exists(Properties.Settings.Default.BackupLocation))
            Directory.CreateDirectory(Properties.Settings.Default.BackupLocation);
        progressBar.Value = 33;
        progressBar.Text = progressBar.Value + " %";
        if (!Directory.Exists(Path.Combine(Properties.Settings.Default.BackupLocation, Properties.Settings.Default.BackupInfoDir)))
            Directory.CreateDirectory(Path.Combine(Properties.Settings.Default.BackupLocation, Properties.Settings.Default.BackupInfoDir));
        progressBar.Value = 66;
        if (!Directory.Exists(Path.Combine(Properties.Settings.Default.BackupLocation, Properties.Settings.Default.BackupDataDir)))
            Directory.CreateDirectory(Path.Combine(Properties.Settings.Default.BackupLocation, Properties.Settings.Default.BackupDataDir));
        progressBar.Value = 100;
        progressBar.Text = progressBar.Value + " %";
        lblStatus.Text = "Ready";
        RefreshView();
        EnableUi();
    }

    /// <summary>
    /// Re-reads the backup info database
    /// </summary>
    private void RefreshView()
    {
        lblStatus.Text = "Loading existing backups...";
        progressBar.Value = 0;
        progressBar.Text = progressBar.Value + " %";
        backups = new List<Backup>();
        backupsForDisplay = new List<BackupDisplay>();
        List<string> bFiles = new List<string>();
        Thread reader = new Thread(() => { bFiles = GetFiles(new DirectoryInfo(Path.Combine(Properties.Settings.Default.BackupLocation, Properties.Settings.Default.BackupInfoDir)), false); });
        reader.Start();
        while (reader.IsAlive)
        {
            Application.DoEvents(); //Twiddle thumbs
        }
        progressBar.Value = 50;
        progressBar.Text = progressBar.Value + " %";
        Thread collector = new Thread(() =>
        {
            foreach (var bFile in bFiles)
            {
                var b = Backup.Load(bFile);
                backups.Add(b);
                var bd = new BackupDisplay
                {
                    Timestamp = b.Date,
                    Folder = (String.IsNullOrEmpty(b.Directory)) ? "OMSI 2" : b.Directory,
                    Size = $"{(b.Size / (1024 * 1024)):0.00}" + " MB"
                };
                backupsForDisplay.Add(bd);
            }
        });
        collector.Start();
        while(collector.IsAlive)
        {
            Application.DoEvents(); //Twiddle thumbs
        }
        // listView.DataSource = backupsForDisplay; TODO
        listView.Columns[2].Width = 83;
        progressBar.Value = 100; 
        progressBar.Text = progressBar.Value + " %";
        lblStatus.Text = "Ready";
    }

    protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
    {
        if (uiDisabled) // If ui is disabled, threads are still running, so we do not allow closing
        {
            MessageBox.Show("An operation is still running. Please be patient until it is finished.", "Closing not allowed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            e.Cancel = true;
            return;
        }
        
        base.OnClosing(e);
    }

    private void DisableUi()
    {
        uiDisabled = true;
        btnAdd.Enabled = false;
        btnRestore.Enabled = false;
        listView.Enabled = false;
    }

    private void EnableUi()
    {
        btnAdd.Enabled = true;
        btnRestore.Enabled = true;
        listView.Enabled = true;
        uiDisabled = false;
    }
    #endregion
}