using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMemoryTricks
{
    public class MyStringConcatination
    {
        // constants
        private const int numRepetitions = 100000;

        public static double MeasureA()
        {
            string s = string.Empty;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < numRepetitions; i++)
            {
                s = s + "a";
            }
            stopwatch.Stop();
            return stopwatch.Elapsed.TotalMilliseconds;
        }

        public static double MeasureB()
        {
            StringBuilder sb = new StringBuilder();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < numRepetitions; i++)
            {
                sb.Append("a");
            }
            stopwatch.Stop();
            return stopwatch.Elapsed.TotalMilliseconds;
        }

        public static void Run()
        {
            // 1st run to eliminate any startup overhead
            //MeasureA();
            MeasureB();

            // measurement run
            //double stringDuration = MeasureA();
            double stringBuilderDuration = MeasureB();

            // display results
            //Debug.WriteLine("String performance: {0} milliseconds", stringDuration);
            //Debug.WriteLine("StringBuilder performance: {0} milliseconds", stringBuilderDuration);
            //Debug.WriteLine("StringBuilder performance is {0} times faster.", stringDuration / stringBuilderDuration);

            /*
            String performance: 934.2579 milliseconds
            StringBuilder performance: 0.3937 milliseconds
            StringBuilder performance is 2373.01981203962 times faster.
            */
        }
    }
}
