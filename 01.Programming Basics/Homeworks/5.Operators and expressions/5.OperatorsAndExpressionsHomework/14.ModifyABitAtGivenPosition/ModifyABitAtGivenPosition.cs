using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ModifyABitAtGivenPosition
{
    class ModifyABitAtGivenPosition
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());
            int value = int.Parse(Console.ReadLine());

            int bitAtPositionP = (number >> position) & 1;
            if (bitAtPositionP == 1 && value == 0)
            {
                number &= (~(1 << position));
            }
            else if (bitAtPositionP == 0 && value == 1)
            {
                number |= (1 << position);
            }

            Console.WriteLine(number);
        }
    }
}
