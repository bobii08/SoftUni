using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.PrimeNumberCheck
{
    class PrimeNumberCheck
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            if (number <= 1)
            {
                Console.WriteLine(false);
                return;
            }

            int divider = 2;
            int maxDivider = (int)Math.Sqrt(number);
            bool prime = true;
            while (divider <= maxDivider)
            {
                if (number % divider == 0)
                {
                    prime = false;
                    break;
                }

                divider++;
            }

            Console.WriteLine(prime);
        }
    }
}
