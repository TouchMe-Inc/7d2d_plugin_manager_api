namespace PluginManager.Api.Exposed.Events.GameEvents;

public class ChatMessageEvent : IGameEvent
{
    public string EventName => nameof(ChatMessageEvent);
}