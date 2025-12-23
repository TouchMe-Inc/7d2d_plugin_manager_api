using PluginManager.Api.Proxy;

namespace PluginManager.Api.Capabilities.Implementations.Events.GameEvents;

public sealed class PlayerSpawnedInWorldEvent : ProxyObject, IGameEvent
{
    public string EventName => nameof(PlayerSpawnedInWorldEvent);
}