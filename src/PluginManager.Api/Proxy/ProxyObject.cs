using System;

namespace PluginManager.Api.Proxy;

public abstract class ProxyObject : MarshalByRefObject
{
    public override object InitializeLifetimeService() => null;
}