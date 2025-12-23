using PluginManager.Api.Contracts;
using PluginManager.Api.Proxy;

namespace PluginManager.Api.Capabilities.Implementations.Events.GameEvents;

public sealed class PlayerJoinedGameEvent(ClientInfo clientInfo) : ProxyObject, IGameEvent
{
    public string EventName => nameof(PlayerJoinedGameEvent);

    public ClientInfo ClientInfo { get; set; } = clientInfo;
}