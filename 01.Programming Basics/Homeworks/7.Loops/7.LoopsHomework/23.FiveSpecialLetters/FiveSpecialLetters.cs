using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.FiveSpecialLetters
{
    class FiveSpecialLetters
    {
        static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            int[] weights = 
            {
                5,
                -12,
                47,
                7,
                -32
            };

            char[] letters = 
            {
                'a',
                'b',
                'c',
                'd',
                'e'
            };

            int totalSequences = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        for (int l = 0; l < 5; l++)
                        {
                            for (int m = 0; m < 5; m++)
                            {
                                string currentString = letters[i] + "" + letters[j] + "" + letters[k] + "" +
                                        letters[l] + "" + letters[m];
                                string originalString = currentString;
                                for (int n = 0; n < currentString.Length; n++)
                                {
                                    char currentLetter = currentString[n];
                                    int indexAtWhichToBeRemoved = currentString.IndexOf(currentLetter, (n + 1));
                                    if (indexAtWhichToBeRemoved != -1)
                                    {
                                        currentString = currentString.Remove(indexAtWhichToBeRemoved, 1);
                                        n--;
                                    }
                                }

                                int currentWeight = 0;
                                for (int n = 0; n < currentString.Length; n++)
                                {
                                    char currentSymbol = currentString[n];
                                    int position = 0;
                                    for (int o = 0; o < letters.Length; o++)
                                    {
                                        if (currentSymbol == letters[o])
                                        {
                                            position = o;
                                        }
                                    }

                                    currentWeight += (n + 1) * (weights[position]);
                                }

                                if (currentWeight >= start && currentWeight <= end)
                                {
                                    Console.Write(originalString + " ");
                                    totalSequences++;
                                }
                            }
                        }
                    }
                }
            }

            if (totalSequences == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
