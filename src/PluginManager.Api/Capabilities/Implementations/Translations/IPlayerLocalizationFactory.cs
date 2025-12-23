namespace PluginManager.Api.Capabilities.Implementations.Translations;

public interface IPlayerLocalizationFactory : ICapability
{
    IPlayerLocalization Create(string langPath);
}