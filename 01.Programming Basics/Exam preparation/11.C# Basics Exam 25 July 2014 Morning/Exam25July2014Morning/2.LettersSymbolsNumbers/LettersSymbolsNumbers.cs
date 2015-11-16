using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _2.LettersSymbolsNumbers
{
    class LettersSymbolsNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger sumLetters = 0;
            BigInteger sumNumbers = 0;
            BigInteger sumSymbols = 0;
            for (int i = 0; i < n; i++)
            {
                string currentString = Console.ReadLine();
                for (int j = 0; j < currentString.Length; j++)
                {
                    char currentChar = currentString[j];
                    if (Char.IsLetter(currentChar))
                    {
                        string newStr = currentChar.ToString().ToLower();
                        char newChar = newStr[0];
                        sumLetters += 10 * (newChar - 96);
                    }
                    else if (Char.IsDigit(currentChar))
                    {
                        sumNumbers += int.Parse(currentChar.ToString()) * 20;
                    }
                    else
                    {
                        if (currentChar == '\t' || currentChar == '\r' || currentChar == '\n')
                        {
                            continue;
                        }
                        //if (currentChar == '\\')
                        //{
                        //    if (j < currentString.Length - 1)
                        //    {
                        //        if (currentString[j + 1] == 't' || currentString[j + 1] == 'r' || currentString[j + 1] == 'n')
                        //        {
                        //            j++;
                        //        }
                        //        else
                        //        {
                        //            sumSymbols += 200;
                        //        }
                        //    }
                        //    else
                        //    {
                        //        sumSymbols += 200;
                        //    }

                        //    continue;
                        //}
                        if (currentChar == ' ')
                        {
                            continue;
                        }
                        sumSymbols += 200;
                    }
                }
            }

            if (n == 0)
            {
                Console.WriteLine(0);
                Console.WriteLine(0);
                Console.WriteLine(0);
                return;
            }

            Console.WriteLine(sumLetters);
            Console.WriteLine(sumNumbers);
            Console.WriteLine(sumSymbols);
        }
    }
}
