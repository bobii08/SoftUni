using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.HouseWithAWindow
{
    class HouseWithAWindow
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int widthOfHouse = 2 * n - 1;
            int heightOfHouse = 2 * n + 2;
            int heightOfRoof = n;
            int baseHouseHeight = n + 2;
            int windowHeight = n / 2;
            int windowWidth = n - 3;

            // roof
            int leftAndRightRoofDots = widthOfHouse / 2;
            int middleDots = 0;
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    Console.Write(new string('.', leftAndRightRoofDots));
                    Console.Write('*');
                    Console.WriteLine(new string('.', leftAndRightRoofDots));
                    leftAndRightRoofDots--;
                    middleDots++;
                    continue;
                }

                Console.Write(new string('.', leftAndRightRoofDots));
                Console.Write('*');
                Console.Write(new string('.', middleDots));
                Console.Write('*');
                Console.WriteLine(new string('.', leftAndRightRoofDots));
                leftAndRightRoofDots--;
                middleDots += 2;
            }

            // bootom of roof
            Console.WriteLine(new string('*', widthOfHouse));

            int countOfDots = (baseHouseHeight - 2 - windowHeight) / 2;

            for (int i = 0; i < countOfDots; i++)
            {
                Console.Write('*');
                Console.Write(new string('.', widthOfHouse - 2));
                Console.WriteLine('*');
            }

            for (int i = 0; i < windowHeight; i++)
            {
                Console.Write('*');
                Console.Write(new string('.', n / 2));
                Console.Write(new string('*', windowWidth));
                Console.Write(new string('.', n / 2));
                Console.WriteLine('*');
            }

            for (int i = 0; i < countOfDots; i++)
            {
                Console.Write('*');
                Console.Write(new string('.', widthOfHouse - 2));
                Console.WriteLine('*');
            }

            // bottom of house
            Console.WriteLine(new string('*', widthOfHouse));
        }
    }
}
