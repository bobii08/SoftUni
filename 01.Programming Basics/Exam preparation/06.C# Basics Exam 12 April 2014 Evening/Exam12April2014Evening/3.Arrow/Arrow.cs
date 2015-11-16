using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Arrow
{
    class Arrow
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int firstHeight = n - 2;
            int secondHeight = n - 1;
            int leftAndRightDotsTop = n / 2;
            int leftAndRightDotsBottom = 1;
            int middleDotsBottom = n * 2 - 5;
            Console.Write(new string('.', leftAndRightDotsTop));
            Console.Write(new string('#', n));
            Console.WriteLine(new string('.', leftAndRightDotsTop));

            for (int i = 0; i < firstHeight; i++)
            {
                Console.Write(new string('.', leftAndRightDotsTop));
                Console.Write('#');
                Console.Write(new string('.', (n - 2)));
                Console.Write('#');
                Console.WriteLine(new string('.', leftAndRightDotsTop));
            }

            Console.Write(new string('#', leftAndRightDotsTop + 1));
            Console.Write(new string('.', n - 2));
            Console.WriteLine(new string('#', leftAndRightDotsTop + 1));

            for (int i = 0; i < secondHeight; i++)
            {
                Console.Write(new string('.', leftAndRightDotsBottom));
                Console.Write('#');
                Console.Write(new string('.', middleDotsBottom));
                Console.Write('#');
                Console.WriteLine(new string('.', leftAndRightDotsBottom));
                leftAndRightDotsBottom++;
                middleDotsBottom -= 2;
                if (middleDotsBottom < 0)
                {
                    Console.Write(new string('.', leftAndRightDotsBottom));
                    Console.Write('#');
                    Console.WriteLine(new string('.', leftAndRightDotsBottom));
                    break;
                }
            }
        }
    }
}
