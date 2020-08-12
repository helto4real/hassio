using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetDaemon.Common;

// using Netdaemon.Generated.Extensions;

/// <summary>
///     Manage default lights and implements the following use-cases:
///         - Nightlights turn on in the night
///         - Activates the correct scene (RunScript) depending on time of day
/// </summary>
public class LightManager : NetDaemonApp
{
    public IEnumerable<string>? LivingRoomPirs { get; set; }
    public IEnumerable<string>? TvRoomPirs { get; set; }

    public string? KitchenPir { get; set; }
    public string? RemoteTvRummet { get; set; }
    public override Task InitializeAsync()
    {
        // Just testing the areas to make sure that changes are correctly managed
        // Scheduler.RunEvery(30000, () =>
        // {
        //     // List all entities in the area "Tv rummet"
        //     foreach (var entity in State.Where(n => n.Area == "Kök"))
        //     {
        //         Log("Entity {entity} is in kök", entity.EntityId);
        //     }
        //     return Task.CompletedTask;
        // });
        // Entities(n => n.Area == "kök" && n.EntityId.StartsWith("light.")).TurnOn().ExecuteAsync();

        InitializeNightLights();

        InitializeTimeOfDayScenes();

        // No async so just return completed task
        return Task.CompletedTask;
    }

    /// <summary>
    ///     Returns true if it is currently night
    /// </summary>
    public bool IsNight => GetState("input_select.house_mode_select")?.State == "Natt";

    /// <summary>
    ///     Returns true if TV is currently on
    /// </summary>
    public bool IsTvOn => GetState(RemoteTvRummet)?.State == "on";

    /// <summary>
    ///     Initialize the scenes to call depending on time of day
    /// </summary>
    private void InitializeTimeOfDayScenes()
    {

        Entity("input_select.house_mode_select")
            .WhenStateChange(to: "Dag")
                .RunScript("day_scene")
        .Execute();

        Entity("input_select.house_mode_select")
            .WhenStateChange(to: "Kväll")
                .RunScript("evening_scene")
        .Execute();

        Entity("input_select.house_mode_select")
            .WhenStateChange(to: "Natt")
                .RunScript("night_scene")
        .Execute();

        Entity("input_select.house_mode_select")
            .WhenStateChange(to: "Morgon")
                .RunScript("morning_scene")
        .Execute();

        Entity("input_select.house_mode_select")
            .WhenStateChange(to: "Städning")
                .RunScript("cleaning_scene")
        .Execute();
    }

    /// <summary>
    ///     Setup the night lights.
    /// </summary>
    private void InitializeNightLights()
    {
        // Living room night lights, turns on when motion
        Entities(LivingRoomPirs)
            .WhenStateChange(to: "on")
                .Call(async (entityId, to, from) =>
                {
                    if (IsNight)
                    {
                        // If morning time then turn on more lights
                        if (IsTimeNowBetween(TimeSpan.FromHours(5), TimeSpan.FromHours(10)))
                        {
                            await Entity("light.vardagsrum")
                                .TurnOn()
                                    .WithAttribute("transition", 0).ExecuteAsync();
                        }
                        else
                        {
                            await Entity("light.hall_byra")
                                .TurnOn()
                                    .WithAttribute("transition", 0).ExecuteAsync();
                        }
                    }
                }).Execute();

        // Turn off after som time idle exept if it is morning then keep on untill daytime will turn off
        Entities(LivingRoomPirs)
            .WhenStateChange((to, from) =>
                to?.State == "off" &&
                from?.State == "on" &&
                IsNight &&
                !IsTimeNowBetween(TimeSpan.FromHours(5), TimeSpan.FromHours(10)))
            .AndNotChangeFor(TimeSpan.FromMinutes(15))
                .UseEntity("light.vardagsrum").TurnOff().WithAttribute("transition", 0).Execute();

        // Kitchen night lights
        Entity(KitchenPir)
            .WhenStateChange((to, from) => to?.State == "on" && from?.State == "off" && IsNight)
                .UseEntity("light.kok").TurnOn().WithAttribute("transition", 0).Execute();

        Entity(KitchenPir)
            .WhenStateChange((to, from) =>
                    to?.State == "off" &&
                    from?.State == "on" &&
                    IsNight &&
                    !IsTimeNowBetween(TimeSpan.FromHours(5), TimeSpan.FromHours(10)))
            .AndNotChangeFor(TimeSpan.FromMinutes(15))
                .UseEntity("light.kok").TurnOff().WithAttribute("transition", 0).Execute();

        // TV Room night lights, only at night and not TV is on
        Entities(TvRoomPirs)
            .WhenStateChange((to, from) => to?.State == "on" && from?.State == "off" && IsNight && !IsTvOn)
                .UseEntity("light.tvrummet").TurnOn().WithAttribute("transition", 0).Execute();

        Entities(TvRoomPirs)
            .WhenStateChange((to, from) =>
                to?.State == "off" &&
                from?.State == "on"
                && IsNight &&
                !IsTvOn &&
                !IsTimeNowBetween(TimeSpan.FromHours(5), TimeSpan.FromHours(10)))
            .AndNotChangeFor(TimeSpan.FromMinutes(15))
                .UseEntity("light.tvrummet").TurnOff().WithAttribute("transition", 0).Execute();
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
