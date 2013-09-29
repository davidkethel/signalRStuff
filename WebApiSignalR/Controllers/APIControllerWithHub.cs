using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace WebApiSignalR.Controllers
{
    public abstract class APIControllerWithHub<THub> : ApiController where THub : IHub
    {
        private Lazy<IHubContext> hub = new Lazy<IHubContext>(
            () => GlobalHost.ConnectionManager.GetHubContext<THub>()
            );

        protected IHubContext Hub
        {
            get { return hub.Value; }
        }
    }
}