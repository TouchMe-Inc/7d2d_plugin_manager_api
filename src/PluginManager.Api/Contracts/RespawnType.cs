namespace PluginManager.Api.Contracts;

public enum RespawnType : byte
{
    NewGame,
    LoadedGame,
    Died,
    Teleport,
    EnterMultiplayer,
    JoinMultiplayer,
    Unknown,
}