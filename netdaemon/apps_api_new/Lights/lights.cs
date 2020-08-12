using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reactive.Linq;
using NetDaemon.Common.Reactive;

// using Netdaemon.Generated.Extensions;

/// <summary>
///     Manage default lights and implements the following use-cases:
///         - Nightlights turn on in the night
///         - Activates the correct scene (RunScript) depending on time of day
/// </summary>
public class LightManager : NetDaemonRxApp
{
    public IEnumerable<string>? LivingRoomPirs { get; set; }
    public IEnumerable<string>? TvRoomPirs { get; set; }

    public string? KitchenPir { get; set; }
    public string? RemoteTvRummet { get; set; }
    public override void Initialize()
    {
        InitializeNightLights();

        InitializeTimeOfDayScenes();
    }

    /// <summary>
    ///     Returns true if it is currently night
    /// </summary>
    public bool IsNight => State("input_select.house_mode_select")?.State == "Natt";

    /// <summary>
    ///     Returns true if TV is currently on
    /// </summary>
    public bool IsTvOn => State(RemoteTvRummet!)?.State == "on";

    /// <summary>
    ///     Initialize the scenes to call depending on time of day
    /// </summary>
    private void InitializeTimeOfDayScenes()
    {
        Entity("input_select.house_mode_select")
            .StateChanges
            .Where(e => e.New.State == "Dag")
            .Subscribe(s => RunScript("day_scene"));

        Entity("input_select.house_mode_select")
            .StateChanges
            .Where(e => e.New.State == "Kväll")
            .Subscribe(s => RunScript("evening_scene"));

        Entity("input_select.house_mode_select")
            .StateChanges
            .Where(e => e.New.State == "Natt")
            .Subscribe(s => RunScript("night_scene"));

        Entity("input_select.house_mode_select")
            .StateChanges
            .Where(e => e.New.State == "Morgon")
            .Subscribe(s => RunScript("morning_scene"));

        Entity("input_select.house_mode_select")
            .StateChanges
            .Where(e => e.New.State == "Städning")
            .Subscribe(s => RunScript("cleaning_scene"));
    }

    /// <summary>
    ///     Setup the night lights.
    /// </summary>
    private void InitializeNightLights()
    {
        // Living room night lights, turns on when motion
        Entities(LivingRoomPirs!)
            .StateChanges
            .Where(e => e.New?.State == "on")
            .Where(e => IsNight)
            .Subscribe(s =>
                {
                    // If morning time then turn on more lights
                    if (IsTimeNowBetween(TimeSpan.FromHours(5), TimeSpan.FromHours(10)))
                    {
                        Entity("light.vardagsrum").TurnOn(new { transition = 0 });
                    }
                    else
                    {
                        Entity("light.hall_byra").TurnOn(new { transition = 0 });
                    }
                });

        // Turn off after som time idle except if it is morning then keep on until daytime will turn off
        Entities(LivingRoomPirs!)
            .StateChanges
            .Where(e =>
                e.New?.State == "off" &&
                e.Old?.State == "on" &&
                IsNight &&
                !IsTimeNowBetween(TimeSpan.FromHours(5), TimeSpan.FromHours(10)))
            .NDSameStateFor(TimeSpan.FromMinutes(15))
            .Subscribe(s => Entity("light.vardagsrum").TurnOff(new { transition = 0 }));

        // Kitchen night lights
        Entity(KitchenPir!)
            .StateChanges
            .Where(e =>
                e.New?.State == "on" &&
                e.Old?.State == "off" &&
                IsNight)
            .Subscribe(s => Entity("light.kok").TurnOn(new { transition = 0 }));

        Entity(KitchenPir!)
            .StateChanges
            .Where(e =>
                e.New?.State == "off" &&
                e.Old?.State == "on" &&
                IsNight &&
                !IsTimeNowBetween(TimeSpan.FromHours(5), TimeSpan.FromHours(10)))
            .NDSameStateFor(TimeSpan.FromMinutes(15))
            .Subscribe(s => Entity("light.kok").TurnOff(new { transition = 0 }));

        // TV Room night lights, only at night and not TV is on
        Entities(TvRoomPirs!)
            .StateChanges
            .Where(e =>
                e.New?.State == "on" &&
                e.Old?.State == "off" &&
                IsNight &&
                !IsTvOn
            )
            .Subscribe(s => Entity("light.tvrummet").TurnOn(new { transition = 0 }));

        Entities(TvRoomPirs!)
            .StateChanges
            .Where(e =>
                e.New?.State == "off" &&
                e.Old?.State == "on"
                && IsNight &&
                !IsTvOn &&
                !IsTimeNowBetween(TimeSpan.FromHours(5), TimeSpan.FromHours(10)))
            .NDSameStateFor(TimeSpan.FromMinutes(15))
            .Subscribe(s => Entity("light.tvrummet").TurnOff(new { transition = 0 }));
    }

    // Todo, make this part of Fluent API
    private bool IsTimeNowBetween(TimeSpan fromSpan, TimeSpan toSpan)
    {
        var now = DateTime.Now.TimeOfDay;
        if (now >= fromSpan && now <= toSpan)
            return true;

        return false;
    }
}
