using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DiagnosticApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            Thread.Sleep(1000);

            stopWatch.Stop();

            TimeSpan ts = stopWatch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:000}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds);
            Console.WriteLine("RunTime " + elapsedTime);

            Console.ReadKey();
        }
    }
}
