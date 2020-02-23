using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using JoySoftware.HomeAssistant.NetDaemon.Common;

/// <summary>
///     Application manage the carheater. Implements following use-cases:
///         - Automatically turns off carheater if on for 3 hours as protection for the car
///         - Reads departure time and turn on heater a specific time
///           before depending on temperature
///         - Can be turned on/off depending if it is a weekday or weekend
/// </summary>
/// <remarks>
///     The application is running every minute and decides if the heater is
///     going to be on or off. This logic will work also after restart.
/// </remarks>
public class CarHeaterManager : NetDaemonApp
{
    // The entities used in the automation
    // private readonly string _heaterSwitch = "switch.motorvarmare";
    #region -- config properties --
    /// <summary>
    ///     Sensor used for temperature outside, from config
    /// </summary>
    public string? TempSensor { get; set; }

    /// <summary>
    ///     Sensor that has departure time HH:mm, from config
    /// </summary>
    public string? DepartureTimeSensor { get; set; }

    /// <summary>
    ///     Is true if departure time is valid on weekend, from config
    /// </summary>
    public string? ScheduleOneWeekendsInputBoolean { get; set; }

    /// <summary>
    ///     Switch used for turning on heater
    /// </summary>
    public string? HeaterSwitch { get; set; }

    #endregion

    // True if the heater is started or stopped outside this script
    private bool _manualOverride = false;
    // True if the script just turn on the heater,
    // used to prohibit logic being run on state change
    private bool _appChangedState = false;
    // Used for logging at startup and no more
    private bool _appJustStarted = true;

    /// <summary>
    ///     Initialize the automations
    /// </summary>
    /// <remarks>
    ///     - Schedules check every minute if heater should be on or off depending on temperature
    ///     - Set the manually started flag if heater is turn on and not turned on by this script
    /// </remarks>
    public override Task InitializeAsync()
    {
        // Get the state if manually started from statestorage
        _manualOverride = Storage.IsManualState ?? false;

        Scheduler.RunEveryMinute(0, () => HandleCarHeater());

        Entity(HeaterSwitch!).WhenStateChange(to: "on").Call((e, to, from) =>
        {
            if (_appChangedState == false)
            {
                // It is manually turned on
                _manualOverride = true;
                Storage.IsManualState = true;
            }
            _appChangedState = false;
            return Task.CompletedTask;
        }).Execute();

        // No async so return completed task
        return Task.CompletedTask;
    }



