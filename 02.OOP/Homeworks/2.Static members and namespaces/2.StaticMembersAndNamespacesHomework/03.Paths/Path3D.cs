using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Point3D;

namespace _03.Paths
{
    public class Path3D
    {
        public readonly List<Point3D> listOfPoints = new List<Point3D>();

        public void Add(Point3D point)
        {
            listOfPoints.Add(point);
        }

        public Point3D this[int index]
        {
            get
            {
                if (index < 0 || index > listOfPoints.Count - 1)
                {
                    throw new IndexOutOfRangeException(string.Format("Ivalid index {0}", index));
                }
                return this.listOfPoints[index];
            }
            set
            {
                if (index < 0 || index > listOfPoints.Count - 1)
                {
                    throw new IndexOutOfRangeException(string.Format("Ivalid index {0}", index));
                }
                this.listOfPoints[index] = value;
            }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Path: ");
            for (int i = 0; i < this.listOfPoints.Count; i++)
            {
                stringBuilder.AppendLine(this.listOfPoints[i].ToString());
            }

            return stringBuilder.ToString();
        }
    }
}
