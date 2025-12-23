using PluginManager.Api.Proxy;

namespace PluginManager.Api.Contracts;

public class Vector3(float x, float y, float z = 0.0f): ProxyObject
{
    public float X { get; } = x; 
    public float Y { get; } = y; 
    public float Z { get; } = z;
}