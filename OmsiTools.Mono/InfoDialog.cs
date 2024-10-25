using System.Windows.Forms;

namespace OmsiTools.Mono;

public partial class InfoDialog : Form
{
    public InfoDialog()
    {
        InitializeComponent();
    }

    private void InfoDlg_Load(object sender, EventArgs e)
    {
        radWaitingBar1.Style = ProgressBarStyle.Continuous;
    }
}