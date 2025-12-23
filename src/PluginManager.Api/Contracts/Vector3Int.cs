using PluginManager.Api.Proxy;

namespace PluginManager.Api.Contracts;

public class Vector3Int(int x, int y, int z = 0): ProxyObject
{
    public int X { get; } = x; 
    public int Y { get; } = y;
    public int Z { get; } = z;
}