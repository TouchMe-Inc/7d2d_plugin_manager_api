using System;
using System.Collections.Generic;
using PluginManager.Api.Capabilities;
using PluginManager.Api.Commands;
using PluginManager.Api.Events;
using PluginManager.Api.Logger;
using PluginManager.Api.Hooks;
using PluginManager.Api.Proxy;

namespace PluginManager.Api;

public abstract class BasePlugin : IPlugin
{
    public abstract string ModuleName { get; }
    public abstract string ModuleVersion { get; }
    public abstract string ModuleAuthor { get; }
    public abstract string ModuleDescription { get; }

    protected ICapabilityRegistry Capabilities { get; private set; } = null!;

    protected ILogger Log => Capabilities.Resolve(new PluginCapability<ILogger>("Logger"));
    protected IEventHandlers Events => Capabilities.Resolve(new PluginCapability<IEventHandlers>("Events"));

    protected ICommandManager CommandManager =>
        Capabilities.Resolve(new PluginCapability<ICommandManager>("CommandManager"));

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
    }

    protected void DeregisterEventHandler<TEvent>(Func<TEvent, HookResult> handler, HookMode mode)
        where TEvent : IGameEvent
    {
        var proxy = new DelegateProxy(handler);
        Events.DeregisterHandler<TEvent>(proxy, mode);
    }

    protected void RegisterCommand<TCommand>(string name, string description,
        Action<List<string>, CommandSenderInfo> callback)
    {
        var proxy = new DelegateProxy(callback);
        var definition = new CommandDefinition(name, description, proxy);
        CommandManager.RegisterCommand(definition);
    }

    // protected void DeregisterCommand<TCommand>(string name, string description,
    //     Action<List<string>, CommandSenderInfo> callback)
    // {
    //     var proxy = new DelegateProxy(callback);
    //     var definition = new CommandDefinition(name, description, proxy);
    //     CommandManager.DeregisterCommand(definition);
    // }
}