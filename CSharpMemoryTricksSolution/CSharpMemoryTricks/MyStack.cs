using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpMemoryTricks
{
    public class MyStack
    {
        public static void Run()
        {
            Console.WriteLine("Going to draw a square...");
            DrawSquare(100, 100, 50, 50);
            Console.WriteLine("All done! garbage collector to the rescue...");
        }

        private static void DrawSquare(int x, int y, int w, int h)
        {
            int xw = x + w;
            int yh = y + h;

            DrawLine(x, y, xw, y);
            DrawLine(xw, y, xw, yh);
            DrawLine(xw, yh, x, yh);
            DrawLine(x, yh, x, y);
        }

        private static void DrawLine(int x, int y1, object x2, int y2)
        {
            //TODO: put line drawing code here
            ////Uncomment to cause a Stackoverflow Exception:
            //DrawLine(x, y1, x2, y2);
        }
    }
}
