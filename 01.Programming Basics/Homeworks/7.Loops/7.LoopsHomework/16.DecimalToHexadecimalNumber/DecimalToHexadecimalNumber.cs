using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.DecimalToHexadecimalNumber
{
    class DecimalToHexadecimalNumber
    {
        static void Main()
        {
            Console.Write("enter a number in decimal format: ");
            long number = long.Parse(Console.ReadLine());
            List<char> reversedHexNumber = new List<char>();
            char symbolToBeAdded = ' ';

            while (true)
            {
                long remainder = number % 16;
                number /= 16;

                switch (remainder)
                {
                    case 0:
                        symbolToBeAdded = '0';
                        break;
                    case 1:
                        symbolToBeAdded = '1';
                        break;
                    case 2:
                        symbolToBeAdded = '2';
                        break;
                    case 3:
                        symbolToBeAdded = '3';
                        break;
                    case 4:
                        symbolToBeAdded = '4';
                        break;
                    case 5:
                        symbolToBeAdded = '5';
                        break;
                    case 6:
                        symbolToBeAdded = '6';
                        break;
                    case 7:
                        symbolToBeAdded = '7';
                        break;
                    case 8:
                        symbolToBeAdded = '8';
                        break;
                    case 9:
                        symbolToBeAdded = '9';
                        break;
                    case 10:
                        symbolToBeAdded = 'A';
                        break;
                    case 11:
                        symbolToBeAdded = 'B';
                        break;
                    case 12:
                        symbolToBeAdded = 'C';
                        break;
                    case 13:
                        symbolToBeAdded = 'D';
                        break;
                    case 14:
                        symbolToBeAdded = 'E';
                        break;
                    case 15:
                        symbolToBeAdded = 'F';
                        break;
                }

                reversedHexNumber.Add(symbolToBeAdded);
                if (number == 0)
                {
                    break;
                }
            }

            Console.Write("number in hexadecimal format: ");
            for (int i = reversedHexNumber.Count - 1; i >= 0; i--)
            {
                Console.Write(reversedHexNumber[i]);
            }

            Console.WriteLine();
        }
    }
}
