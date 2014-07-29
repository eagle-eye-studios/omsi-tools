using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace OmsiTools.Backup
{
    public partial class NewBackup : Telerik.WinControls.UI.RadForm
    {
        internal volatile List<string> Directories;

        public List<string> SelectedDirectories { get; private set; }

        public NewBackup()
        {
            InitializeComponent();
            Directories = new List<string>();
            SelectedDirectories = new List<string>();
        }

        public void WalkDirectories()
        {
            DirectoryInfo di = new DirectoryInfo(Properties.Settings.Default.OmsiPath);
            var dirs = di.GetDirectories("*.*", SearchOption.AllDirectories);
            foreach (var dir in dirs)
            {
                Directories.Add((dir.FullName).Replace(di.FullName, ""));
            }
        }

        private void NewBackup_Load(object sender, EventArgs e)
        {
            var dlg = new InfoDlg(); //Display InfoDialog that the program is walking the OMSI directory
            dlg.Show(this);
            var thread = new Thread(WalkDirectories); //Begin walking on a seperate Thread to prevent GUI lockup
            thread.Start();
            while (thread.IsAlive)
                Application.DoEvents(); //Update GUI
            thread.Join();
            dlg.Hide(); // As we do not need the InfoDlg anymore hide it
            treeView.AddNodeByPath("OMSI 2");
            foreach(var node in Directories)
            {
                treeView.AddNodeByPath("OMSI 2\\" + node);
            }
        }

        private void Submit(object sender, EventArgs e)
        {
            foreach (var sN in treeView.SelectedNodes)
            {
                SelectedDirectories.Add(sN.FullPath);
            }
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }
    }
}
