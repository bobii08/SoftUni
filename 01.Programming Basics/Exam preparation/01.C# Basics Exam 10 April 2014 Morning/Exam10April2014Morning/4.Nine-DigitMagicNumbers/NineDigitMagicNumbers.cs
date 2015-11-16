using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Nine_DigitMagicNumbers
{
    class NineDigitMagicNumbers
    {
        static void Main()
        {
            int sum = int.Parse(Console.ReadLine());
            int diff = int.Parse(Console.ReadLine());
            int count = 0;

            for (int num1 = 111; num1 <= 777; num1++)
            {
                int num2 = num1 + diff;
                int num3 = num2 + diff;
                if ((SumOfDigits(num1) + SumOfDigits(num2) + SumOfDigits(num3) == sum) && (num3 <= 777) && CorrectNumber(num1) &&
                    CorrectNumber(num2) && CorrectNumber(num3))
                {
                    Console.WriteLine("{0}{1}{2}", num1, num2, num3);
                    count++;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("No");
            }

        }

        private static bool CorrectNumber(int num)
        {
            bool result = true;

            while (num > 0)
            {
                if (num % 10 == 8 || num % 10 == 9 || num % 10 == 0)
                {
                    result = false;
                    break;
                }

                num /= 10;
            }

            return result;
        }

        private static int SumOfDigits(int num)
        {
            int result = 0;

            while (num > 0)
            {
                result += num % 10;
                num /= 10;
            }

            return result;
        }
    }
}
