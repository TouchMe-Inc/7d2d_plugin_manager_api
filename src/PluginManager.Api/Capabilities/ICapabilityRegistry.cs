using System;

namespace PluginManager.Api.Capabilities;

public interface ICapabilityRegistry
{
    void Register<T>(IPluginCapability<T> capability, Func<T> supplier);
    void Deregister<T>(IPluginCapability<T> capability);
    T Resolve<T>(IPluginCapability<T> capability);
}