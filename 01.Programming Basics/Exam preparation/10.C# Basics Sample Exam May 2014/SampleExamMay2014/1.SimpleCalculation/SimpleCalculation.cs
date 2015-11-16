using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SimpleCalculation
{
    class SimpleCalculation
    {
        static void Main()
        {
            double xCoord = double.Parse(Console.ReadLine());
            double yCoord = double.Parse(Console.ReadLine());

            if (xCoord == 0 && yCoord == 0)
            {
                Console.WriteLine(0);
            }
            else if (xCoord > 0 && yCoord > 0)
            {
                Console.WriteLine(1);
            }
            else if (xCoord < 0 && yCoord > 0)
            {
                Console.WriteLine(2);
            }
            else if (xCoord < 0 && yCoord < 0)
            {
                Console.WriteLine(3);
            }
            else if (xCoord > 0 && yCoord < 0)
            {
                Console.WriteLine(4);
            }
            else if (xCoord == 0)
            {
                Console.WriteLine(5);
            }
            else
            {
                Console.WriteLine(6);
            }
        }
    }
}
