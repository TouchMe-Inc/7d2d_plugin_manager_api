using PluginManager.Api.Proxy;

namespace PluginManager.Api.Capabilities.Implementations.Events.GameEvents;

public sealed class MinEventLogMessageEvent(string message) : ProxyObject, IGameEvent
{
    public string EventName => nameof(MinEventLogMessageEvent);

    public string Message => message;
}