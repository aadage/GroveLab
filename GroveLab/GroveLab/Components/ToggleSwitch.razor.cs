using Microsoft.AspNetCore.Components;

namespace GroveLab.Components;

public partial class ToggleSwitch : TogglerBase
{
    private async Task CheckboxChanged(ChangeEventArgs e)
    {
        await Toggle();
    }
}
