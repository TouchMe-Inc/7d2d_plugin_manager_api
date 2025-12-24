using PluginManager.Api.Proxy;

namespace PluginManager.Api.Events.GameEvents;

public class PlayerJoinedGameEvent(ClientInfo clientInfo) : ProxyObject, IGameEvent
{
    public string EventName => nameof(PlayerJoinedGameEvent);

    public ClientInfo ClientInfo { get; set; } = clientInfo;
}