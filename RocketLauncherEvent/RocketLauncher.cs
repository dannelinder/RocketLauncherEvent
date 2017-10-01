using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RocketLauncherEvent
{
    class RocketLauncher
    {
        int seconds;
        public event Action<int, bool> Tick;

        public RocketLauncher(int seconds)
        {
            this.seconds = seconds;
        }

        public void StartCount()
        {
            for (int i = seconds; i >= 0; i--)
            {
                Tick?.Invoke(i, i == 0); 
                Thread.Sleep(1000);                 // Sets a delay of 1 second
            }
        }
    }
}
