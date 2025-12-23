namespace PluginManager.Api.Capabilities.Implementations.Logger;

public interface ILogger : ICapability
{
    void Out(string message);
    void Warning(string message);
    void Error(string message);
    void Exception(System.Exception e);
}