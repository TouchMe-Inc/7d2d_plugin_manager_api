using PluginManager.Api.Hooks;
using PluginManager.Api.Proxy;

namespace PluginManager.Api.Capabilities.Implementations.Events;

public interface IEventHandlers : ICapability
{
    void RegisterHandler<T>(DelegateProxy proxy, HookMode mode) where T : IGameEvent;

    void DeregisterHandler<T>(DelegateProxy proxy, HookMode mode) where T : IGameEvent;
}