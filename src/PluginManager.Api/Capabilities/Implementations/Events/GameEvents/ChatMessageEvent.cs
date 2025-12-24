using System.Collections.Generic;
using PluginManager.Api.Proxy;

namespace PluginManager.Api.Capabilities.Implementations.Events.GameEvents;

public sealed class ChatMessageEvent(
    int entityId,
    EChatType chatType,
    string name,
    string message,
    List<int> recipientEntityIds,
    GeneratedTextManager.BbCodeSupportMode bbMode)
    : ProxyObject, IGameEvent
{
    public string EventName => nameof(ChatMessageEvent);

    public int EntityId { get; set; } = entityId;
    public EChatType ChatType { get; set; } = chatType;
    public string Name { get; set; } = name;
    public string Message { get; set; } = message;
    public List<int> RecipientEntityIds { get; set; } = recipientEntityIds;
    public GeneratedTextManager.BbCodeSupportMode BBMode { get; set; } = bbMode;
}