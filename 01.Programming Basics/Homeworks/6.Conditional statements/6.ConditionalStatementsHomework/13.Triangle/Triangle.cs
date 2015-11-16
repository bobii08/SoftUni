using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Triangle
{
    class Triangle
    {
        static void Main()
        {
            double aX = double.Parse(Console.ReadLine());
            double aY = double.Parse(Console.ReadLine());
            double bX = double.Parse(Console.ReadLine());
            double bY = double.Parse(Console.ReadLine());
            double cX = double.Parse(Console.ReadLine());
            double cY = double.Parse(Console.ReadLine());

            double distanceAB = Math.Sqrt((bX - aX) * (bX - aX) + (bY - aY) * (bY - aY));
            double distanceBC = Math.Sqrt((cX - bX) * (cX - bX) + (cY - bY) * (cY - bY));
            double distanceAC = Math.Sqrt((cX - aX) * (cX - aX) + (cY - aY) * (cY - aY));

            bool pointsOnDiagonal = (aX == aY) && (bX == bY) && (cX == cY);
            bool pointsOnVerticalLine = (aX == bX) && (bX == cX);
            bool pointsOnHorizontalLine = (aY == bY) && (bY == cY);
            if (pointsOnDiagonal || pointsOnVerticalLine || pointsOnHorizontalLine)
            {
                Console.WriteLine("No");
                Console.WriteLine("{0:0.00}", distanceAB);
            }
            else
            {
                double p = (distanceAB + distanceBC + distanceAC) / 2;
                double area = Math.Sqrt(p * (p - distanceAB) * (p - distanceBC) * (p - distanceAC));
                Console.WriteLine("Yes");
                Console.WriteLine("{0:0.00}", area);
            }
        }
    }
}
