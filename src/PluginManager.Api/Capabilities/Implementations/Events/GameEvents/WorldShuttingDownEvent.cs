using PluginManager.Api.Proxy;

namespace PluginManager.Api.Capabilities.Implementations.Events.GameEvents;

public sealed class WorldShuttingDownEvent : ProxyObject, IGameEvent
{
    public string EventName => nameof(WorldShuttingDownEvent);
}