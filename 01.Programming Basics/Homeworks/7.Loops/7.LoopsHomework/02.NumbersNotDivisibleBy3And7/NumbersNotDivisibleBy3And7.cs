using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.NumbersNotDivisibleBy3And7
{
    class NumbersNotDivisibleBy3And7
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            for (int num = 1; num <= n; num++)
            {
                if (num % 3 == 0 || num % 7 == 0)
                {
                    continue;
                }

                Console.Write(num + " ");
            }
        }
    }
}
