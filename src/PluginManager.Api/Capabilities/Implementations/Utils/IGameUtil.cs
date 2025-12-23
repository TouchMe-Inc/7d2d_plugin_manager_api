using PluginManager.Api.Contracts;

namespace PluginManager.Api.Capabilities.Implementations.Utils;

public interface IGameUtil : ICapability
{
    PlayerKillingMode GetPlayerKillingMode();
    string GetEntityType(int entityId);
    ulong GetWorldTime();
    int WorldTimeToDays(ulong worldTime);
    int WorldTimeToHours(ulong worldTime);
    int WorldTimeToMinutes(ulong worldTime);
}