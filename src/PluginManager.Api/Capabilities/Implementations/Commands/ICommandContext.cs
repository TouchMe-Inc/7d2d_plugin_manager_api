using System.Collections.Generic;

namespace PluginManager.Api.Capabilities.Implementations.Commands;

public interface ICommandContext
{
    IReadOnlyList<string> Args { get; }
    int EntityId { get; }
}