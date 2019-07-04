using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMemoryTricks
{
    public class MyArray
    {
        private const int numElements = 100000000;

        public static double MeasureB()
        {
            List<int> list = new List<int>();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < numElements; i++)
            {
                list.Add(i);
            }
            stopwatch.Stop();
            return stopwatch.Elapsed.TotalMilliseconds;
        }

        public static double MeasureC()
        {
            int[] list = new int[numElements];
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < numElements; i++)
            {
                list[i] = i;
            }
            stopwatch.Stop();
            return stopwatch.Elapsed.TotalMilliseconds;
        }

        public static void Run()
        {
            // measurement run            
            double genericDuration = MeasureB();
            double nativeDuration = MeasureC();
            
            Debug.WriteLine("List<int>: {0}", genericDuration);
            Debug.WriteLine("int[]: {0}", nativeDuration);

            //Display the results
            Debug.WriteLine("int[]: performance is {0} times faster than List<int>.", genericDuration / nativeDuration);

            /*
            List<int>: 537.5732
            int[]: 312.667
            int[]: performance is 1.71931543783002 times faster than List<int>.
             */
        }

    }
}