using PluginManager.Api.Hooks;

namespace PluginManager.Api.Events;

public interface IEventRunner
{
    HookResult Publish<T>(T evt, HookMode mode) where T : IGameEvent;
}