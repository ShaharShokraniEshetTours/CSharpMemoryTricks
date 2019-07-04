using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMemoryTricks
{
    public class MyUnboxing
    {
        private const int arraySize = 100000000;

        /// <summary>
        /// Base Measure for increamenting a by 1 for 1,000,000 times without unboxing.
        /// </summary>
        /// <returns>Elapsed Milliseconds</returns>
        public static long MeasureA()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int a = 1;
            for (int i = 0; i < arraySize; i++)
            {
                a = a + 1;
            }

            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        /// <summary>
        /// Base Measure for increamenting a by 1 for 1,000,000 times with unboxing.
        /// </summary>
        /// <returns>Elapsed Milliseconds</returns>
        public static long MeasureB()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            object a = 1;
            for (int i = 0; i < arraySize; i++)
            {
                a = (int)a + 1;
            }

            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        public static void Run()
        {
            //First run to eliminate any startups overhead.
            MyUnboxing.MeasureA();
            MyUnboxing.MeasureB();

            //Real measurment
            long intDuration = MyUnboxing.MeasureA();
            long objDuration = MyUnboxing.MeasureB();

            //Display the results
            Debug.WriteLine("No unboxing performance: {0} elapsed milliseconds.", intDuration);
            Debug.WriteLine("Unboxing performance: {0} elapsed milliseconds.", objDuration);
            Debug.WriteLine("No unboxing performance is {0} times faster.", objDuration / intDuration);

            /*
            Integer performance: 205 elapsed milliseconds.
            Object performance: 646 elapsed milliseconds.
            Integer performance is 3 times faster.
            */
        }
    }
}
