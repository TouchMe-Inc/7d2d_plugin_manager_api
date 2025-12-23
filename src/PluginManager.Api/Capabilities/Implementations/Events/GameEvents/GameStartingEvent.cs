using PluginManager.Api.Proxy;

namespace PluginManager.Api.Capabilities.Implementations.Events.GameEvents;

public sealed class GameStartingEvent : ProxyObject, IGameEvent
{
    public string EventName => nameof(GameStartingEvent);
}