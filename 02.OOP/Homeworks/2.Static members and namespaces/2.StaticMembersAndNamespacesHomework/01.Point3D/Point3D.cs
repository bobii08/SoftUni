using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _01.Point3D
{
    public class Point3D
    {
        private static readonly Point3D StartingPoint = new Point3D(0, 0, 0);

        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public static Point3D StartingPointOfCoordSystem
        {
            get { return Point3D.StartingPoint; }
        }

        public override string ToString()
        {
            return "X: " + this.X + ", Y: " + this.Y + ", Z: " + this.Z;
        }
    }
}
