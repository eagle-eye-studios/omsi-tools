using System;
using System.Windows.Forms;
using Microsoft.Win32;
using dist = OmsiTools.Distributor;

namespace OmsiTools
{
    public partial class MainWindow : Telerik.WinControls.UI.RadForm
    {

        public MainWindow()
        {
            InitializeComponent();
            Properties.Settings.Default.OmsiPath = GetOmsiPath();
            textBoxOmsiPath.Text = Properties.Settings.Default.OmsiPath;
        }

        private void BtnHofDistributorClick(object sender, EventArgs e)
        {
            var dlg = new dist.Distributor();
            dlg.ShowDialog(this);
        }

        private void BtnQuitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAboutClick(object sender, EventArgs e)
        {
            var aboutBox = new AboutBox();
            aboutBox.ShowDialog(this);
        }

        internal string GetOmsiPath()
        {
            try
            {
                if (!Environment.Is64BitOperatingSystem)
                    return Registry.GetValue(Properties.Settings.Default.RegKey32, Properties.Settings.Default.RegValueName, "No entry in the Registry.").ToString();
                else
                    return Registry.GetValue(Properties.Settings.Default.RegKey64, Properties.Settings.Default.RegValueName, "No Entry in the Registry.").ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Is OMSI 2 installed and recognized in the aerosoft Launcher?\nException Details:\n" + ex.StackTrace, "Error accessing the Windows Registry: Path Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            return "";
        }

        private void BtnBackupClick(object sender, EventArgs e)
        {
            var dlg = new Backup.BackupTool();
            dlg.ShowDialog();
        }

        private void BtnAddonManagerClick(object sender, EventArgs e)
        {
            var dlg = new Addons.AddonManager();
            dlg.ShowDialog();
        }
    }
}
