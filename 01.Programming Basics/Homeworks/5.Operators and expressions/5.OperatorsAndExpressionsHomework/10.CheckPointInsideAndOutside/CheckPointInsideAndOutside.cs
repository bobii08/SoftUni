using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CheckPointInsideAndOutside
{
    class CheckPointInsideAndOutside
    {
        static void Main()
        {
            double xCoord = double.Parse(Console.ReadLine());
            double yCoord = double.Parse(Console.ReadLine());

            double radius = 0;
            if (xCoord == 1)
            {
                radius = yCoord - 1;
            }
            else if(yCoord == 1)
            {
                radius = xCoord - 1;
            }
            else
            {
                radius = Math.Sqrt((xCoord - 1) * (xCoord - 1) + (yCoord - 1) * (yCoord - 1));
            }

            bool isInsideCircle = false;
            if (radius <= 1.5)
            {
                isInsideCircle = true;
            }

            bool isOutOfRectangle = false;
            if (xCoord> 5 || xCoord < -1 || yCoord > 1 || yCoord < -1)
            {
                isOutOfRectangle = true;
            }

            if (isInsideCircle && isOutOfRectangle)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
