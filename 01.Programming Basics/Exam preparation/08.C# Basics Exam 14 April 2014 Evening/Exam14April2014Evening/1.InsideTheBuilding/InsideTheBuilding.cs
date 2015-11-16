using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.InsideTheBuilding
{
    internal class InsideTheBuilding
    {
        private static void Main()
        {
            int h = int.Parse(Console.ReadLine());
            Point[] points = new Point[5];
            for (int i = 0; i < points.Length; i++)
            {
                points[i].X = int.Parse(Console.ReadLine());
                points[i].Y = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < points.Length; i++)
            {
                Point currentPoint = points[i];
                if (PointIsInsideTheBuilding(currentPoint, h))
                {
                    Console.WriteLine("inside");
                }
                else
                {
                    Console.WriteLine("outside");
                }
            }
        }

        public static bool PointIsInsideTheBuilding(Point point, int h)
        {
            if ((point.X >= 0 && point.X <= 3 * h) && (point.Y >= 0 && point.Y <= h))
            {
                return true;
            }
            if ((point.X >= h && point.X <= 2 * h) && (point.Y >= h && point.Y <= 4 * h))
            {
                return true;
            }

            return false;
        }
    }

    public struct Point
    {
        public int X { get; set; }

        public int Y { get; set; }
    }
}
