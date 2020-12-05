using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reactive.Linq;
using NetDaemon.Common.Reactive;

/// <summary>
///     Greets (or insults) people when coming home :)
/// </summary>
public class WelcomeHomeManager : NetDaemonRxApp
{

    #region -- Config properties --

    /// <summary>
    ///     Used to search the correct device trackers by naming
    /// </summary>
    public string? PresenceCriteria { get; set; }

    public string? HallwayMediaPlayer { get; set; }

    public string? DoorSensor { get; set; }

    public IEnumerable<string>? Greetings { get; set; }

    #endregion

    Dictionary<string, DateTime> _lastTimeGreeted = new Dictionary<string, DateTime>(5);
    Random _randomizer = new Random();

    public override Task InitializeAsync()
    {
        if (!CheckConfig())
            return Task.CompletedTask;

        Entity(DoorSensor!)
            .StateChanges
            .Where(e => e.New?.State == "on")
            .Subscribe(s => GreetIfJustArrived(s.New.EntityId));

        StateChanges
            .Where(
                e => e.New.EntityId.EndsWith(PresenceCriteria!) &&
                     e.New?.State == "Nyss anlänt")
            .Subscribe(s => GreetIfJustArrived(s.New.EntityId));

        return Task.CompletedTask;
    }

    private void GreetIfJustArrived(string entityId)
    {
        if (entityId.StartsWith("binary_sensor."))
        {
            // The door opened, lets check if someone just arrived
            var trackerJustArrived = States.Where(n => n.EntityId.EndsWith(PresenceCriteria!) && n.State == "Nyss anlänt");
            foreach (var tracker in trackerJustArrived)
            {
                Greet(tracker.EntityId);
            }
        }
        else if (entityId.StartsWith("device_tracker."))
        {
            var dorrSensorState = State(DoorSensor!);
            if (dorrSensorState?.State == "on")
            {
                // Door is open, greet
                Greet(entityId);
            }
            else if (dorrSensorState?.State == "off")
            {
                // It is closed, lets check if it was recently opened
                if (DateTime.Now.Subtract(dorrSensorState.LastChanged) <= TimeSpan.FromMinutes(5))
                {
                    // It was recently opened, probably when someone got home
                    Greet(entityId);
                }
            }
        }
    }

    private void Greet(string tracker)
    {
        // Get the name from tracker i.e. device_tracer.name_presense
        var nameOfPersion = tracker[15..^PresenceCriteria!.Length];

        if (!OkToGreet(nameOfPersion))
            return;                     // We can not greet person just yet

        Speak(HallwayMediaPlayer!, GetGreeting(nameOfPersion));
    }

    private bool OkToGreet(string nameOfPersion)
    {
        if (_lastTimeGreeted.ContainsKey(nameOfPersion) == false)
        {
            _lastTimeGreeted[nameOfPersion] = DateTime.Now;
            return true;
        }

        if (DateTime.Now.Subtract(_lastTimeGreeted[nameOfPersion]) < TimeSpan.FromMinutes(15))
            return false; // To early to greet again

        _lastTimeGreeted[nameOfPersion] = DateTime.Now;
        return true; // It is ok to greet now
    }

    private string GetGreeting(string name)
    {
        var randomMessageIndex = _randomizer.Next(0, Greetings.Count() - 1);
        return Greetings!.ElementAt(randomMessageIndex).Replace("{namn}", name);
    }

    private bool CheckConfig()
    {
        if (PresenceCriteria == null ||
            HallwayMediaPlayer == null)
            return false;

        return true;
    }
}