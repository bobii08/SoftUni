using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _18.TrailingZerosInNFactorial
{
    class TrailingZerosInNFactorial
    {
        private static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int numberOfZeros = 0;
            while (n > 4)
            {
                if (n % 5 == 0)
                {
                    int numberToBeChecked = n;
                    while (numberToBeChecked % 5 == 0 && numberToBeChecked != 0)
                    {
                        numberOfZeros++;
                        numberToBeChecked /= 5;
                    }
                }

                n -= 5;
            }

            Console.WriteLine(numberOfZeros);
        }
    }
}
