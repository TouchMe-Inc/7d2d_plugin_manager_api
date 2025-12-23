using PluginManager.Api.Contracts;
using PluginManager.Api.Proxy;

namespace PluginManager.Api.Capabilities.Implementations.Events.GameEvents;

public class TileEntityAccessAttemptEvent(
    int entityId,
    TileEntityType tileEntityType,
    Vector3Int tileEntityPosition
) : ProxyObject, IGameEvent
{
    public string EventName => nameof(TileEntityAccessAttemptEvent);

    public int EntityId { get; set; } = entityId;
    public TileEntityType TileEntityType { get; set; } = tileEntityType;
    public Vector3Int TileEntityPosition { get; set; } = tileEntityPosition;
}