using System;
using System.Threading;

namespace WebApiSignalR.Controllers
{
    public class RandomController : APIControllerWithHub<RandomHub>
    {
        private static bool _randomStarted;
        private static bool _randomOn;

        // POST api/Random
        public void Post()
        {
            if (!_randomStarted)
            {
                _randomOn = true;
                StartRandom();
            }
        }

        // POST api/Delete
        public void Delete()
        {
            _randomOn = false;
        }

        private void StartRandom()
        {
            _randomStarted = true;

            while (_randomOn)
            {
                Hub.Clients.All.push("Random");

                var rand = new Random();
                Thread.Sleep(rand.Next(0, 1000));
            }
        }
    }
}