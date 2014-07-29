namespace OmsiTools.Backup
{
    partial class NewBackup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewBackup));
            this.lblHeading = new Telerik.WinControls.UI.RadLabel();
            this.btnCreate = new Telerik.WinControls.UI.RadButton();
            this.lblDesc = new Telerik.WinControls.UI.RadLabel();
            this.treeView = new Telerik.WinControls.UI.RadTreeView();
            ((System.ComponentModel.ISupportInitialize)(this.lblHeading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            resources.ApplyResources(this.lblHeading, "lblHeading");
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.ThemeName = "VisualStudio2012Dark";
            // 
            // btnCreate
            // 
            resources.ApplyResources(this.btnCreate, "btnCreate");
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.ThemeName = "VisualStudio2012Dark";
            this.btnCreate.Click += new System.EventHandler(this.Submit);
            // 
            // lblDesc
            // 
            resources.ApplyResources(this.lblDesc, "lblDesc");
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.ThemeName = "VisualStudio2012Dark";
            // 
            // treeView
            // 
            this.treeView.AllowPlusMinusAnimation = true;
            resources.ApplyResources(this.treeView, "treeView");
            this.treeView.MultiSelect = true;
            this.treeView.Name = "treeView";
            this.treeView.ThemeName = "VisualStudio2012Dark";
            // 
            // NewBackup
            // 
            this.AcceptButton = this.btnCreate;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewBackup";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowInTaskbar = false;
            this.ThemeName = "VisualStudio2012Dark";
            this.Load += new System.EventHandler(this.NewBackup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lblHeading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel lblHeading;
        private Telerik.WinControls.UI.RadButton btnCreate;
        private Telerik.WinControls.UI.RadLabel lblDesc;
        private Telerik.WinControls.UI.RadTreeView treeView;
    }
}
