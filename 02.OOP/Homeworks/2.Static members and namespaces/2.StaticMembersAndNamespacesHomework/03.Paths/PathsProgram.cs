using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Point3D;

namespace _03.Paths
{
    class PathsProgram
    {
        static void Main()
        {
            Path3D path = new Path3D();
            Point3D point = new Point3D(2, 5.2, 9.1);
            path.Add(point);
            path.Add(Point3D.StartingPointOfCoordSystem);
            path.Add(new Point3D(2.4, 1.2, 5.3));
            Console.WriteLine("Path saved to a file");
            Console.WriteLine(path);
            Storage.SavePathToATextFile(path);
            var newPath = Storage.LoadPathFromAtextFile("../../fileWithAPath.txt");
            Path3D pathLoadedFromFile = newPath;
            Console.WriteLine("Path loaded from file: ");
            Console.WriteLine(newPath.ToString());
        }
    }
}
