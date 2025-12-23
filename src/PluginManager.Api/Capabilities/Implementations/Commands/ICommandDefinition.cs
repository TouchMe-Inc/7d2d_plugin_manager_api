using PluginManager.Api.Proxy;

namespace PluginManager.Api.Capabilities.Implementations.Commands;

public interface ICommandDefinition
{
    string Name { get; }
    string Description { get; }
    DelegateProxy Callback { get; }
    public string UsageHint { get; set; }
}