using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpMemoryTricks
{
    public class MyHeap
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

            Line[] lines = new Line[4];
            lines[0] = new Line(x, y, xw, y);
            lines[1] = new Line(xw, y, xw, yh);
            lines[2] = new Line(xw, yh, x, yh);
            lines[3] = new Line(x, yh, x, y);

            DrawPolygon(lines);
        }

        private static void DrawPolygon(Line[] lines)
        {
            //TODO: put line drawing code here
        }
    }

    public class Line
    {
        public int X1;
        public int X2;
        public int Y1;
        public int Y2;

        public Line(int x1, int y1, int x2, int y2)
        {
            this.X1 = x1;
            this.Y1 = y1;
            this.X2 = x2;
            this.Y2 = y2;
        }
    }
}
