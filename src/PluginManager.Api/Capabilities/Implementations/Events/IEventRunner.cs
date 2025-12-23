using PluginManager.Api.Hooks;

namespace PluginManager.Api.Capabilities.Implementations.Events;

public interface IEventRunner : ICapability
{
    HookResult Publish<T>(T evt, HookMode mode) where T : IGameEvent;
}