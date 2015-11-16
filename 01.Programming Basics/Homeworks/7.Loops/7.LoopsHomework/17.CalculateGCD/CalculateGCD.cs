using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.CalculateGCD
{
    class CalculateGCD
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a < 0 && b > 0)
            {
                a *= -1;
            }
            else if (a > 0 && b < 0)
            {
                b *= -1;
            }
            else if (a < 0 && b < 0)
            {
                a *= -1;
                b *= -1;
                Console.WriteLine(CalculateGreatestCommongDivisor(a, b)*(-1));
                return;
            }

            Console.WriteLine(CalculateGreatestCommongDivisor(a, b));
        }

        private static int CalculateGreatestCommongDivisor(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }

            return a;
        }
    }
}
