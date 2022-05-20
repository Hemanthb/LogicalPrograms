using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LogicalPrograms
{
    internal class StopWatchUc6
    {
        Stopwatch stpwatch =new Stopwatch();
        public void CalculateTime()
        {
            stpwatch.Start();
            Console.WriteLine("Enter 'S' to stop the program");
            if (Console.ReadKey().Key == ConsoleKey.S)
            {
                stpwatch.Stop();
            }
            //Thread.Sleep(10000);
            
            TimeSpan time = stpwatch.Elapsed;
            Console.WriteLine("Elapsed Time is {0:00}m:{1:00}s",time.Minutes,time.Seconds);
        }
        
    }
}
