using PluginManager.Api.Contracts;
using PluginManager.Api.Proxy;

namespace PluginManager.Api.Capabilities.Implementations.Events.GameEvents;

public sealed class PlayerSpawnedInWorldEvent(ClientInfo clientInfo, RespawnType respawnType) : ProxyObject, IGameEvent
{
    public string EventName => nameof(PlayerSpawnedInWorldEvent);
    
    public ClientInfo ClientInfo { get; set; } = clientInfo;
    public RespawnType RespawnType { get; set; } = respawnType;
}