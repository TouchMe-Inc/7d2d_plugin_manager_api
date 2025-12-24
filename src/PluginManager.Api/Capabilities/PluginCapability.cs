using System;
using PluginManager.Api.Proxy;

namespace PluginManager.Api.Capabilities;

public sealed class PluginCapability<T>(string name)
    : ProxyObject, IPluginCapability<T>, IEquatable<PluginCapability<T>>
{
    public string Name { get; } = name;

    public bool Equals(PluginCapability<T> other)
    {
        if (other is null) return false;
        if (ReferenceEquals(this, other)) return true;
        return Name == other.Name;
    }

    public override bool Equals(object obj)
    {
        return ReferenceEquals(this, obj) || obj is PluginCapability<T> other && Equals(other);
    }

    public override int GetHashCode()
    {
        unchecked
        {
            var hash = 17;
            hash = hash * 23 + typeof(T).GetHashCode();
            hash = hash * 23 + (Name?.GetHashCode() ?? 0);
            return hash;
        }
    }

    public override string ToString() => $"{typeof(T).Name}:{Name}";
}