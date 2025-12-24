using PluginManager.Api.Capabilities;

namespace PluginManager.Api;

public interface IPlugin
{
    /// <summary>
    /// Name of the plugin as it will appear in the plugin list.
    /// </summary>
    string ModuleName { get; }

    /// <summary>
    /// Module version as it will appear in the plugin list.
    /// </summary>
    string ModuleVersion { get; }

    /// <summary>
    /// Author of the plugin as it will appear in the plugin list.
    /// </summary>
    string ModuleAuthor { get; }

    /// <summary>
    /// Brief description of the plugin as it will appear in the plugin list.
    /// </summary>
    string ModuleDescription { get; }

    /// <summary>
    /// This method is called on plugin load and should be treated as plugin constructor.
    /// </summary>
    void Load(ICapabilityRegistry registry);

    /// <summary>
    /// Will be called on plugin unload. In this method the plugin should cleanup any extra resources.
    /// </summary>
    void Unload(ICapabilityRegistry registry);
}