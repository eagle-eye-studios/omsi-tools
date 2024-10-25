using System.Windows.Forms;

namespace OmsiTools.Mono;

public static class TreeViewExtension
{
    public static void AddNodeByPath(this TreeView treeView, string path)
    {
        var parts = path.Split('\\');
        var nodes = treeView.Nodes;
        foreach (var part in parts)
        {
            var node = nodes.Find(part, false).FirstOrDefault() ?? nodes.Add(part, part);
            nodes = node.Nodes;
        }
    }
}