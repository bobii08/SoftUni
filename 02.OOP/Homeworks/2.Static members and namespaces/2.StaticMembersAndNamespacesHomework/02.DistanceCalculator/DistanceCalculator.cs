using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Point3D;

namespace _02.DistanceCalculator
{
    public static class DistanceCalculator
    {
        public static double CalculateDistance(Point3D point1, Point3D point2)
        {
            double result =
                Math.Sqrt((point2.X - point1.X)*(point2.X - point1.X) + (point2.Y - point1.Y)*(point2.Y - point1.Y) +
                          (point2.Z - point1.Z)*(point2.Z - point1.Z));
            return result;
        }
    }
}
