namespace OmsiTools.Backup
{
    partial class RestoreDlg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RestoreDlg));
            Telerik.WinControls.UI.RadTreeNode radTreeNode1 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode2 = new Telerik.WinControls.UI.RadTreeNode();
            Telerik.WinControls.UI.RadTreeNode radTreeNode3 = new Telerik.WinControls.UI.RadTreeNode();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.btnOk = new Telerik.WinControls.UI.RadButton();
            this.lblHeading = new Telerik.WinControls.UI.RadLabel();
            this.lblDesc = new Telerik.WinControls.UI.RadLabel();
            this.treeView = new Telerik.WinControls.UI.RadTreeView();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblHeading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(168, 342);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 24);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.ThemeName = "VisualStudio2012Dark";
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(306, 342);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(110, 24);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Do it!";
            this.btnOk.ThemeName = "VisualStudio2012Dark";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = false;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(12, 12);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(571, 33);
            this.lblHeading.TabIndex = 2;
            this.lblHeading.Text = "Warning!";
            this.lblHeading.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHeading.ThemeName = "VisualStudio2012Dark";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = false;
            this.lblDesc.Location = new System.Drawing.Point(27, 51);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(548, 82);
            this.lblDesc.TabIndex = 3;
            this.lblDesc.Text = resources.GetString("lblDesc.Text");
            this.lblDesc.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDesc.ThemeName = "VisualStudio2012Dark";
            // 
            // treeView
            // 
            this.treeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.treeView.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeView.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.treeView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.treeView.Location = new System.Drawing.Point(12, 139);
            this.treeView.Name = "treeView";
            radTreeNode1.Expanded = true;
            radTreeNode1.Name = "Node1";
            radTreeNode2.Name = "Node2";
            radTreeNode2.Text = "Node2";
            radTreeNode3.Name = "Node3";
            radTreeNode3.Text = "Node3";
            radTreeNode1.Nodes.AddRange(new Telerik.WinControls.UI.RadTreeNode[] {
            radTreeNode2,
            radTreeNode3});
            radTreeNode1.Text = "Node1";
            this.treeView.Nodes.AddRange(new Telerik.WinControls.UI.RadTreeNode[] {
            radTreeNode1});
            this.treeView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.treeView.Size = new System.Drawing.Size(563, 190);
            this.treeView.TabIndex = 4;
            this.treeView.Text = "radTreeView1";
            this.treeView.ThemeName = "VisualStudio2012Dark";
            // 
            // RestoreDlg
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnOk;
            this.ClientSize = new System.Drawing.Size(595, 378);
            this.ControlBox = false;
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RestoreDlg";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Restore Backup";
            this.ThemeName = "VisualStudio2012Dark";
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblHeading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadButton btnOk;
        private Telerik.WinControls.UI.RadLabel lblHeading;
        private Telerik.WinControls.UI.RadLabel lblDesc;
        private Telerik.WinControls.UI.RadTreeView treeView;
    }
}
