using System.ComponentModel;
using System.Windows.Forms;

namespace OmsiTools.Mono.Backups;

partial class BackupTool
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
        ColumnHeader listViewDetailColumn1 = new ColumnHeader();
        listViewDetailColumn1.Name = "Column 0";
        listViewDetailColumn1.Text = "Creation Date";
        ColumnHeader listViewDetailColumn2 = new ColumnHeader();
        listViewDetailColumn1.Name = "Column 1";
        listViewDetailColumn1.Text = "Folder";
        ColumnHeader listViewDetailColumn3 = new ColumnHeader();
        listViewDetailColumn1.Name = "Column 2";
        listViewDetailColumn1.Text = "Size";
        
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupTool));
        this.listView = new ListView();
        this.radLabel1 = new Label();
        this.radLabel2 = new Label();
        this.btnAdd = new Button();
        this.btnRestore = new Button();
        this.radStatusStrip1 = new StatusStrip();
        this.progressBar = new ToolStripProgressBar();
        this.lblStatus = new ToolStripLabel();
        this.SuspendLayout();
        // 
        // listView
        // 
        this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
        | System.Windows.Forms.AnchorStyles.Left) 
        | System.Windows.Forms.AnchorStyles.Right)));
        listViewDetailColumn3.Width = 60;
        this.listView.Columns.AddRange(new ColumnHeader[] {
            listViewDetailColumn1,
            listViewDetailColumn2,
            listViewDetailColumn3
        });
        this.listView.Location = new System.Drawing.Point(12, 149);
        this.listView.Name = "listView";
        this.listView.Size = new System.Drawing.Size(482, 166);
        this.listView.TabIndex = 0;
        this.listView.Text = "radListView1";
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
        // 
        // btnAdd
        // 
        this.btnAdd.Location = new System.Drawing.Point(12, 111);
        this.btnAdd.Name = "btnAdd";
        this.btnAdd.Size = new System.Drawing.Size(110, 24);
        this.btnAdd.TabIndex = 3;
        this.btnAdd.Text = "New";
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
        this.btnRestore.Click += new System.EventHandler(this.RestoreBackup);
        // 
        // radStatusStrip1
        // 
        this.radStatusStrip1.Items.AddRange(new ToolStripItem[] { 
            this.progressBar,
            this.lblStatus
        });
        this.radStatusStrip1.Location = new System.Drawing.Point(0, 325);
        this.radStatusStrip1.Name = "radStatusStrip1";
        this.radStatusStrip1.Size = new System.Drawing.Size(506, 26);
        this.radStatusStrip1.TabIndex = 5;
        this.radStatusStrip1.Text = "radStatusStrip1";
        // 
        // progressBar
        // 
        this.progressBar.AutoSize = false;
        this.progressBar.Name = "progressBar";
        this.progressBar.Step = 14;
        // 
        // lblStatus
        // 
        this.lblStatus.AccessibleDescription = "Ready";
        this.lblStatus.AccessibleName = "Ready";
        this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        this.lblStatus.Name = "lblStatus";
        this.lblStatus.Text = "Ready";
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
        this.ShowInTaskbar = false;
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "";
        this.Shown += new System.EventHandler(this.BackupTool_Loaded);
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private ListView listView;
    private Label radLabel1;
    private Label radLabel2;
    private Button btnAdd;
    private Button btnRestore;
    private StatusStrip radStatusStrip1;
    private ToolStripProgressBar progressBar;
    private ToolStripLabel lblStatus;
}