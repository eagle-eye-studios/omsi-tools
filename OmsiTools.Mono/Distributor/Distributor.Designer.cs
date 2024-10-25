using System.ComponentModel;
using System.Windows.Forms;

namespace OmsiTools.Mono.Distributor;

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
        this.lblHeading = new Label();
        this.lblDesc = new Label();
        this.btnStart = new Button();
        this.radStatusStrip1 = new StatusStrip();
        this.lblStatus = new ToolStripStatusLabel();
        this.progressBar = new ToolStripProgressBar();
        this.lblHofFile = new Label();
        this.radLabel4 = new Label();
        this.fileSelector = new OpenFileDialog();
        this.listView = new ListView();
        this.checkOverwrite = new CheckBox();
        this.dirSelector = new FolderBrowserDialog();
        this.lblListDir = new Label();
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
        this.btnStart.Click += new System.EventHandler(this.BtnStartClick);
        // 
        // radStatusStrip1
        // 
        this.radStatusStrip1.Items.AddRange(
            new ToolStripItem[] {
                this.lblStatus,
                this.progressBar
            }
        );
        this.radStatusStrip1.Location = new System.Drawing.Point(0, 353);
        this.radStatusStrip1.Name = "radStatusStrip1";
        this.radStatusStrip1.Size = new System.Drawing.Size(490, 26);
        this.radStatusStrip1.TabIndex = 3;
        this.radStatusStrip1.Text = "radStatusStrip1";
        // 
        // lblStatus
        // 
        this.lblStatus.AccessibleDescription = "Ready";
        this.lblStatus.AccessibleName = "Ready";
        this.lblStatus.ForeColor = System.Drawing.Color.White;
        this.lblStatus.Name = "lblStatus";
        this.lblStatus.Text = "Ready";
        // 
        // progressBar
        // 
        this.progressBar.AccessibleDescription = "(0/0)";
        this.progressBar.AccessibleName = "(0/0)";
        this.progressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
        this.progressBar.AutoSize = false;
        this.progressBar.Name = "progressBar";
        // 
        // lblHofFile
        // 
        this.lblHofFile.AutoSize = false;
        this.lblHofFile.Location = new System.Drawing.Point(12, 136);
        this.lblHofFile.Name = "lblHofFile";
        this.lblHofFile.Size = new System.Drawing.Size(74, 18);
        this.lblHofFile.TabIndex = 4;
        this.lblHofFile.Text = "HOF File:";
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
        // 
        // listView
        // 
        this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
        | System.Windows.Forms.AnchorStyles.Left) 
        | System.Windows.Forms.AnchorStyles.Right)));
        this.listView.Location = new System.Drawing.Point(12, 199);
        this.listView.MultiSelect = true;
        this.listView.Name = "listView";
        this.listView.ShowGroups = true;
        this.listView.Size = new System.Drawing.Size(466, 111);
        this.listView.TabIndex = 10;
        this.listView.Text = "radListView1";
        // 
        // checkOverwrite
        // 
        this.checkOverwrite.Location = new System.Drawing.Point(15, 173);
        this.checkOverwrite.Name = "checkOverwrite";
        this.checkOverwrite.Size = new System.Drawing.Size(116, 18);
        this.checkOverwrite.TabIndex = 11;
        this.checkOverwrite.Text = " Overwrite existing";
        // 
        // lblListDir
        // 
        this.lblListDir.AutoSize = false;
        this.lblListDir.Location = new System.Drawing.Point(12, 109);
        this.lblListDir.Name = "lblListDir";
        this.lblListDir.Size = new System.Drawing.Size(74, 18);
        this.lblListDir.TabIndex = 10;
        this.lblListDir.Text = "Line list dir:";
        // 
        // Distributor
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(490, 379);
        this.Controls.Add(this.checkOverwrite);
        this.Controls.Add(this.lblListDir);
        this.Controls.Add(this.listView);
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
        this.ShowIcon = false;
        this.ShowInTaskbar = false;
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "HOF Distributor";
        this.Load += new System.EventHandler(this.Distributor_Load);
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private Label lblHeading;
    private Label lblDesc;
    private Button btnStart;
    private StatusStrip radStatusStrip1;
    private ToolStripStatusLabel lblStatus;
    private Label lblHofFile;
    private Label radLabel4;
    private ToolStripProgressBar progressBar;
    private OpenFileDialog fileSelector;
    private ListView listView;
    private CheckBox checkOverwrite;
    private FolderBrowserDialog dirSelector;
    private Label lblListDir;
}