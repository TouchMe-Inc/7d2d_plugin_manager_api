using PluginManager.Api.Proxy;

namespace PluginManager.Api.Contracts;

public class ClientInfo(int entityId, string platformId, string crossplatformId, string name)
    : ProxyObject
{
    public int EntityId { get; } = entityId;
    public string PlatformId { get; } = platformId;
    public string CrossplatformId { get; } = crossplatformId;
    public string Name { get; } = name;

    public override string ToString()
    {
        return $"{Name} (EntityId: {EntityId}, PlatformId: {PlatformId}, CrossplatformId: {CrossplatformId})";
    }
}