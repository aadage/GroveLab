using Microsoft.AspNetCore.Components;

namespace GroveLab.Components;

public partial class Toggler
{
    [Parameter] public bool Enabled { get; set; } = false;
    [Parameter] public EventCallback<bool> EnabledChanged { get; set; }

    private async Task Toggle()
    {
        Enabled = !Enabled;
        await EnabledChanged.InvokeAsync(Enabled);
    }
}
