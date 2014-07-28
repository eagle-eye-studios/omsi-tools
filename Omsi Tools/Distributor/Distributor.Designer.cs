namespace OmsiTools.Distributor
{
    partial class Distributor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Distributor));
            Telerik.WinControls.Data.SortDescriptor sortDescriptor2 = new Telerik.WinControls.Data.SortDescriptor();
            this.lblHeading = new Telerik.WinControls.UI.RadLabel();
            this.lblDesc = new Telerik.WinControls.UI.RadLabel();
            this.btnStart = new Telerik.WinControls.UI.RadButton();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.lblStatus = new Telerik.WinControls.UI.RadLabelElement();
            this.commandBarSeparator1 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.progressBar = new Telerik.WinControls.UI.RadProgressBarElement();
            this.lblHofFile = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.fileSelector = new Telerik.WinControls.UI.RadBrowseEditor();
            this.listView = new Telerik.WinControls.UI.RadListView();
            this.checkOverwrite = new Telerik.WinControls.UI.RadCheckBox();
            this.dirSelector = new Telerik.WinControls.UI.RadBrowseEditor();
            this.lblListDir = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.lblHeading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblHofFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkOverwrite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dirSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblListDir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeading.AutoSize = false;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(12, 5);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(466, 41);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "HOF Distributor";
            this.lblHeading.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHeading.ThemeName = "VisualStudio2012Dark";
            // 
            // lblDesc
            // 
            this.lblDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDesc.AutoSize = false;
            this.lblDesc.Location = new System.Drawing.Point(12, 51);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(466, 44);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = resources.GetString("lblDesc.Text");
            this.lblDesc.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDesc.ThemeName = "VisualStudio2012Dark";
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(12, 316);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(466, 24);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Distribute";
            this.btnStart.ThemeName = "VisualStudio2012Dark";
            this.btnStart.Click += new System.EventHandler(this.BtnStartClick);
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.lblStatus,
            this.commandBarSeparator1,
            this.progressBar});
            this.radStatusStrip1.LayoutStyle = Telerik.WinControls.UI.RadStatusBarLayoutStyle.Overflow;
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 353);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(490, 26);
            this.radStatusStrip1.TabIndex = 3;
            this.radStatusStrip1.Text = "radStatusStrip1";
            this.radStatusStrip1.ThemeName = "VisualStudio2012Dark";
            // 
            // lblStatus
            // 
            this.lblStatus.AccessibleDescription = "Ready";
            this.lblStatus.AccessibleName = "Ready";
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Name = "lblStatus";
            this.radStatusStrip1.SetSpring(this.lblStatus, false);
            this.lblStatus.Text = "Ready";
            this.lblStatus.TextWrap = true;
            this.lblStatus.UseSystemSkin = Telerik.WinControls.UseSystemSkinMode.NoInheritable;
            this.lblStatus.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // commandBarSeparator1
            // 
            this.commandBarSeparator1.AccessibleDescription = "commandBarSeparator1";
            this.commandBarSeparator1.AccessibleName = "commandBarSeparator1";
            this.commandBarSeparator1.Name = "commandBarSeparator1";
            this.radStatusStrip1.SetSpring(this.commandBarSeparator1, false);
            this.commandBarSeparator1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.commandBarSeparator1.VisibleInOverflowMenu = false;
            // 
            // progressBar
            // 
            this.progressBar.AccessibleDescription = "(0/0)";
            this.progressBar.AccessibleName = "(0/0)";
            this.progressBar.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.progressBar.AutoSize = false;
            this.progressBar.Bounds = new System.Drawing.Rectangle(0, 0, 97, 18);
            this.progressBar.Name = "progressBar";
            this.progressBar.SeparatorColor1 = System.Drawing.Color.White;
            this.progressBar.SeparatorColor2 = System.Drawing.Color.White;
            this.progressBar.SeparatorColor3 = System.Drawing.Color.White;
            this.progressBar.SeparatorColor4 = System.Drawing.Color.White;
            this.progressBar.SeparatorGradientAngle = 0;
            this.progressBar.SeparatorGradientPercentage1 = 0.4F;
            this.progressBar.SeparatorGradientPercentage2 = 0.6F;
            this.progressBar.SeparatorNumberOfColors = 2;
            this.radStatusStrip1.SetSpring(this.progressBar, false);
            this.progressBar.StepWidth = 14;
            this.progressBar.SweepAngle = 90;
            this.progressBar.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // lblHofFile
            // 
            this.lblHofFile.AutoSize = false;
            this.lblHofFile.Location = new System.Drawing.Point(12, 136);
            this.lblHofFile.Name = "lblHofFile";
            this.lblHofFile.Size = new System.Drawing.Size(74, 18);
            this.lblHofFile.TabIndex = 4;
            this.lblHofFile.Text = "HOF File:";
            this.lblHofFile.ThemeName = "VisualStudio2012Dark";
            // 
            // radLabel4
            // 
            this.radLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel4.AutoSize = false;
            this.radLabel4.Location = new System.Drawing.Point(12, 175);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(466, 18);
            this.radLabel4.TabIndex = 5;
            this.radLabel4.Text = "Distribution Targets";
            this.radLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radLabel4.ThemeName = "VisualStudio2012Dark";
            // 
            // fileSelector
            // 
            this.fileSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileSelector.Location = new System.Drawing.Point(92, 134);
            this.fileSelector.Name = "fileSelector";
            this.fileSelector.Size = new System.Drawing.Size(386, 21);
            this.fileSelector.TabIndex = 9;
            this.fileSelector.ThemeName = "VisualStudio2012Dark";
            // 
            // listView
            // 
            this.listView.AllowEdit = false;
            this.listView.AllowRemove = false;
            this.listView.AllowShowFocusCues = true;
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.EnableKineticScrolling = true;
            this.listView.EnableSorting = true;
            this.listView.HeaderHeight = 16F;
            this.listView.ItemSpacing = -1;
            this.listView.Location = new System.Drawing.Point(12, 199);
            this.listView.MultiSelect = true;
            this.listView.Name = "listView";
            this.listView.ShowCheckBoxes = true;
            this.listView.ShowGridLines = true;
            this.listView.ShowGroups = true;
            this.listView.Size = new System.Drawing.Size(466, 111);
            this.listView.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor2});
            this.listView.TabIndex = 10;
            this.listView.Text = "radListView1";
            this.listView.ThemeName = "VisualStudio2012Dark";
            this.listView.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView;
            // 
            // checkOverwrite
            // 
            this.checkOverwrite.Location = new System.Drawing.Point(15, 173);
            this.checkOverwrite.Name = "checkOverwrite";
            this.checkOverwrite.Size = new System.Drawing.Size(116, 18);
            this.checkOverwrite.TabIndex = 11;
            this.checkOverwrite.Text = " Overwrite existing";
            this.checkOverwrite.ThemeName = "VisualStudio2012Dark";
            // 
            // dirSelector
            // 
            this.dirSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dirSelector.DialogType = Telerik.WinControls.UI.BrowseEditorDialogType.FolderBrowseDialog;
            this.dirSelector.Location = new System.Drawing.Point(92, 107);
            this.dirSelector.Name = "dirSelector";
            this.dirSelector.Size = new System.Drawing.Size(386, 21);
            this.dirSelector.TabIndex = 11;
            this.dirSelector.ThemeName = "VisualStudio2012Dark";
            // 
            // lblListDir
            // 
            this.lblListDir.AutoSize = false;
            this.lblListDir.Location = new System.Drawing.Point(12, 109);
            this.lblListDir.Name = "lblListDir";
            this.lblListDir.Size = new System.Drawing.Size(74, 18);
            this.lblListDir.TabIndex = 10;
            this.lblListDir.Text = "Line list dir:";
            this.lblListDir.ThemeName = "VisualStudio2012Dark";
            // 
            // Distributor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 379);
            this.Controls.Add(this.dirSelector);
            this.Controls.Add(this.checkOverwrite);
            this.Controls.Add(this.lblListDir);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.fileSelector);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.lblHofFile);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Distributor";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOF Distributor";
            this.ThemeName = "VisualStudio2012Dark";
            this.Load += new System.EventHandler(this.Distributor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lblHeading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblHofFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkOverwrite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dirSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblListDir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel lblHeading;
        private Telerik.WinControls.UI.RadLabel lblDesc;
        private Telerik.WinControls.UI.RadButton btnStart;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadLabelElement lblStatus;
        private Telerik.WinControls.UI.RadLabel lblHofFile;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator1;
        private Telerik.WinControls.UI.RadProgressBarElement progressBar;
        private Telerik.WinControls.UI.RadBrowseEditor fileSelector;
        private Telerik.WinControls.UI.RadListView listView;
        private Telerik.WinControls.UI.RadCheckBox checkOverwrite;
        private Telerik.WinControls.UI.RadBrowseEditor dirSelector;
        private Telerik.WinControls.UI.RadLabel lblListDir;
    }
}
