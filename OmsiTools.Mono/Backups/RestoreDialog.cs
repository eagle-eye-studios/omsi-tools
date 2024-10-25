using System.Windows.Forms;
using OmsiTools.Common.Backups;

namespace OmsiTools.Mono.Backups;

public partial class RestoreDialog : Form
{
    public RestoreDialog(Backup backup)
    {
        InitializeComponent();
        treeView.Nodes.Clear();
        treeView.AddNodeByPath("OMSI 2");
        foreach (var node in backup.Files)
        {
            treeView.AddNodeByPath(Path.Combine("OMSI 2", node));
        }
    }
}