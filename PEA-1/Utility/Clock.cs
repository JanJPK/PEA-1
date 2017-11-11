using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEA_1.Utility
{
    public static class Clock
    {
        private static readonly Stopwatch Stopwatch = new Stopwatch();

        public static void Start()
        {
            Stopwatch.Reset();
            Stopwatch.Start();
        }

        public static void Continue()
        {
            Stopwatch.Start();
        }

        public static void Stop()
        {
            Stopwatch.Stop();
        }

        public static double StopAndReturn()
        {
            Stopwatch.Stop();
            return Stopwatch.Elapsed.TotalMilliseconds;
        }

        public static double ReturnElapsed()
        {
            return Stopwatch.Elapsed.TotalMilliseconds;
        }
    }

}