    /// <summary>
    ///     Handle the logic run every minute if heater
    ///     should be on or off
    /// </summary>
    private async Task HandleCarHeater()
    {
        try
        {
            // First do the failsave logic, no heater should run for more than 3 hours
            await TurnOffHeaterIfOnMoreThanThreeHours();

            // Get relevant states
            var currentOutsideTemp = (double?)GetState(TempSensor!)?.State;
            var configuredDepartureTime = GetState(DepartureTimeSensor!)?.State;
            var scheduleOnWeekend = GetState(ScheduleOneWeekendsInputBoolean!)?.State == "on" ? true : false;

            // Calculate correct set departure time
            var now = DateTime.Now;
            var hours = int.Parse(configuredDepartureTime!.Split(':')[0]);       // configured departure is in format hh:mm
            var minutes = int.Parse(configuredDepartureTime.Split(':')[1]);
            var nextDeparture = new DateTime(now.Year, now.Month, now.Day, hours, minutes, 0);

            // Add the next day if we passed todays time
            if (nextDeparture < now)
                nextDeparture = nextDeparture.AddDays(1);

            if (_appJustStarted)
            {
                // Just log some useful information if we at startup
                Log($"The time is {DateTime.Now}, if the time does not match local time, see time zone settings");
                Log($"Next departure is {nextDeparture}");
                _appJustStarted = false;
            }


            // If weekend and not set to schedule on weekends then just return
            if ((nextDeparture.DayOfWeek == DayOfWeek.Saturday || nextDeparture.DayOfWeek == DayOfWeek.Sunday) && !scheduleOnWeekend)
            {
                return;
            }

            // Calculate total minutes to departure
            var totalMinutesUntilDeparture = nextDeparture.Subtract(now).TotalMinutes;

            if (currentOutsideTemp >= -1.0 && currentOutsideTemp <= 5.0)
            {
                // Within 30 minutes
                if (totalMinutesUntilDeparture <= 30)
                {
                    await TurnOnHeater();
                    return;
                }

            }
            else if (currentOutsideTemp >= -5.0 && currentOutsideTemp < -1.0)
            {
                // Within one hour
                if (totalMinutesUntilDeparture <= 60)
                {
                    await TurnOnHeater();
                    return;
                }
            }
            else if (currentOutsideTemp >= -10.0 && currentOutsideTemp < -5.0)
            {
                // Within 1.5 hour
                if (totalMinutesUntilDeparture <= 90)
                {
                    await TurnOnHeater();
                    return;
                }
            }
            else if (currentOutsideTemp >= -20.0 && currentOutsideTemp < -10.0)
            {
                // Within two hours
                if (totalMinutesUntilDeparture <= 120)
                {
                    await TurnOnHeater();
                    return;
                }
            }
            else if (currentOutsideTemp < -20.0)
            {
                // Within three hours
                if (totalMinutesUntilDeparture <= 180)
                {
                    await TurnOnHeater();
                    return;
                }
            }

            // If not manually started and heater is on, turn heater off
            if (GetState(HeaterSwitch!)?.State == "on" && !_manualOverride)
            {
                Log("Turning off heater");
                _appChangedState = true;
                await Entity(HeaterSwitch!).TurnOff().ExecuteAsync();
                Log($"Next departure is {nextDeparture}");
            }

        }
        catch (System.Exception e)
        {
            // Log all errors!
            Log("Error in car heater app", e, LogLevel.Error);
        }

    }

    /// <summary>
    ///     Turn the heater on if it is not already on
    /// </summary>
    private async Task TurnOnHeater()
    {
        try
        {
            // Temp is debuginformation to make sure the logic works, will be removed
            var currentOutsideTemp = (double?)GetState(TempSensor!)?.State;

            if (GetState(HeaterSwitch!)?.State != "on")
            {
                // Flag that this script actually turn the heater on and non manually
                _manualOverride = false;
                _appChangedState = true;

                Log($"{DateTime.Now} : Turn on heater temp ({currentOutsideTemp})");
                await Entity(HeaterSwitch!)
                    .TurnOn()
                        .ExecuteAsync();
            }
        }
        catch (System.Exception e)
        {
            Log("Error turn on heater", e, LogLevel.Error);
        }
    }

    /// <summary>
    ///     Turns the heater off if it has been on for more than three hours
    /// </summary>
    /// <remarks>
    ///     For any reason the switch has been on for more than three hours
    ///     the heater will be turned off. This will save energy and prohibit
    ///     the heater being on accidentally
    /// </remarks>
    /// <returns></returns>
    private async Task TurnOffHeaterIfOnMoreThanThreeHours()
    {
        try
        {
            // Turn off heater if it has been on for more than 3 hours
            await Entities(n =>
                n.EntityId == HeaterSwitch
                && n.State == "on"
                && DateTime.Now.Subtract(n.LastChanged) > TimeSpan.FromHours(3))
                .TurnOff().ExecuteAsync();
        }
        catch (System.Exception e)
        {
            Log("Error doing failsafe", e, LogLevel.Error);
        }

    }

    /// <summary>
    ///     Check if configuration is correct and hass values, throws if not
    /// </summary>
    private void CheckConfig()
    {
        if (TempSensor == null)
            throw new NullReferenceException("Tempsensor not configured in yaml!");
        if (DepartureTimeSensor == null)
            throw new NullReferenceException("DepartureTimeSensor not configured in yaml!");
        if (ScheduleOneWeekendsInputBoolean == null)
            throw new NullReferenceException("ScheduleOneWeekendsInputBoolean not configured in yaml!");
        if (HeaterSwitch == null)
            throw new NullReferenceException("ScheduleOneWeekendsInputBoolean not configured in yaml!");
    }
}