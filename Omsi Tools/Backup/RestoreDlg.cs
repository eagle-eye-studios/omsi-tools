using System;
using System.IO;

namespace OmsiTools.Backup
{
    public partial class RestoreDlg : Telerik.WinControls.UI.RadForm
    {
        public RestoreDlg(Backup backup)
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
