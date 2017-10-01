using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketLauncherEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            RocketLauncher launcher = new RocketLauncher(10);       // Seconds for countdown

            launcher.Tick += Launcher_Tick; 
            launcher.StartCount();
        }

        private static void Launcher_Tick(int second, bool isLaunch) // The event handler
        {
            if (isLaunch)
            {
                Console.WriteLine("FIRE!!!!");
            }
            else
            {
                Console.WriteLine($"{second}...");
            }
        }
    }
}
