using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace RandomPush
{
    public class RandomPush : Hub
    {
        
        public void Push()
        {
            while (true)
            {
                Clients.All.Send("Random Push");

                var rand = new Random();
                Thread.Sleep(rand.Next(0, 1000));
            }
        }
    }
}