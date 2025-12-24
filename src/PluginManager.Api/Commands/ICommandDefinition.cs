using PluginManager.Api.Proxy;

namespace PluginManager.Api.Commands;

public interface ICommandDefinition
{
    string Name { get; }
    string Description { get; }
    DelegateProxy Callback { get; }
}