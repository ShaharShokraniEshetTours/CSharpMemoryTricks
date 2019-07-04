using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMemoryTricks
{
    public class MyStruct
    {
        // constants
        private const int numRepetitions = 10000000;

        public static double MeasureA()
        {            
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            List<PointClass> list = new List<PointClass>();
            for (int i = 0; i < numRepetitions; i++)
            {
                list.Add(new PointClass(i, i));
            }
            stopwatch.Stop();
            return stopwatch.Elapsed.TotalMilliseconds;
        }

        public static double MeasureB()
        {            
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            List<PointStruct> list = new List<PointStruct>();
            for (int i = 0; i < numRepetitions; i++)
            {
                list.Add(new PointStruct(i, i));
            }
            stopwatch.Stop();
            return stopwatch.Elapsed.TotalMilliseconds;
        }

        public static void Run()
        {
            // 1st run to eliminate any startup overhead
            MeasureA();
            MeasureB();

            // measurement run
            double stringDuration = MeasureA();
            double stringBuilderDuration = MeasureB();

            // display results
            Debug.WriteLine("Class performance: {0} milliseconds", stringDuration);
            Debug.WriteLine("Struct performance: {0} milliseconds", stringBuilderDuration);
            Debug.WriteLine("Struct performance is {0} times faster.", stringDuration / stringBuilderDuration);

            /*
            Class performance: 825.3537 milliseconds
            Struct performance: 223.9716 milliseconds
            Struct performance is 3.68508194788982 times faster.
            */
        }
    }

    public class PointClass
    {
        public int X;
        public int Y;

        public PointClass(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
    public struct PointStruct
    {
        public int X;
        public int Y;

        public PointStruct(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
