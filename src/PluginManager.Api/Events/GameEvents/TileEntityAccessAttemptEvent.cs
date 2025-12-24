using PluginManager.Api.Proxy;

namespace PluginManager.Api.Events.GameEvents;

public class TileEntityAccessAttemptEvent(
    int entityIdThatOpenedIt,
    TileEntity te
) : ProxyObject, IGameEvent
{
    public string EventName => nameof(TileEntityAccessAttemptEvent);

    public int EntityIdThatOpenedIt { get; set; } = entityIdThatOpenedIt;
    public TileEntity TileEntity { get; set; } = te;
}