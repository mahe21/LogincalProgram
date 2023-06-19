using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class StopWatch
    {
        public void StopWatchTime()
        {
            Console.WriteLine("Stopwatch Program");
            Console.WriteLine("Press any key to start the stopwatch");
            Console.ReadKey();

            DateTime startTime = DateTime.Now;

            Console.WriteLine("Stopwatch started!");
            Console.WriteLine("Press any key to stop the stopwatch");
            Console.ReadKey();

            DateTime endTime = DateTime.Now;
            TimeSpan elapsedTime = endTime - startTime;

            Console.WriteLine("Stopwatch stopped!");
            Console.WriteLine("Elapsed time: " + elapsedTime);

            Console.ReadLine();
        }
    }
}
