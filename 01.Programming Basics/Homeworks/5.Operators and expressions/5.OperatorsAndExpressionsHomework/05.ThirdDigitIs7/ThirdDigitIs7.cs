using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ThirdDigitIs7
{
    class ThirdDigitIs7
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            bool isThirdDigit7 = false;
            if (number < 700)
            {
                isThirdDigit7 = false;
            }
            else
            {
                int thirdDigit = (number / 100) % 10;
                if (thirdDigit == 7)
                {
                    isThirdDigit7 = true;
                }
            }

            Console.WriteLine(isThirdDigit7);
        }
    }
}
