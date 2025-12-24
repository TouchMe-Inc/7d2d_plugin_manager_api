using PluginManager.Api.Hooks;
using PluginManager.Api.Proxy;

namespace PluginManager.Api.Events;

public interface IEventHandlers
{
    void RegisterHandler<T>(DelegateProxy proxy, HookMode mode) where T : IGameEvent;

    void DeregisterHandler<T>(DelegateProxy proxy, HookMode mode) where T : IGameEvent;
}