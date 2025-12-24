using PluginManager.Api.Contracts;
using PluginManager.Api.Proxy;

namespace PluginManager.Api.Capabilities.Implementations.Events.GameEvents;

public class TileEntityAccessAttemptEvent(
    int entityIdThatOpenedIt,
    TileEntityType tileEntityType
) : ProxyObject, IGameEvent
{
    public string EventName => nameof(TileEntityAccessAttemptEvent);

    public int EntityIdThatOpenedIt { get; set; } = entityIdThatOpenedIt;
    public TileEntityType TileEntityType { get; set; } = tileEntityType;
}