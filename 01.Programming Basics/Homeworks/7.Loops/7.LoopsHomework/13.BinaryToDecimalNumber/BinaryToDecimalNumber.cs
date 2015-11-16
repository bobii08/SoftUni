using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.BinaryToDecimalNumber
{
    class BinaryToDecimalNumber
    {
        static void Main()
        {
            Console.Write("binary number: ");
            string binaryNumber = Console.ReadLine();
            long decimalNumber = 0;
            int index = 0;
            for (int i = binaryNumber.Length - 1; i >= 0; i--)
            {
                decimalNumber += int.Parse(binaryNumber[i].ToString()) * (long)Math.Pow(2, index);
                index++;
            }

            Console.WriteLine("decimal number: " + decimalNumber);
        }
    }
}
