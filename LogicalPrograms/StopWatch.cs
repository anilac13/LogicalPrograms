using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class StopWatch
    {
        public const string START = "Start", STOP = "Stop";
        public static void CalculateTime()
        {
            Console.WriteLine("Enter 'Start' to run Stop watch");
            string start = Console.ReadLine();
            if (start.ToLower() == START.ToLower())
            {
                DateTime time = DateTime.Now;
                int hour1 = time.Hour;
                int min1 = time.Minute;
                int sec1 = time.Second;
                int millisec1 = time.Millisecond;

                Console.WriteLine("Enter 'Stop' to end Stop watch");
                string stop = Console.ReadLine();
                if (stop.ToLower() == STOP.ToLower())
                {
                    DateTime time1 = DateTime.Now;
                    int hour2 = time1.Hour;
                    int min2 = time1.Minute;
                    int sec2 = time1.Second;
                    int millisec2 = time1.Millisecond;
                    Console.WriteLine("Stop Watch Time: " + (hour2 - hour1) + ":" + (min2 - min1) + ":" + (sec2 - sec1) + ":" + (millisec2 - millisec1));
                }
            }
        }
    }
}
