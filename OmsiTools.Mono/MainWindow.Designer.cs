using System.ComponentModel;
using System.Windows.Forms;

namespace OmsiTools.Mono;

partial class MainWindow
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
        this.btnHofDistributor = new Button();
        this.btnAbout = new Button();
        this.btnBackup = new Button();
        this.btnQuit = new Button();
        this.lblOmsiPath = new Label();
        this.textBoxOmsiPath = new TextBox();
        this.btnAddonManager = new Button();
        this.SuspendLayout();
        // 
        // btnHofDistributor
        // 
        this.btnHofDistributor.Location = new System.Drawing.Point(12, 12);
        this.btnHofDistributor.Name = "btnHofDistributor";
        this.btnHofDistributor.Size = new System.Drawing.Size(252, 48);
        this.btnHofDistributor.TabIndex = 0;
        this.btnHofDistributor.Text = "HOF Distributor";
        this.btnHofDistributor.Click += new System.EventHandler(this.BtnHofDistributorClick);
        // 
        // btnAbout
        // 
        this.btnAbout.Location = new System.Drawing.Point(12, 304);
        this.btnAbout.Name = "btnAbout";
        this.btnAbout.Size = new System.Drawing.Size(120, 48);
        this.btnAbout.TabIndex = 1;
        this.btnAbout.Text = "About";
        this.btnAbout.Click += new System.EventHandler(this.BtnAboutClick);
        // 
        // btnBackup
        // 
        this.btnBackup.Location = new System.Drawing.Point(12, 66);
        this.btnBackup.Name = "btnBackup";
        this.btnBackup.Size = new System.Drawing.Size(252, 48);
        this.btnBackup.TabIndex = 2;
        this.btnBackup.Text = "Backup Tool";
        this.btnBackup.Click += new System.EventHandler(this.BtnBackupClick);
        // 
        // btnQuit
        // 
        this.btnQuit.Location = new System.Drawing.Point(138, 304);
        this.btnQuit.Name = "btnQuit";
        this.btnQuit.Size = new System.Drawing.Size(126, 48);
        this.btnQuit.TabIndex = 2;
        this.btnQuit.Text = "Quit";
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
        // 
        // textBoxOmsiPath
        // 
        this.textBoxOmsiPath.Location = new System.Drawing.Point(13, 276);
        this.textBoxOmsiPath.Name = "textBoxOmsiPath";
        this.textBoxOmsiPath.ReadOnly = true;
        this.textBoxOmsiPath.Size = new System.Drawing.Size(251, 21);
        this.textBoxOmsiPath.TabIndex = 4;
        this.textBoxOmsiPath.TabStop = false;
        // 
        // btnAddonManager
        // 
        this.btnAddonManager.Location = new System.Drawing.Point(12, 120);
        this.btnAddonManager.Name = "btnAddonManager";
        this.btnAddonManager.Size = new System.Drawing.Size(252, 48);
        this.btnAddonManager.TabIndex = 3;
        this.btnAddonManager.Text = "Addon Manager";
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
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "OMSI Toolbox";
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion
    
    
    private Button btnHofDistributor;
    private Button btnAbout;
    private Button btnBackup;
    private Button btnQuit;
    private Label lblOmsiPath;
    private TextBox textBoxOmsiPath;
    private Button btnAddonManager;
}