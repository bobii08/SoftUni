using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.OddOrEvenIntegers
{
    class OddOrEvenIntegers
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Odd: {0}", false);
            }
            else
            {
                Console.WriteLine("Odd: {0}", true);
            }
        }
    }
}
