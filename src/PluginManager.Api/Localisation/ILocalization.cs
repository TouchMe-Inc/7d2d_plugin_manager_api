using System.Collections.Generic;

namespace PluginManager.Api.Localisation;

public interface ILocalization
{
    void RegisterDictionary(string pluginId, Dictionary<string, string> translations);
    void UnregisterDictionary(string pluginId);
    string Translate(string key);
}