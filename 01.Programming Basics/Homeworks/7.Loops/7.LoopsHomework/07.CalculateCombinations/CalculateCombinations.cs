using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _07.CalculateCombinations
{
    class CalculateCombinations
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine(CalculateFactorial(n) / (CalculateFactorial(k) * CalculateFactorial(n - k)));
        }

        private static BigInteger CalculateFactorial(int num)
        {
            BigInteger factorial = 1;
            while (num > 1)
            {
                factorial *= num;
                num--;
            }

            return factorial;
        }
    }
}
