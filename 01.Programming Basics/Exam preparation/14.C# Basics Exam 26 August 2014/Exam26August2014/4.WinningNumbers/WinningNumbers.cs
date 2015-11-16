using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.WinningNumbers
{
    class WinningNumbers
    {
        static void Main()
        {
            string str = Console.ReadLine();
            if (string.IsNullOrEmpty(str))
            {
                Console.WriteLine("No");
                return;
            }

            int letSum = 0;
            int curentLetterWeight = 0;
            for (int i = 0; i < str.Length; i++)
            {
                char currentChar = str[i];
                if (currentChar < 97)
                {
                    currentChar = (char)(currentChar + 32);
                }

                curentLetterWeight = currentChar - 96;
                letSum += curentLetterWeight;
            }

            List<string> threeDigitsList = new List<string>();

            for (int i = 0; i <= 9; i++)
            {
                if (letSum != 0 && i == 0)
                {
                    continue;
                }
                for (int j = 0; j <= 9; j++)
                {
                    if (letSum != 0 && j == 0)
                    {
                        continue;
                    }
                    for (int k = 0; k <= 9; k++)
                    {
                        if (letSum != 0 && k == 0)
                        {
                            continue;
                        }

                        if (i * j * k == letSum)
                        {
                            string strToBeAdded = i + "" + j + k;
                            threeDigitsList.Add(strToBeAdded);
                        }
                    }
                }
            }

            if (threeDigitsList.Count == 0)
            {
                Console.WriteLine("No");
                return;
            }

            for (int i = 0; i < threeDigitsList.Count; i++)
            {
                for (int j = 0; j < threeDigitsList.Count; j++)
                {
                    Console.WriteLine(threeDigitsList[i] + "-" + threeDigitsList[j]);
                }
            }
        }
    }
}
