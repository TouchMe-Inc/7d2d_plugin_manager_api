using PluginManager.Api.Proxy;

namespace PluginManager.Api.Commands;

public class CommandDefinition : ICommandDefinition
{
    public string Name { get; set; }
    public string Description { get; set; }
    public DelegateProxy Callback { get; set; }
    public string? UsageHint { get; set; }
    public int? MinArgs { get; set; }

    public CommandDefinition(string name, string description, DelegateProxy callback)
    {
        Name = name;
        Description = description;
        Callback = callback;
    }

    public CommandDefinition()
    {
    }

    public override string ToString()
    {
        return $"Name: {Name}, Description: {Description}, UsageHint: {UsageHint}, MinArgs: {MinArgs}";
    }
}