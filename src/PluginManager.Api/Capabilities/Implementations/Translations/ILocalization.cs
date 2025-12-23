using System.Collections.Generic;

namespace PluginManager.Api.Capabilities.Implementations.Translations;

public interface ILocalization: ICapability
{
    void RegisterDictionary(string pluginId, Dictionary<string, string> translations);
    void UnregisterDictionary(string pluginId);
    string Translate(string key, string platformId, params object[] args);
}