using PluginManager.Api.Proxy;

namespace PluginManager.Api.Capabilities.Implementations.Events.GameEvents;

public class GameUpdateEvent : ProxyObject, IGameEvent
{
    public string EventName => nameof(GameUpdateEvent);
}