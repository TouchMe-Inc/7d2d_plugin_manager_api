using System;
using System.Collections.Generic;
using System.Linq;
using PluginManager.Api.Capabilities;
using PluginManager.Api.Capabilities.Implementations.ChatMessenger;
using PluginManager.Api.Capabilities.Implementations.Commands;
using PluginManager.Api.Capabilities.Implementations.Events;
using PluginManager.Api.Capabilities.Implementations.Logger;
using PluginManager.Api.Hooks;
using PluginManager.Api.Proxy;

namespace PluginManager.Api;

public abstract class BasePlugin : IPlugin
{
    public abstract string ModuleName { get; }
    public abstract string ModuleVersion { get; }
    public abstract string ModuleAuthor { get; }
    public abstract string ModuleDescription { get; }
    public string ModulePath { get; set; }

    protected ICapabilityRegistry Capabilities { get; private set; } = null!;
    protected ILogger Log => Capabilities.Get<ILogger>();
    protected IEventHandlers Events => Capabilities.Get<IEventHandlers>();
    protected ICommandManager CommandManager => Capabilities.Get<ICommandManager>();
    protected IChatMessenger ChatMessenger => Capabilities.Get<IChatMessenger>();

    private readonly List<CommandDefinition> _registeredCommands = [];
    private readonly List<(DelegateProxy Proxy, Type EventType, HookMode Mode)> _registeredHandlers = [];

    private bool _disposed;

    public void Load(ICapabilityRegistry registry)
    {
        Capabilities = registry;
        OnLoad();
    }

    public void Unload(ICapabilityRegistry registry)
    {
        OnUnload();
    }

    protected virtual void OnLoad()
    {
    }

    protected virtual void OnUnload()
    {
    }

    protected void RegisterEventHandler<TEvent>(Func<TEvent, HookResult> handler, HookMode mode)
        where TEvent : IGameEvent
    {
        var proxy = new DelegateProxy(handler);
        Events.RegisterHandler<TEvent>(proxy, mode);
        _registeredHandlers.Add((proxy, typeof(TEvent), mode));
    }

    protected void DeregisterEventHandler<TEvent>(Func<TEvent, HookResult> handler, HookMode mode)
        where TEvent : IGameEvent
    {
        var proxy = new DelegateProxy(handler);
        Events.DeregisterHandler<TEvent>(proxy, mode);
        _registeredHandlers.RemoveAll(h => h.EventType == typeof(TEvent) && h.Mode == mode && h.Proxy.Equals(proxy));
    }

    protected void RegisterCommand(string name, string description, Action<ICommandContext> callback)
    {
        var proxy = new DelegateProxy(callback);
        var definition = new CommandDefinition(name, description, proxy);

        CommandManager.RegisterCommand(definition);
        _registeredCommands.Add(definition);
    }

    protected void DeregisterCommand(string name)
    {
        var definition =
            _registeredCommands.FirstOrDefault(cmd =>
                string.Equals(cmd.Name, name, StringComparison.OrdinalIgnoreCase));

        if (definition == null) return;
        CommandManager.DeregisterCommand(definition);
        _registeredCommands.Remove(definition);
    }

    private void DeregisterCommands()
    {
        foreach (var command in _registeredCommands.ToList())
        {
            CommandManager.DeregisterCommand(command);
            _registeredCommands.Remove(command);
        }
    }

    private void DeregisterEvents()
    {
        var method = typeof(IEventHandlers).GetMethod(nameof(Events.DeregisterHandler),
            [typeof(DelegateProxy), typeof(HookMode)]);
        if (method == null) return;

        foreach (var (proxy, eventType, mode) in _registeredHandlers.ToList())
        {
            var generic = method.MakeGenericMethod(eventType);
            generic.Invoke(Events, [proxy, mode]);
            _registeredHandlers.Remove((proxy, eventType, mode));
        }
    }

    public void Dispose()
    {
        if (_disposed) return;

        DeregisterCommands();
        DeregisterEvents();

        _disposed = true;
    }
}