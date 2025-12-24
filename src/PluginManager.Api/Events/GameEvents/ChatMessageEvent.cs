using System.Collections.Generic;
using PluginManager.Api.Proxy;

namespace PluginManager.Api.Events.GameEvents;

public sealed class ChatMessageEvent(
    ClientInfo clientInfo,
    EChatType chatType,
    string name,
    string message,
    List<int> recipientEntityIds,
    GeneratedTextManager.BbCodeSupportMode bbMode)
    : ProxyObject, IGameEvent
{
    public string EventName => nameof(ChatMessageEvent);

    public ClientInfo ClientInfo { get; set; } = clientInfo;
    public EChatType ChatType { get; set; } = chatType;
    public string Name { get; set; } = name;
    public string Message { get; set; } = message;
    public List<int> RecipientEntityIds { get; set; } = recipientEntityIds;
    public GeneratedTextManager.BbCodeSupportMode BBMode { get; set; } = bbMode;
}