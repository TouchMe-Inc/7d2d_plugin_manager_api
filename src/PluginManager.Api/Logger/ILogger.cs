namespace PluginManager.Api.Logger;

public interface ILogger
{
    void Out(string message);
    void Warning(string message);
    void Error(string message);
    void Exception(System.Exception e);
}