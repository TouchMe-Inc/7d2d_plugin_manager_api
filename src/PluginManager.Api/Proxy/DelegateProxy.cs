using System;
using System.Reflection;

namespace PluginManager.Api.Proxy;

public sealed class DelegateProxy : ProxyObject
{
    private readonly MethodInfo _method;
    private readonly object _target;

    public DelegateProxy(Delegate del)
    {
        if (del == null) throw new ArgumentNullException(nameof(del));
        _method = del.Method;
        _target = del.Target;
    }

    public object Invoke(params object[] args) => _method.Invoke(_target, args);

    public bool Matches(Delegate del) => _method == del.Method && Equals(_target, del.Target);

    public override bool Equals(object obj)
    {
        if (obj is DelegateProxy other) return _method == other._method && Equals(_target, other._target);
        return false;
    }

    public override int GetHashCode()
    {
        unchecked
        {
            var hash = 17;
            hash = hash * 23 + (_method != null ? _method.GetHashCode() : 0);
            hash = hash * 23 + (_target != null ? _target.GetHashCode() : 0);
            return hash;
        }
    }
}