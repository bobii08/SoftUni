using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PointInACircle
{
    class PointInACircle
    {
        static void Main()
        {
            double xCoord = double.Parse(Console.ReadLine());
            double yCoord = double.Parse(Console.ReadLine());

            bool isInside = true;
            double radius = Math.Sqrt(xCoord * xCoord + yCoord * yCoord);
            if (radius > 2)
            {
                isInside = false;
            }

            Console.WriteLine(isInside);
        }
    }
}
