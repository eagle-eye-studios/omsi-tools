/*  This file is part of the "OMSI Tools" project. 
 * 
 *  Authors: Florian Vick <florian@eagle-eye-studios.net> 
 *  Find the project at https://github.com/vickfl/omsi-tools/
 *
 *  OMSI Tools is licensed under the MIT License:
 * 
 *	Copyright (c) 2014 Eagle Eye Studios, Florian Vick
 *
 *	Permission is hereby granted, free of charge, to any person obtaining a copy
 *	of this software and associated documentation files (the "Software"), to deal
 *	in the Software without restriction, including without limitation the rights
 *	to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 *	copies of the Software, and to permit persons to whom the Software is
 *	furnished to do so, subject to the following conditions:
 *
 *	The above copyright notice and this permission notice shall be included in
 *	all copies or substantial portions of the Software.
 *
 *	THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 *	IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 *	FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 *	AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 *	LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 *	OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 *	THE SOFTWARE.
 */
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
            try 
            {
                var dlg = new Backup.BackupTool();
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
            try 
            {
                var dlg = new Addons.AddonManager();
                dlg.ShowDialog();
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
    }
}
