using PluginManager.Api.Proxy;

namespace PluginManager.Api.Capabilities.Implementations.Events.GameEvents;

public sealed class ServerRegisteredEvent : ProxyObject, IGameEvent
{
    public string EventName => nameof(ServerRegisteredEvent);
}