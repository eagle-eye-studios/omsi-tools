using System.Windows.Forms;
using Microsoft.Win32;
using dist = OmsiTools.Mono.Distributor;

namespace OmsiTools.Mono
{
    public partial class MainWindow : Form
    {

        public MainWindow()
        {
            InitializeComponent();
            
            Properties.Settings.Default.Reload();

            if (Properties.Settings.Default.OmsiPath == "")
            {
                Properties.Settings.Default.OmsiPath = GetOmsiPath();
                Properties.Settings.Default.Save();
            }

            textBoxOmsiPath.Text = Properties.Settings.Default.OmsiPath;
        }

        private void BtnHofDistributorClick(object sender, EventArgs e)
        {
            try
            {
                var dlg = new dist.Distributor();
                dlg.ShowDialog(this);
            }
            catch (Exception ex)
            {

#if DEBUG || TRACE
                throw ex;
#else
                Console.Write(ex);
                MessageBox.Show("An error occured: " + ex.Message + "\n" + ex.StackTrace, "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
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

        private string GetOmsiPath()
        {
            try
            {
                return !Environment.Is64BitOperatingSystem 
                    ? Registry.GetValue(
                            Properties.Settings.Default.RegKey32,
                            Properties.Settings.Default.RegValueName,
                            "No entry in the Registry."
                        )
                        .ToString()
                    : Registry.GetValue(
                            Properties.Settings.Default.RegKey64,
                            Properties.Settings.Default.RegValueName,
                            "No Entry in the Registry."
                        )
                        .ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Is OMSI 2 installed and recognized in the aerosoft Launcher?\nException Details:\n" + ex.StackTrace, "Error accessing the Windows Registry: Path Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FolderBrowserDialog dlg = new FolderBrowserDialog();
                dlg.Description = "Please select the OMSI 2 directory";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    return dlg.SelectedPath;
                }
                Application.Exit();
            }
            return "";
        }

        private void BtnBackupClick(object sender, EventArgs e)
        {
            try 
            {
                var dlg = new Backups.BackupTool();
                dlg.ShowDialog();
            }
            catch(Exception ex)
            {
#if DEBUG || TRACE
                throw ex;
#else
                Console.Write(ex);
                MessageBox.Show("An error occured: " + ex.Message + "\n" + ex.StackTrace, "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }

        private void BtnAddonManagerClick(object sender, EventArgs e)
        {
        }
    }
}