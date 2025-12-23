namespace PluginManager.Api.Capabilities.Implementations.Translations;

public interface IPlayerLocalization
{
    string Translate(string platformId, string key, params object[] args);
    string Translate(string platformId, string key);
}