using PluginManager.Api.Capabilities;

namespace PluginManager.Api.ChatMessenger;

public interface IChatMessenger : ICapability
{
    void SendTo(int entityId, string message);
}