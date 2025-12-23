using PluginManager.Api.Proxy;

namespace PluginManager.Api.Capabilities.Implementations.Events.GameEvents;

public class PlayerDisconnectedEvent : ProxyObject, IGameEvent
{
    public string EventName => nameof(PlayerDisconnectedEvent);
}