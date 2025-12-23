using PluginManager.Api.Proxy;

namespace PluginManager.Api.Capabilities.Implementations.Events.GameEvents;

public sealed class GameShutdownEvent : ProxyObject, IGameEvent
{
    public string EventName => nameof(GameShutdownEvent);
}