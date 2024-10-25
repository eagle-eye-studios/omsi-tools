using System.ComponentModel;
using System.Windows.Forms;

namespace OmsiTools.Mono;

partial class AboutBox
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
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
        this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
        this.radLabelProductName = new Label();
        this.radLabelVersion = new Label();
        this.radLabelCopyright = new Label();
        this.radLabelCompanyName = new Label();
        this.radTextBoxDescription = new TextBox();
        this.okRadButton = new Button();
        this.tableLayoutPanel.SuspendLayout();
        this.SuspendLayout();
        // 
        // tableLayoutPanel
        // 
        this.tableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
        this.tableLayoutPanel.ColumnCount = 1;
        this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 97.93814F));
        this.tableLayoutPanel.Controls.Add(this.radLabelProductName, 0, 0);
        this.tableLayoutPanel.Controls.Add(this.radLabelVersion, 0, 1);
        this.tableLayoutPanel.Controls.Add(this.radLabelCopyright, 0, 2);
        this.tableLayoutPanel.Controls.Add(this.radLabelCompanyName, 0, 3);
        this.tableLayoutPanel.Controls.Add(this.radTextBoxDescription, 0, 4);
        this.tableLayoutPanel.Controls.Add(this.okRadButton, 0, 5);
        this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tableLayoutPanel.Location = new System.Drawing.Point(9, 9);
        this.tableLayoutPanel.Name = "tableLayoutPanel";
        this.tableLayoutPanel.RowCount = 6;
        this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
        this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
        this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
        this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
        this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
        this.tableLayoutPanel.Size = new System.Drawing.Size(388, 265);
        this.tableLayoutPanel.TabIndex = 0;
        // 
        // radLabelProductName
        // 
        this.radLabelProductName.Dock = System.Windows.Forms.DockStyle.Fill;
        this.radLabelProductName.Location = new System.Drawing.Point(6, 0);
        this.radLabelProductName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
        this.radLabelProductName.MaximumSize = new System.Drawing.Size(0, 17);
        this.radLabelProductName.Name = "radLabelProductName";
        // 
        // 
        // 
        this.radLabelProductName.Size = new System.Drawing.Size(78, 17);
        this.radLabelProductName.TabIndex = 19;
        this.radLabelProductName.Text = "Product Name";
        // 
        // radLabelVersion
        // 
        this.radLabelVersion.Dock = System.Windows.Forms.DockStyle.Fill;
        this.radLabelVersion.Location = new System.Drawing.Point(6, 26);
        this.radLabelVersion.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
        this.radLabelVersion.MaximumSize = new System.Drawing.Size(0, 17);
        this.radLabelVersion.Name = "radLabelVersion";
        // 
        // 
        // 
        this.radLabelVersion.Size = new System.Drawing.Size(44, 17);
        this.radLabelVersion.TabIndex = 0;
        this.radLabelVersion.Text = "Version";
        // 
        // radLabelCopyright
        // 
        this.radLabelCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
        this.radLabelCopyright.Location = new System.Drawing.Point(6, 52);
        this.radLabelCopyright.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
        this.radLabelCopyright.MaximumSize = new System.Drawing.Size(0, 17);
        this.radLabelCopyright.Name = "radLabelCopyright";
        // 
        // 
        // 
        this.radLabelCopyright.Size = new System.Drawing.Size(56, 17);
        this.radLabelCopyright.TabIndex = 21;
        this.radLabelCopyright.Text = "Copyright";
        // 
        // radLabelCompanyName
        // 
        this.radLabelCompanyName.Dock = System.Windows.Forms.DockStyle.Fill;
        this.radLabelCompanyName.Location = new System.Drawing.Point(6, 78);
        this.radLabelCompanyName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
        this.radLabelCompanyName.MaximumSize = new System.Drawing.Size(0, 17);
        this.radLabelCompanyName.Name = "radLabelCompanyName";
        // 
        // 
        // 
        this.radLabelCompanyName.Size = new System.Drawing.Size(87, 17);
        this.radLabelCompanyName.TabIndex = 22;
        this.radLabelCompanyName.Text = "Company Name";
        // 
        // radTextBoxDescription
        // 
        this.radTextBoxDescription.AutoSize = false;
        this.radTextBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
        this.radTextBoxDescription.Location = new System.Drawing.Point(6, 107);
        this.radTextBoxDescription.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
        this.radTextBoxDescription.Multiline = true;
        this.radTextBoxDescription.Name = "radTextBoxDescription";
        this.radTextBoxDescription.ReadOnly = true;
        this.radTextBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.radTextBoxDescription.Size = new System.Drawing.Size(379, 126);
        this.radTextBoxDescription.TabIndex = 23;
        this.radTextBoxDescription.TabStop = false;
        this.radTextBoxDescription.Text = "Description";
        this.radTextBoxDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // okRadButton
        // 
        this.okRadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.okRadButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        this.okRadButton.Location = new System.Drawing.Point(310, 239);
        this.okRadButton.Name = "okRadButton";
        this.okRadButton.Size = new System.Drawing.Size(75, 23);
        this.okRadButton.TabIndex = 24;
        this.okRadButton.Text = "&OK";
        // 
        // AboutBox
        // 
        this.AcceptButton = this.okRadButton;
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(406, 283);
        this.Controls.Add(this.tableLayoutPanel);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "AboutBox";
        this.Padding = new System.Windows.Forms.Padding(9);
        // 
        // 
        // 
        this.ShowIcon = false;
        this.ShowInTaskbar = false;
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "AboutBox";
        this.tableLayoutPanel.ResumeLayout(false);
        this.tableLayoutPanel.PerformLayout();
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
    private Label radLabelProductName;
    private Label radLabelVersion;
    private Label radLabelCopyright;
    private Label radLabelCompanyName;
    private TextBox radTextBoxDescription;
    private Button okRadButton;
}