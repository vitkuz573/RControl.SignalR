namespace RControl.Client.Models;

public class Folder : TreeItem
{
    public List<TreeItem> Children { get; set; } = new List<TreeItem>();

    public override void ToggleExpansion()
    {
        IsExpanded = !IsExpanded;
    }
}
