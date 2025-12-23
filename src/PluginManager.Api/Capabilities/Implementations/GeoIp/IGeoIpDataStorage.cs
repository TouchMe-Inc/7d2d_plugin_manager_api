using PluginManager.Api.Contracts;

namespace PluginManager.Api.Capabilities.Implementations.GeoIp;

public interface IGeoIpDataStorage : ICapability
{
    public GeoIpData GetGeoIpData(string platformId);
    public void SetGetGeoIpData(string platformId, GeoIpData cultureInfo);
}