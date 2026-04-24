using System.Globalization;

namespace PluginManager.Api.Capabilities.Implementations.Translations;

public interface IPlayerLanguageStore : ICapability
{
    void SetLanguage(string platformId, CultureInfo cultureInfo);
    CultureInfo GetLanguage(string platformId);
    CultureInfo GetDefaultLanguage();
}