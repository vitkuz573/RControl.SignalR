namespace RControl.Client.Models;

public class Computer : TreeItem
{
    public string Description { get; set; }

    public string IPAddress { get; set; }

    public string Screenshot { get; set; }

    public override void ToggleExpansion()
    {
        // Computers cannot be expanded
    }
}
