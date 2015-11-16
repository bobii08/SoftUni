using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Point3D
{
    class Point3DProgram
    {
        static void Main()
        {
            Point3D point = new Point3D(2.5, 3.1, 8);
            Console.WriteLine(point);

            Console.WriteLine(Point3D.StartingPointOfCoordSystem);
        }
    }
}
