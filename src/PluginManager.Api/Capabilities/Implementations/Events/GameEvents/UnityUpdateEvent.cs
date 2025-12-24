using PluginManager.Api.Proxy;

namespace PluginManager.Api.Capabilities.Implementations.Events.GameEvents;

public sealed class UnityUpdateEvent : ProxyObject, IGameEvent
{
    public string EventName => nameof(UnityUpdateEvent);
}