using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.WineGlass
{
    class WineGlass
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int leftAndRightDots = 0;
            int asteriks = n - 2;
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string('.', leftAndRightDots));
                Console.Write('\\');
                Console.Write(new string('*', asteriks));
                Console.Write('/');
                Console.WriteLine(new string('.', leftAndRightDots));
                leftAndRightDots++;
                asteriks -= 2;
            }

            if (n < 12)
            {
                int dots = (n / 2) - 1;
                for (int i = 0; i < (n / 2) - 1; i++)
                {
                    Console.Write(new string('.', dots));
                    Console.Write("||");
                    Console.WriteLine(new string('.', dots));
                }

                Console.WriteLine(new string('-', n));
            }
            else
            {
                int dots = (n / 2) - 1;
                for (int i = 0; i < (n / 2) - 2; i++)
                {
                    Console.Write(new string('.', dots));
                    Console.Write("||");
                    Console.WriteLine(new string('.', dots));
                }

                Console.WriteLine(new string('-', n));
                Console.WriteLine(new string('-', n));
            }

        }
    }
}
