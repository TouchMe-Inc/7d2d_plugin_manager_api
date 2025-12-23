using PluginManager.Api.Proxy;

namespace PluginManager.Api.Capabilities.Implementations.Events.GameEvents;

public sealed class CreateWorldDoneEvent : ProxyObject, IGameEvent
{
    public string EventName => nameof(CreateWorldDoneEvent);
}