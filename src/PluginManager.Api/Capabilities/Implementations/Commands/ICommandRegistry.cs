using System.Collections.Generic;

namespace PluginManager.Api.Capabilities.Implementations.Commands;

public interface ICommandRegistry
{
    bool TryGetCommand(string name, out ICommandDefinition command);
    IEnumerable<ICommandDefinition> GetAllCommands();
}