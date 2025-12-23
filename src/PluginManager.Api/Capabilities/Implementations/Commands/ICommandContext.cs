using System.Collections.Generic;
using PluginManager.Api.Contracts;

namespace PluginManager.Api.Capabilities.Implementations.Commands;

public interface ICommandContext
{
    IReadOnlyList<string> Args { get; }
    ClientInfo ClientInfo { get; }
}