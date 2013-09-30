using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using  WebApiSignalR;

namespace WebApiSignalR.Controllers
{
    public class RandomController : APIControllerWithHub<RandomHub>
    {
        // POST api/Random
        public void Post()
        {
            var i = 0;

           Hub.Clients.All.push("Hello Push");


        }

        // POST api/Delete
        public void Delete()
        {
            var i = 0;
        }
    }
}
