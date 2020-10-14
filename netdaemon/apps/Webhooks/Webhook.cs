using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Reactive.Linq;
using NetDaemon.Common.Reactive;
using NetDaemon.Common;

public class WebhookManager : NetDaemonRxApp
{
    [HomeAssistantServiceCall]
    public void OnWebHook(dynamic data)
    {
        Log("Service call hook data {data} and query {query}", data?.data, data?.query);
    }
}