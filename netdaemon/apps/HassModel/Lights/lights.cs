// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using System.Threading;
// using System.Reactive.Linq;
// using NetDaemon.Common.Reactive;
// using NetDaemon.Generated.Reactive;

using System.Threading;

/// <summary>
///     Manage default lights and implements the following use-cases:
///         - Nightlights turn on in the night
///         - Activates the correct scene (RunScript) depending on time of day
/// </summary>
[NetDaemonApp]
public class LightManager : IInitializable
{
    public IEnumerable<BinarySensorEntity>? LivingRoomPirs { get; set; }
    public IEnumerable<BinarySensorEntity>? TvRoomPirs { get; set; }
    public BinarySensorEntity? KitchenPir { get; set; }
    public BinarySensorEntity? TomasRoomPir { get; set; }
    public RemoteEntity? RemoteTvRummet { get; set; }
    public LightEntity? ElgatoKeyLight { get; set; }
    public InputSelectEntity? HouseModeSelect { get; set; }

    private readonly Entities _entities;

    private readonly Services _services;
    public LightManager(IHaContext ha)
    {
        _entities = new Entities(ha);
        _services = new Services(ha);
    }

    public void Initialize()
    {
        InitializeNightLights();

        InitializeTimeOfDayScenes();

        // handle keylights
        TomasRoomPir?
            .StateChanges()
            .Where(e =>
                e.New.IsOff() &&
                e.Old.IsOn() &&
                ElgatoKeyLight.IsOn()
            )
            .Throttle(TimeSpan.FromMinutes(30))
            .Subscribe(s => ElgatoKeyLight?.TurnOff(transition: 0));

        TomasRoomPir?
            .StateChanges()
            .Where(e =>
                e.New.IsOn() &&
                e.Old.IsOff() &&
                ElgatoKeyLight.IsOff()
            )
            .Subscribe(s => ElgatoKeyLight?.TurnOn(transition: 0));
    }

    /// <summary>
    ///     Returns true if it is currently night
    /// </summary>
    public bool IsNight => HouseModeSelect?.State == "Natt";

    /// <summary>
    ///     Returns true if TV is currently on
    /// </summary>
    public bool IsTvOn => RemoteTvRummet.IsOn();

    /// <summary>
    ///     Initialize the scenes to call depending on time of day
    /// </summary>
    private void InitializeTimeOfDayScenes()
    {
        HouseModeSelect?
            .StateChanges()
            .Where(e => e.New?.State == "Dag")
            .Subscribe(s => TurnOffAmbient());

        HouseModeSelect?
            .StateChanges()
            .Where(e => e.New?.State == "Kväll")
            .Subscribe(s => TurnOnAmbient());

        HouseModeSelect?
            .StateChanges()
            .Where(e => e.New?.State == "Natt")
            .Subscribe(s => TurnOffAmbient());

        HouseModeSelect?
            .StateChanges()
            .Where(e => e.New?.State == "Morgon")
            .Subscribe(s => TurnOffAmbient());

        HouseModeSelect?
            .StateChanges()
            .Where(e => e.New?.State == "Städning")
            .Subscribe(s => _services.Script.CleaningScene());
    }


    private void TurnOffAmbient()
    {
        _entities.Light.Vardagsrum.TurnOff(transition: 0);
        Thread.Sleep(200);
        _entities.Light.Kok.TurnOff(transition: 0);
        Thread.Sleep(200);
        _entities.Light.TomasRum.TurnOff(transition: 0);
        Thread.Sleep(200);
        _entities.Light.MelkersRum.TurnOff(transition: 0);
        Thread.Sleep(200);
        _entities.Light.SallysRum.TurnOff(transition: 0);
        Thread.Sleep(200);
        _entities.Light.Tvrummet.TurnOff(transition: 0);
        Thread.Sleep(200);
        _entities.Light.FarstukvistLed.TurnOff(transition: 0);
        Thread.Sleep(200);
        _entities.Light.Sovrum.TurnOff(transition: 0);
    }

