namespace NetDaemon.Extensions.Scheduler;
public static class NetDaemonScehdulerExtensions
{
    public static IDisposable RunDaily(this INetDaemonScheduler scheduler, TimeSpan timeOfDay, Action action)
    {
        var startTime = scheduler.Now.Date.Add(timeOfDay);
        if (scheduler.Now > startTime)
        {
            startTime = startTime.AddDays(1);
        }
        return scheduler.RunEvery(TimeSpan.FromDays(1), startTime, action);
    }
}