using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMemoryTricks
{
    public class MyBoxing
    {
        private const int arraySize = 100000000;

        /// <summary>
        /// Base Measure for increamenting a by 1 for 1,000,000 times without boxing.
        /// </summary>
        /// <returns>Elapsed Milliseconds</returns>
        public static long MeasureA()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int a = 1;
            for (int i = 0; i < arraySize; i++)
            {
                DoWithoutBoxing(a);
                a = a + 1;
            }

            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        /// <summary>
        /// Base Measure for increamenting a by 1 for 1,000,000 times with boxing.
        /// </summary>
        /// <returns>Elapsed Milliseconds</returns>
        public static long MeasureB()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int a = 1;
            for (int i = 0; i < arraySize; i++)
            {
                DoBoxing(a);
                a = a + 1;
            }

            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        private static void DoBoxing(object i)
        {
        }
        private static void DoWithoutBoxing(int i)
        {
        }

        public static void Run()
        {
            //First run to eliminate any startups overhead.
            MyBoxing.MeasureA();
            MyBoxing.MeasureB();

            //Real measurment
            long intDuration = MyBoxing.MeasureA();
            long objDuration = MyBoxing.MeasureB();

            //Display the results
            Debug.WriteLine("No boxing performance: {0} elapsed milliseconds.", intDuration);
            Debug.WriteLine("Boxing performance: {0} elapsed milliseconds.", objDuration);
            Debug.WriteLine("No boxing performance is {0} times faster.", objDuration / intDuration);

            /*
            No boxing performance: 330 elapsed milliseconds.
            Boxing performance: 764 elapsed milliseconds.
            No boxing performance is 2 times faster.
            */
        }
    }
}
