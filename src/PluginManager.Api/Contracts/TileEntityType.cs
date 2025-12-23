namespace PluginManager.Api.Contracts;

public enum TileEntityType
{
    None = 0,
    Collector = 3,
    LandClaim = 4,
    Loot = 5,
    Trader = 6,
    VendingMachine = 7,
    Forge = 8,
    Campfire = 9,
    SecureLoot = 10, // 0x0A
    SecureDoor = 11, // 0x0B
    Workstation = 12, // 0x0C
    Sign = 13, // 0x0D
    GoreBlock = 14, // 0x0E
    Powered = 15, // 0x0F
    PowerSource = 16, // 0x10
    PowerRangeTrap = 17, // 0x11
    Light = 18, // 0x12
    Trigger = 19, // 0x13
    Sleeper = 20, // 0x14
    PowerMeleeTrap = 21, // 0x15
    SecureLootSigned = 22, // 0x16
    Composite = 25, // 0x19
}