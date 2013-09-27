using System;
using Microsoft.AspNet.SignalR;

namespace simpleExample
{
    public class ChatHub : Hub
    {
        public void Send(String name, string message)
        {
            // call the broadcastMessage Method to Update Clients
            Clients.All.broadcastMessage(name, message);
        }
    }
}