namespace PluginManager.Api.Capabilities.Implementations.Commands;

public interface ICommandManager : ICapability
{
    void RegisterCommand(ICommandDefinition definition);

    void DeregisterCommand(ICommandDefinition definition);
}