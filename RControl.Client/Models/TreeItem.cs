namespace RControl.Client.Models;

public abstract class TreeItem
{
    public string Name { get; set; }

    public bool IsExpanded { get; set; }

    public abstract void ToggleExpansion();
}