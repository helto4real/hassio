using System.Collections.Generic;
using System.Threading.Tasks;
using JoySoftware.HomeAssistant.NetDaemon.Common;

namespace hacs 
{
    public class NotifyOnUpdate : NetDaemonApp
    {
        public async override Task InitializeAsync() => Entity("sensor.hacs")
                .WhenStateChange((n, o) =>
                    o?.State != n?.State && n?.State > 0)
                        .Call(async (entityId, newState, oldState) =>
                        {
                            var serviceDataTitle = "Updates pending in HACS";
                            var serviceDataMessage = "There are updates pending in [HACS](/hacs)\n\n";


                            List<object> repositories = newState?.Attribute?.repositories || new List<object>();
                            foreach (IDictionary<string, object?> item in repositories)
                            {
                                serviceDataMessage += $"- {item?["display_name"].ToString()}\n";
                            }

                            await CallService("persistent_notification", "create", new
                            {
                                title = serviceDataTitle,
                                message = serviceDataMessage
                            }, true);
                        }).Execute();
    }
}