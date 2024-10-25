using System.IO;

namespace OmsiTools.Win.Backups
{
    public partial class RestoreDlg : Telerik.WinControls.UI.RadForm
    {
        public RestoreDlg(Common.Backups.Backup backup)
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
}
