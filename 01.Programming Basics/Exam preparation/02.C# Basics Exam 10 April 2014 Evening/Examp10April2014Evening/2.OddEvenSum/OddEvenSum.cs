using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _2.OddEvenSum
{
    class OddEvenSum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[2 * n];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            BigInteger sumOddNumbers = 0;
            for (int i = 0; i < numbers.Length; i += 2)
            {
                sumOddNumbers += numbers[i];
            }

            BigInteger sumEvenNumbers = 0;
            for (int i = 1; i < numbers.Length; i += 2)
            {
                sumEvenNumbers += numbers[i];
            }

            if (sumOddNumbers == sumEvenNumbers)
            {
                Console.WriteLine("Yes, sum={0}", sumOddNumbers);
            }
            else
            {
                Console.WriteLine("No, diff={0}", Math.Abs((decimal)(sumOddNumbers - sumEvenNumbers)));
            }
        }
    }
}
