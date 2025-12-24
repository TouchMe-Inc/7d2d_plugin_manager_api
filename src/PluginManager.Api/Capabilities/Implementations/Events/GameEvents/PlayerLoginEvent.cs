using PluginManager.Api.Proxy;

namespace PluginManager.Api.Capabilities.Implementations.Events.GameEvents;

public sealed class PlayerLoginEvent(int entityId) : ProxyObject, IGameEvent
{
    public string EventName => nameof(PlayerJoinedGameEvent);

    public int EntityId { get; set; } = entityId;
}