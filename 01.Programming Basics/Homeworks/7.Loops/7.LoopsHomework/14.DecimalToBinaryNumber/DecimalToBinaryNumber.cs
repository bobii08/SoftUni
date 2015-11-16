using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.DecimalToBinaryNumber
{
    class DecimalToBinaryNumber
    {
        static void Main()
        {
            Console.Write("decimal number(long): ");
            long decimalNumber = long.Parse(Console.ReadLine());
            Console.Write("binary number: ");
            List<string> binaryReversed = new List<string>();
            while (true)
            {
                string charToBeAdded = (decimalNumber % 2).ToString();
                binaryReversed.Add(charToBeAdded);
                decimalNumber = decimalNumber / 2;
                if (decimalNumber == 0)
                {
                    break;
                }
            }

            for (int i = binaryReversed.Count - 1; i >= 0; i--)
            {
                Console.Write(binaryReversed[i]);
            }

            Console.WriteLine();
        }
    }
}
