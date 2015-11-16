using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Car
{
    class Car
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int widthOfCar = 3 * n;
            int roofHeight = n / 2;
            int bodyHeight = n / 2;
            int wheelsHeight = n / 2 - 1;

            // top row
            Console.Write(new string('.', (widthOfCar - n) / 2));
            Console.Write(new string('*', n));
            Console.WriteLine(new string('.', (widthOfCar - n) / 2));

            // roof without the top
            int leftAndRightDots = (widthOfCar - n) / 2 - 1;
            int middleDots = n;
            for (int i = 0; i < roofHeight - 1; i++)
            {
                Console.Write(new string('.', leftAndRightDots));
                Console.Write('*');
                Console.Write(new string('.', middleDots));
                Console.Write('*');
                Console.WriteLine(new string('.', leftAndRightDots));
                middleDots += 2;
                leftAndRightDots--;
            }

            // body top
            Console.Write(new string('*', ++leftAndRightDots));
            Console.Write(new string('.', widthOfCar - 2 * leftAndRightDots));
            Console.WriteLine(new string('*', leftAndRightDots));

            // body middle
            for (int i = 0; i < bodyHeight - 2; i++)
            {
                Console.Write('*');
                Console.Write(new string('.', widthOfCar - 2));
                Console.WriteLine('*');
            }

            // body bottom
            Console.WriteLine(new string('*', widthOfCar));

            //wheels middle
            int wheelsFirstDots = --leftAndRightDots;
            int wheelsSecondDots = wheelsFirstDots - 1;
            for (int i = 0; i < wheelsHeight - 1; i++)
            {
                Console.Write(new string('.', wheelsFirstDots));
                Console.Write('*');
                Console.Write(new string('.', wheelsSecondDots));
                Console.Write('*');
                Console.Write(new string('.', n - 2));
                Console.Write('*');
                Console.Write(new string('.', wheelsSecondDots));
                Console.Write('*');
                Console.WriteLine(new string('.', wheelsFirstDots));
            }

            // wheels bottom
            Console.Write(new string('.', wheelsFirstDots));
            Console.Write(new string('*', wheelsFirstDots + 1));
            Console.Write(new string('.', n - 2));
            Console.Write(new string('*', wheelsFirstDots + 1));
            Console.WriteLine(new string('.', wheelsFirstDots));
        }
    }
}
