using PluginManager.Api.Proxy;

namespace PluginManager.Api.Contracts;

public class GeoIpData(string city, string country, string isoCode) : ProxyObject
{
    public string City { get; } = city;
    public string Country { get; } = country;
    public string IsoCode { get; } = isoCode;
}