    private void TurnOnAmbient()
    {
        _entities.Light.Vardagsrum.TurnOn(transition: 0, brightness: 150);
        Thread.Sleep(200);
        _entities.Light.Kok.TurnOn(transition: 0, brightness: 150);
        Thread.Sleep(200);
        _entities.Light.TomasRum.TurnOn(transition: 0, brightness: 150);
        Thread.Sleep(200);
        _entities.Light.MelkersRum.TurnOn(transition: 0, brightness: 150);
        Thread.Sleep(200);
        _entities.Light.SallysRum.TurnOn(transition: 0, brightness: 150);
        Thread.Sleep(200);
        _entities.Light.Tvrummet.TurnOn(transition: 0, brightness: 130);
        Thread.Sleep(200);
        _entities.Light.FarstukvistLed.TurnOn(transition: 0, brightness: 150);
        Thread.Sleep(200);
        _entities.Light.Sovrum.TurnOn(transition: 0, brightness: 20);
        Thread.Sleep(200);
    }

    /// <summary>
    ///     Setup the night lights.
    /// </summary>
    private void InitializeNightLights()
    {
        // Living room night lights, turns on when motion
        LivingRoomPirs?
            .StateChanges()
            .Where(e => e.New.IsOn())
            .Where(e => IsNight)
            .Subscribe(s =>
                {
                    // If morning time then turn on more lights
                    if (IsTimeNowBetween(TimeSpan.FromHours(5), TimeSpan.FromHours(10)))
                    {
                        _entities.Light.Vardagsrum.TurnOn(transition: 0);
                    }
                    else
                    {
                        _entities.Light.HallByra.TurnOn(transition: 0);
                    }
                });

        // Turn off after som time idle except if it is morning then keep on until daytime will turn off
        LivingRoomPirs?
            .StateChanges()
            .Where(e =>
                e.New.IsOff() &&
                e.Old.IsOn() &&
                IsNight &&
                !IsTimeNowBetween(TimeSpan.FromHours(5), TimeSpan.FromHours(10)))
            .Throttle(TimeSpan.FromMinutes(15))
            .Subscribe(s => _entities.Light.HallByra.TurnOff(transition: 0));

        // Kitchen night lights
        KitchenPir?
            .StateChanges()
            .Where(e =>
                e.New.IsOn() &&
                e.Old.IsOff() &&
                IsNight)
            .Subscribe(s => _entities.Light.Kok.TurnOn(transition: 0));

        KitchenPir?
            .StateChanges()
            .Where(e =>
                e.New.IsOff() &&
                e.Old.IsOn() &&
                IsNight &&
                !IsTimeNowBetween(TimeSpan.FromHours(5), TimeSpan.FromHours(10)))
            .Throttle(TimeSpan.FromMinutes(15))
            .Subscribe(s => _entities.Light.Kok.TurnOff(transition: 0));

        // TV Room night lights, only at night and not TV is on
        TvRoomPirs?
            .StateChanges()
            .Where(e =>
                e.New.IsOn() &&
                e.Old.IsOff() &&
                IsNight &&
                !IsTvOn
            )
            .Subscribe(s => _entities.Light.Tvrummet.TurnOn(transition: 0));

        TvRoomPirs?
            .StateChanges()
            .Where(e =>
                e.New.IsOff() &&
                e.Old.IsOn() &&
                IsNight &&
                !IsTvOn &&
                !IsTimeNowBetween(TimeSpan.FromHours(5), TimeSpan.FromHours(10)))
            .Throttle(TimeSpan.FromMinutes(15))
            .Subscribe(s => _entities.Light.Tvrummet.TurnOff(transition: 0)); //Entity("light.tvrummet")
    }

    // Todo, make this part of Fluent API
    private static bool IsTimeNowBetween(TimeSpan fromSpan, TimeSpan toSpan)
    {
        var now = DateTime.Now.TimeOfDay;
        if (now >= fromSpan && now <= toSpan)
            return true;

        return false;
    }
}
