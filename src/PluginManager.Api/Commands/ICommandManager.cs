namespace PluginManager.Api.Commands;

public interface ICommandManager
{
    void RegisterCommand(ICommandDefinition definition);

    void DeregisterCommand(ICommandDefinition definition);
}