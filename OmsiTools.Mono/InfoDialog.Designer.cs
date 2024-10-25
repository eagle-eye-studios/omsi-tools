using System.ComponentModel;
using System.Windows.Forms;

namespace OmsiTools.Mono;

 partial class InfoDialog
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        this.radWaitingBar1 = new ProgressBar();
        this.radLabel1 = new Label();
        this.SuspendLayout();
        // 
        // radWaitingBar1
        // 
        this.radWaitingBar1.Location = new System.Drawing.Point(12, 57);
        this.radWaitingBar1.Name = "radWaitingBar1";
        this.radWaitingBar1.Size = new System.Drawing.Size(348, 24);
        this.radWaitingBar1.TabIndex = 0;
        // 
        // radLabel1
        // 
        this.radLabel1.AutoSize = false;
        this.radLabel1.Location = new System.Drawing.Point(12, 22);
        this.radLabel1.Name = "radLabel1";
        this.radLabel1.Size = new System.Drawing.Size(348, 18);
        this.radLabel1.TabIndex = 1;
        this.radLabel1.Text = "Scanning directories...";
        // 
        // InfoDlg
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(372, 98);
        this.ControlBox = false;
        this.Controls.Add(this.radLabel1);
        this.Controls.Add(this.radWaitingBar1);
        this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "InfoDialog";
        // 
        // 
        // 
        this.ShowIcon = false;
        this.ShowInTaskbar = false;
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Working...";
        this.TopMost = true;
        this.Load += new System.EventHandler(this.InfoDlg_Load);
        this.ResumeLayout(false);

    }

    #endregion

    private ProgressBar radWaitingBar1;
    private Label radLabel1;
}