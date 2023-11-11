using Microsoft.AspNetCore.Components;

namespace GroveLab.Components;

public partial class TogglerBase : ComponentBase
{
    [Parameter] public bool Enabled { get; set; } = false;
    [Parameter] public EventCallback<bool> EnabledChanged { get; set; }

    protected async Task Toggle()
    {
        Enabled = !Enabled;
        await EnabledChanged.InvokeAsync(Enabled);
    }
}
