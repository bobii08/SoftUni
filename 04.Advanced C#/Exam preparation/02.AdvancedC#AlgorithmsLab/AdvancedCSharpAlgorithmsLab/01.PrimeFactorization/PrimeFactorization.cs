using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PrimeFactorization
{
    class PrimeFactorization
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int initialNumber = number;
            List<int> dividers = new List<int>();

            int divider = 2;
            while (number > 1)
            {
                if (number % divider == 0)
                {
                    dividers.Add(divider);
                    number /= divider;
                }
                else
                {
                    divider++;
                }
            }

            Console.WriteLine("{0} = {1}", initialNumber, string.Join(" * ", dividers));
        }
    }
}
