using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  System.Numerics;

namespace _08.CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(CalculateFactorial(2 * n) / (CalculateFactorial(n + 1) * CalculateFactorial(n)));
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
