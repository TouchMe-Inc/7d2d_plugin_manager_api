namespace PluginManager.Api.Capabilities.Implementations.ChatMessenger;

public interface IChatMessenger : ICapability
{
    void SendTo(int entityId, string message);
}