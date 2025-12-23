using System.Collections.Generic;
using PluginManager.Api.Contracts;
using PluginManager.Api.Proxy;

namespace PluginManager.Api.Capabilities.Implementations.Events.GameEvents;

public sealed class ChatMessageEvent(
    ClientInfo clientInfo,
    ChatType chatType,
    string name,
    string message,
    List<int> recipientEntityIds,
    BbCodeSupportMode bbMode)
    : ProxyObject, IGameEvent
{
    public string EventName => nameof(ChatMessageEvent);

    public ClientInfo ClientInfo { get; set; } = clientInfo;
    public ChatType ChatType { get; set; } = chatType;
    public string Name { get; set; } = name;
    public string Message { get; set; } = message;
    public List<int> RecipientEntityIds { get; set; } = recipientEntityIds;
    public BbCodeSupportMode BBMode { get; set; } = bbMode;
}