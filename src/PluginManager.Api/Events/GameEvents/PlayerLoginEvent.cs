using PluginManager.Api.Proxy;

namespace PluginManager.Api.Events.GameEvents;

public class PlayerLoginEvent(ClientInfo clientInfo) : ProxyObject, IGameEvent
{
    public string EventName => nameof(PlayerJoinedGameEvent);

    public ClientInfo ClientInfo { get; set; } = clientInfo;
}