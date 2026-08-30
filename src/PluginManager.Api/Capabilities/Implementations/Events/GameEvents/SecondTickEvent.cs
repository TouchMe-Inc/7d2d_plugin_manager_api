using System;

namespace PluginManager.Api.Capabilities.Implementations.Events.GameEvents;

[Serializable]
public sealed class SecondTickEvent : IGameEvent
{
    public string EventName => nameof(SecondTickEvent);

    public DateTime Now { get; set; }

    public double DeltaSeconds { get; set; }

    public ulong WorldTime { get; set; }

    public int Day { get; set; }

    public int Hour { get; set; }

    public int Minute { get; set; }

    public int BloodMoonDay { get; set; }

    public bool BloodMoonActive { get; set; }

    public int PlayerCount { get; set; }
}
