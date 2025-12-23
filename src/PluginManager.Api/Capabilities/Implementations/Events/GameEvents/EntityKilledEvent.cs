using PluginManager.Api.Proxy;

namespace PluginManager.Api.Capabilities.Implementations.Events.GameEvents;

public class EntityKilledEvent : ProxyObject, IGameEvent
{
    public string EventName => nameof(EntityKilledEvent);
}