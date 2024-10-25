using System.Windows.Forms;

namespace OmsiTools.Mono.Backups
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
            this.lblHeading = new Label();
            this.btnCreate = new Button();
            this.lblDesc = new Label();
            this.treeView = new TreeView();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            resources.ApplyResources(this.lblHeading, "lblHeading");
            this.lblHeading.Name = "lblHeading";
            // 
            // btnCreate
            // 
            resources.ApplyResources(this.btnCreate, "btnCreate");
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Click += new System.EventHandler(this.Submit);
            // 
            // lblDesc
            // 
            resources.ApplyResources(this.lblDesc, "lblDesc");
            this.lblDesc.Name = "lblDesc";
            // 
            // treeView
            // 
            resources.ApplyResources(this.treeView, "treeView");
            this.treeView.Name = "treeView";
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
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.NewBackup_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblHeading;
        private Button btnCreate;
        private Label lblDesc;
        private TreeView treeView;
    }
}