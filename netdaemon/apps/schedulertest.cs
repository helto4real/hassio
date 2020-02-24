using System;
using System.Threading.Tasks;
using JoySoftware.HomeAssistant.NetDaemon.Common;

/// <summary>
///     App docs
/// </summary>
public class SchedulerTests : NetDaemonApp
{
    public override Task InitializeAsync()
    {
        Schedule("15:15:01");
        Schedule("15:15:02");
        Schedule("15:15:03");
        Schedule("15:15:04");
        Schedule("15:15:05");
        Schedule("15:15:06");
        Schedule("15:15:07");
        Schedule("16:45:57");
        Schedule("17:05:47");
        Schedule("17:19:37");
        Schedule("18:13:27");
        Schedule("19:11:17");
        Schedule("20:13:05");
        return Task.CompletedTask;
    }

    private void Schedule(string time)
    {
        Scheduler.RunDaily(time, async () => Log($"SCHEDULER TEST org time: {time} current_time: {DateTime.Now}"));
    }
}