using PluginManager.Api.Hooks;

namespace PluginManager.Api.Exposed.Events;

public interface IModEvents
{
    public delegate HookResult GameEventHandler<T>(T @event) where T : IGameEvent;
    
    void RegisterEventHandler<T>(GameEventHandler<T> handler, HookMode hookMode = HookMode.Post) where T : IGameEvent;
    void DeregisterEventHandler<T>(GameEventHandler<T> handler, HookMode hookMode = HookMode.Post) where T : IGameEvent;
}