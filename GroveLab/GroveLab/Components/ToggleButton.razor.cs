namespace GroveLab.Components;

public partial class ToggleButton : TogglerBase 
{
    private Dictionary<string, object> Attributes => Enabled ? new Dictionary<string, object> { { "class", "ToggleButton-enabled" } } : new Dictionary<string, object> { { "class", "ToggleButton-disabled" } };
}
