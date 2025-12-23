using PluginManager.Api.Contracts;
using PluginManager.Api.Proxy;

namespace PluginManager.Api.Capabilities.Implementations.Events.GameEvents;

public class PlayerDisconnectedEvent(ClientInfo clientInfo) : ProxyObject, IGameEvent
{
    public string EventName => nameof(PlayerDisconnectedEvent);
    
    public ClientInfo ClientInfo { get; set; } = clientInfo;
}