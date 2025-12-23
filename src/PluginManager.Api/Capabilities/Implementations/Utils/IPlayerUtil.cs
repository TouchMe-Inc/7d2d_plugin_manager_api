using PluginManager.Api.Contracts;

namespace PluginManager.Api.Capabilities.Implementations.Utils;

public interface IPlayerUtil : ICapability
{
    void Kick(int entityId);
    void Teleport(int entityId, Vector3 position);
    Vector3 GetPlayerPosition(int entityId);
    LandClaimOwner GetClaimOwner(int entityId, Vector3Int position);
}