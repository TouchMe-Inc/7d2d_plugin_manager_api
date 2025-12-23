using PluginManager.Api.Proxy;

namespace PluginManager.Api.Capabilities.Implementations.Events.GameEvents;

public sealed class EntityDamageEvent(int victimEntityId, int attackerEntityId, int strength): ProxyObject, IGameEvent
{
    public string EventName => nameof(EntityDamageEvent);

    public int VictimEntityId = victimEntityId;
    public int AttackerEntityId = attackerEntityId;
    public int Strength = strength;
}