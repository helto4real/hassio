using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Reactive.Linq;
using NetDaemon.Common.Reactive;

namespace hacs
{
    public class NotifyOnUpdate : NetDaemonRxApp
    {
        public override void Initialize() => Entity("sensor.hacs")
                .StateChanges
                .Where(e => e.New.State is Double) // Avoid error when "Unknown"
                .Subscribe(s =>
                {
                    var serviceDataTitle = "Updates pending in HACS";
                    var serviceDataMessage = "There are updates pending in [HACS](/hacs)\n\n";

                    List<object> repositories = s.New?.Attribute?.repositories || new List<object>();
                    foreach (IDictionary<string, object?> item in repositories)
                    {
                        if (item.TryGetValue("display_name", out var name))
                            serviceDataMessage += $"- {name?.ToString()}\n";
                    }

                    CallService("persistent_notification", "create", new
                    {
                        title = serviceDataTitle,
                        message = serviceDataMessage
                    });
                });
    }
}