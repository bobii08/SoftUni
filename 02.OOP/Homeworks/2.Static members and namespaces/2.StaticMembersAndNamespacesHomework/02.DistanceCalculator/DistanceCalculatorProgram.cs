using _01.Point3D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.DistanceCalculator
{
    class DistanceCalculatorProgram
    {
        static void Main()
        {
            Point3D point = new Point3D(2.5, 3.1, 8);
            double distnace = DistanceCalculator.CalculateDistance(point, Point3D.StartingPointOfCoordSystem);
            Console.WriteLine(distnace);
        }
    }
}
