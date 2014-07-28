namespace OmsiTools
{
    partial class MainWindow
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
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.btnHofDistributor = new Telerik.WinControls.UI.RadButton();
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.btnAbout = new Telerik.WinControls.UI.RadButton();
            this.btnBackup = new Telerik.WinControls.UI.RadButton();
            this.btnQuit = new Telerik.WinControls.UI.RadButton();
            this.lblOmsiPath = new Telerik.WinControls.UI.RadLabel();
            this.textBoxOmsiPath = new Telerik.WinControls.UI.RadTextBox();
            this.btnAddonManager = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnHofDistributor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBackup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnQuit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblOmsiPath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxOmsiPath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddonManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHofDistributor
            // 
            this.btnHofDistributor.Location = new System.Drawing.Point(12, 12);
            this.btnHofDistributor.Name = "btnHofDistributor";
            this.btnHofDistributor.Size = new System.Drawing.Size(252, 48);
            this.btnHofDistributor.TabIndex = 0;
            this.btnHofDistributor.Text = "HOF Distributor";
            this.btnHofDistributor.ThemeName = "VisualStudio2012Dark";
            this.btnHofDistributor.Click += new System.EventHandler(this.BtnHofDistributorClick);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(12, 304);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(120, 48);
            this.btnAbout.TabIndex = 1;
            this.btnAbout.Text = "About";
            this.btnAbout.ThemeName = "VisualStudio2012Dark";
            this.btnAbout.Click += new System.EventHandler(this.BtnAboutClick);
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(12, 66);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(252, 48);
            this.btnBackup.TabIndex = 2;
            this.btnBackup.Text = "Backup Tool";
            this.btnBackup.ThemeName = "VisualStudio2012Dark";
            this.btnBackup.Click += new System.EventHandler(this.BtnBackupClick);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(138, 304);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(126, 48);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.Text = "Quit";
            this.btnQuit.ThemeName = "VisualStudio2012Dark";
            this.btnQuit.Click += new System.EventHandler(this.BtnQuitClick);
            // 
            // lblOmsiPath
            // 
            this.lblOmsiPath.AutoSize = false;
            this.lblOmsiPath.Location = new System.Drawing.Point(12, 254);
            this.lblOmsiPath.Name = "lblOmsiPath";
            this.lblOmsiPath.Size = new System.Drawing.Size(252, 19);
            this.lblOmsiPath.TabIndex = 3;
            this.lblOmsiPath.Text = "OMSI 2 Path:";
            this.lblOmsiPath.ThemeName = "VisualStudio2012Dark";
            // 
            // textBoxOmsiPath
            // 
            this.textBoxOmsiPath.Location = new System.Drawing.Point(13, 276);
            this.textBoxOmsiPath.Name = "textBoxOmsiPath";
            this.textBoxOmsiPath.ReadOnly = true;
            this.textBoxOmsiPath.Size = new System.Drawing.Size(251, 21);
            this.textBoxOmsiPath.TabIndex = 4;
            this.textBoxOmsiPath.TabStop = false;
            this.textBoxOmsiPath.ThemeName = "VisualStudio2012Dark";
            // 
            // btnAddonManager
            // 
            this.btnAddonManager.Location = new System.Drawing.Point(12, 120);
            this.btnAddonManager.Name = "btnAddonManager";
            this.btnAddonManager.Size = new System.Drawing.Size(252, 48);
            this.btnAddonManager.TabIndex = 3;
            this.btnAddonManager.Text = "Addon Manager";
            this.btnAddonManager.ThemeName = "VisualStudio2012Dark";
            this.btnAddonManager.Click += new System.EventHandler(this.BtnAddonManagerClick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 364);
            this.Controls.Add(this.btnAddonManager);
            this.Controls.Add(this.textBoxOmsiPath);
            this.Controls.Add(this.lblOmsiPath);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnHofDistributor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OMSI Toolbox";
            this.ThemeName = "VisualStudio2012Dark";
            ((System.ComponentModel.ISupportInitialize)(this.btnHofDistributor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBackup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnQuit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblOmsiPath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxOmsiPath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddonManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private Telerik.WinControls.UI.RadButton btnHofDistributor;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private Telerik.WinControls.UI.RadButton btnAbout;
        private Telerik.WinControls.UI.RadButton btnBackup;
        private Telerik.WinControls.UI.RadButton btnQuit;
        private Telerik.WinControls.UI.RadLabel lblOmsiPath;
        private Telerik.WinControls.UI.RadTextBox textBoxOmsiPath;
        private Telerik.WinControls.UI.RadButton btnAddonManager;


    }
}
