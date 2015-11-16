using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.HexadecimalToDecimalNumber
{
    class HexadecimalToDecimalNumber
    {
        static void Main()
        {
            Console.Write("number in hexadecimal format: ");
            string hexNumber = Console.ReadLine();
            int index = 0;
            long decimalNumber = 0;
            for (int i = hexNumber.Length - 1; i >= 0; i--)
            {
                char currentChar = hexNumber[i];
                int num = 0;
                switch (currentChar)
                {
                    case '0':
                        num = 0;
                        break;
                    case '1':
                        num = 1;
                        break;
                    case '2':
                        num = 2;
                        break;
                    case '3':
                        num = 3;
                        break;
                    case '4':
                        num = 4;
                        break;
                    case '5':
                        num = 5;
                        break;
                    case '6':
                        num = 6;
                        break;
                    case '7':
                        num = 7;
                        break;
                    case '8':
                        num = 8;
                        break;
                    case '9':
                        num = 9;
                        break;
                    case 'A':
                        num = 10;
                        break;
                    case 'B':
                        num = 11;
                        break;
                    case 'C':
                        num = 12;
                        break;
                    case 'D':
                        num = 13;
                        break;
                    case 'E':
                        num = 14;
                        break;
                    case 'F':
                        num = 15;
                        break;
                }

                decimalNumber += num * (long)Math.Pow(16, index++);
            }

            Console.WriteLine("number in decimal format: " + decimalNumber);
        }
    }
}
