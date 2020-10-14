using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using NetDaemon.Common.Reactive;
using System.Reactive.Linq;

/// <summary>
///     Application manage the carheater. Implements following use-cases:
///         - Automatically turns off carheater if on for 3 hours as protection for the car
///         - Reads departure time and turn on heater a specific time
///           before depending on temperature
///         - Can be turned on/off depending if it is a weekday or weekend
///
///     The application is running every minute and decides if the heater is
///     going to be on or off. This logic will work also after restart.
/// </summary>
public class CarHeaterManager : NetDaemonRxApp
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
    public override void Initialize()
    {
        // Get the state if manually started from statestorage
        RunEveryMinute(0, () => HandleCarHeater());

        Entity(HeaterSwitch!)
            .StateChanges
            .Where(e => e.New.State == "on")
            .Subscribe(s =>
        {
            if (_appChangedState == false)
            {
                // It is manually turned on
                Storage.IsManualState = true;
            }
            else
            {
                Storage.IsManualState = false;
            }
            _appChangedState = false;

        });
    }

    /// <summary>
    ///     Handle the logic run every minute if heater
    ///     should be on or off
    /// </summary>
    private void HandleCarHeater()
    {
        try
        {
            // First do the failsave logic, no heater should run for more than 3 hours
            TurnOffHeaterIfOnMoreThanThreeHours();

            // Get relevant states
            var currentOutsideTemp = (double?)State(TempSensor!)?.State;
            var configuredDepartureTime = State(DepartureTimeSensor!)?.State;
            var scheduleOnWeekend = State(ScheduleOneWeekendsInputBoolean!)?.State == "on" ? true : false;

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
                    TurnOnHeater();
                    return;
                }

            }
            else if (currentOutsideTemp >= -5.0 && currentOutsideTemp < -1.0)
            {
                // Within one hour
                if (totalMinutesUntilDeparture <= 60)
                {
                    TurnOnHeater();
                    return;
                }
            }
            else if (currentOutsideTemp >= -10.0 && currentOutsideTemp < -5.0)
            {
                // Within 1.5 hour
                if (totalMinutesUntilDeparture <= 90)
                {
                    TurnOnHeater();
                    return;
                }
            }
            else if (currentOutsideTemp >= -20.0 && currentOutsideTemp < -10.0)
            {
                // Within two hours
                if (totalMinutesUntilDeparture <= 120)
                {
                    TurnOnHeater();
                    return;
                }
            }
            else if (currentOutsideTemp < -20.0)
            {
                // Within three hours
                if (totalMinutesUntilDeparture <= 180)
                {
                    TurnOnHeater();
                    return;
                }
            }

            // If not manually started and heater is on, turn heater off
            if (State(HeaterSwitch!)?.State == "on" && !Storage.IsManualState ?? false)
            {
                Log("Turning off heater");
                _appChangedState = true;
                Entity(HeaterSwitch!).TurnOff();
                Log("Next departure is {nextDeparture}", nextDeparture);
            }

        }
        catch (System.Exception e)
        {
            // Log all errors!
            Log(e, "Error in car heater app", LogLevel.Error);
        }

    }

    /// <summary>
    ///     Turn the heater on if it is not already on
    /// </summary>
    private void TurnOnHeater()
    {
        try
        {
            // Temp is debuginformation to make sure the logic works, will be removed
            var currentOutsideTemp = (double?)State(TempSensor!)?.State;

            if (State(HeaterSwitch!)?.State != "on")
            {
                // Flag that this script actually turn the heater on and non manually
                _appChangedState = true;

                Log("{time} : Turn on heater temp ({temp})", DateTime.Now, currentOutsideTemp.ToString() ?? "unavailable");
                Entity(HeaterSwitch!).TurnOn();
            }
        }
        catch (System.Exception e)
        {
            Log(e, "Error turn on heater", LogLevel.Error);
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
    private void TurnOffHeaterIfOnMoreThanThreeHours()
    {
        try
        {
            // Turn off heater if it has been on for more than 3 hours
            Entities(n =>
                n.EntityId == HeaterSwitch
                && n.State == "on"
                && DateTime.Now.Subtract(n.LastChanged) > TimeSpan.FromHours(3))
                .TurnOff();
        }
        catch (Exception e)
        {
            Log(e, "Error doing failsafe", LogLevel.Error);
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