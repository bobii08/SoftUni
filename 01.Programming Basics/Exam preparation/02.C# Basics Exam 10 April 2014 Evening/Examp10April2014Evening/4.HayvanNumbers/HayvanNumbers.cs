using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace _4.HayvanNumbers
{
    class HayvanNumbers
    {
        static void Main()
        {
            long sum = long.Parse(Console.ReadLine());
            long diff = long.Parse(Console.ReadLine());

            long countAnswers = 0;

            for (long abc = 555; abc <= 999; abc++)
            {
                long def = abc + diff;
                long ghi = def + diff;

                if (CorrectNumber(abc) && CorrectNumber(def) && CorrectNumber(ghi) &&
                    (SumOfDigits(abc) + SumOfDigits(def) + SumOfDigits(ghi) == sum) &&
                    ghi <= 999)
                {
                    Console.WriteLine("{0}{1}{2}", abc, def, ghi);
                    countAnswers++;
                }
            }

            if (countAnswers == 0)
            {
                Console.WriteLine("No");
            }
        }

        private static bool CorrectNumber(long num)
        {
            bool result = true;
            while (num > 0)
            {
                long digit = num % 10;
                if (digit >= 0 && digit <= 4)
                {
                    result = false;
                    break;
                }

                num /= 10;
            }

            return result;
        }

        private static long SumOfDigits(long num)
        {
            long sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }

            return sum;
        }
    }
}
