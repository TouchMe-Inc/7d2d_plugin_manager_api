using PluginManager.Api.Contracts;
using PluginManager.Api.Proxy;

namespace PluginManager.Api.Capabilities.Implementations.Events.GameEvents;

public sealed class PlayerSpawningEvent(ClientInfo clientInfo) : ProxyObject, IGameEvent
{
    public string EventName => nameof(PlayerSpawningEvent);
    
    public ClientInfo ClientInfo { get; set; } = clientInfo;
}