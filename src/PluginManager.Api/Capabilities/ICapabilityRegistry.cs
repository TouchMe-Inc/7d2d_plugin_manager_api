using System.Collections.Generic;

namespace PluginManager.Api.Capabilities;

public interface ICapabilityRegistry
{
    void Register<T>(T capability) where T : ICapability;
    void Deregister<T>(T capability) where T : ICapability;
    T Get<T>() where T : ICapability;
    T Get<T>(string name) where T : ICapability;
    IEnumerable<ICapability> GetAll();
}