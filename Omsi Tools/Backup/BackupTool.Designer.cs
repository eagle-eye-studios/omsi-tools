namespace OmsiTools.Backup
{
    partial class BackupTool
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
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn1 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "Creation Date");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn2 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Folder");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn3 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 2", "Size");
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupTool));
            this.listView = new Telerik.WinControls.UI.RadListView();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.btnAdd = new Telerik.WinControls.UI.RadButton();
            this.btnRestore = new Telerik.WinControls.UI.RadButton();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.progressBar = new Telerik.WinControls.UI.RadProgressBarElement();
            this.lblStatus = new Telerik.WinControls.UI.RadLabelElement();
            ((System.ComponentModel.ISupportInitialize)(this.listView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            listViewDetailColumn1.HeaderText = "Creation Date";
            listViewDetailColumn2.HeaderText = "Folder";
            listViewDetailColumn3.HeaderText = "Size";
            listViewDetailColumn3.MinWidth = 60F;
            listViewDetailColumn3.Width = 60F;
            this.listView.Columns.AddRange(new Telerik.WinControls.UI.ListViewDetailColumn[] {
            listViewDetailColumn1,
            listViewDetailColumn2,
            listViewDetailColumn3});
            this.listView.EnableSorting = true;
            this.listView.ItemSpacing = -1;
            this.listView.Location = new System.Drawing.Point(12, 149);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(482, 166);
            sortDescriptor1.Direction = System.ComponentModel.ListSortDirection.Descending;
            sortDescriptor1.PropertyName = "Timestamp";
            this.listView.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.listView.TabIndex = 0;
            this.listView.Text = "radListView1";
            this.listView.ThemeName = "VisualStudio2012Dark";
            this.listView.ViewType = Telerik.WinControls.UI.ListViewType.DetailsView;
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel1.AutoSize = false;
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(12, 1);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(482, 43);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Backup Manager";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radLabel1.TextWrap = false;
            this.radLabel1.ThemeName = "VisualStudio2012Dark";
            // 
            // radLabel2
            // 
            this.radLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel2.AutoSize = false;
            this.radLabel2.Location = new System.Drawing.Point(12, 45);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(482, 55);
            this.radLabel2.TabIndex = 2;
            this.radLabel2.Text = resources.GetString("radLabel2.Text");
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radLabel2.ThemeName = "VisualStudio2012Dark";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 111);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 24);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "New";
            this.btnAdd.ThemeName = "VisualStudio2012Dark";
            this.btnAdd.Click += new System.EventHandler(this.CreateBackup);
            // 
            // btnRestore
            // 
            this.btnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestore.Location = new System.Drawing.Point(384, 111);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(110, 24);
            this.btnRestore.TabIndex = 4;
            this.btnRestore.Text = "Restore";
            this.btnRestore.ThemeName = "VisualStudio2012Dark";
            this.btnRestore.Click += new System.EventHandler(this.RestoreBackup);
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.progressBar,
            this.lblStatus});
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 325);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(506, 26);
            this.radStatusStrip1.TabIndex = 5;
            this.radStatusStrip1.Text = "radStatusStrip1";
            this.radStatusStrip1.ThemeName = "VisualStudio2012Dark";
            // 
            // progressBar
            // 
            this.progressBar.AutoSize = false;
            this.progressBar.Bounds = new System.Drawing.Rectangle(0, 0, 109, 17);
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
            // lblStatus
            // 
            this.lblStatus.AccessibleDescription = "Ready";
            this.lblStatus.AccessibleName = "Ready";
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblStatus.Name = "lblStatus";
            this.radStatusStrip1.SetSpring(this.lblStatus, false);
            this.lblStatus.Text = "Ready";
            this.lblStatus.TextWrap = true;
            this.lblStatus.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // BackupTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 351);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.listView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BackupTool";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.ThemeName = "VisualStudio2012Dark";
            this.Shown += new System.EventHandler(this.BackupTool_Loaded);
            ((System.ComponentModel.ISupportInitialize)(this.listView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadListView listView;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadButton btnAdd;
        private Telerik.WinControls.UI.RadButton btnRestore;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadProgressBarElement progressBar;
        private Telerik.WinControls.UI.RadLabelElement lblStatus;
    }
}
