using PluginManager.Api.Proxy;

namespace PluginManager.Api.Capabilities.Implementations.Commands;

public class CommandDefinition : ProxyObject, ICommandDefinition
{
    public string Name { get; set; }
    public string Description { get; set; }
    public DelegateProxy Callback { get; set; }
    public string UsageHint { get; set; }

    public CommandDefinition(string name, string description, DelegateProxy callback)
    {
        Name = name;
        Description = description;
        Callback = callback;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Description: {Description}, UsageHint: {UsageHint}";
    }
}