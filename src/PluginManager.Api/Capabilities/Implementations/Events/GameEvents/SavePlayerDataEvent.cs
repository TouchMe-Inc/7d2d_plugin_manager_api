using PluginManager.Api.Proxy;

namespace PluginManager.Api.Capabilities.Implementations.Events.GameEvents;

public sealed class SavePlayerDataEvent : ProxyObject, IGameEvent
{
    public string EventName => nameof(SavePlayerDataEvent);
}