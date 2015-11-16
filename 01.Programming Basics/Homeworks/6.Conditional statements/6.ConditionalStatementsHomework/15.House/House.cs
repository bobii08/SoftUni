using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _15.House
{
    class House
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            // roof
            int leftAndRightDots = n / 2;
            int roofsHeight = ((n + 1) / 2) - 1;
            int middleDots = -1;
            for (int i = 0; i < roofsHeight; i++)
            {
                if (i == 0)
                {
                    Console.Write(new string('.', leftAndRightDots));
                    Console.Write('*');
                    Console.WriteLine(new string('.', leftAndRightDots));
                    leftAndRightDots--;
                    middleDots += 2;
                }
                else
                {
                    Console.Write(new string('.', leftAndRightDots));
                    Console.Write('*');
                    Console.Write(new string('.', middleDots));
                    Console.Write('*');
                    Console.WriteLine(new string('.', leftAndRightDots));
                    leftAndRightDots--;
                    middleDots += 2;
                }
            }

            Console.WriteLine(new string('*', n));

            // walls
            int wallsLeftAndRightDots = n / 4;
            int wallsMiddleDots = (n - 2) - 2 * (n / 4);
            int height = n - ((n + 1)) / 2 - 1;
            for (int i = 0; i < height; i++)
            {
                Console.Write(new string('.', wallsLeftAndRightDots));
                Console.Write('*');
                Console.Write(new string('.', wallsMiddleDots));
                Console.Write('*');
                Console.WriteLine(new string('.', wallsLeftAndRightDots));
            }

            Console.Write(new string('.', wallsLeftAndRightDots));
            Console.Write(new string('*', (n - 2 * wallsLeftAndRightDots)));
            Console.WriteLine(new string('.', wallsLeftAndRightDots));
        }
    }
}
