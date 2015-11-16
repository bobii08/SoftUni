using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.MagicCarNumbers
{
    class MagicCarNumbers
    {
        static bool CheckIfLicenseIsCorrect(string license)
        {
            char firstLetter = license[0];
            char secondLetter = license[1];
            char thirdLetter = license[2];
            char fourthLetter = license[3];
            if ((firstLetter == secondLetter) && (firstLetter == thirdLetter) && (firstLetter == fourthLetter))
            {
                return true;
            }
            else if ((secondLetter == thirdLetter) && (secondLetter == fourthLetter) && (firstLetter != secondLetter))
            {
                return true;
            }
            else if ((firstLetter == secondLetter) && (firstLetter == thirdLetter) && (firstLetter != fourthLetter))
            {
                return true;
            }
            else if ((firstLetter == secondLetter) && (firstLetter != thirdLetter) && (thirdLetter == fourthLetter))
            {
                return true;
            }
            else if ((firstLetter == fourthLetter) && (firstLetter != secondLetter) && (secondLetter == thirdLetter))
            {
                return true;
            }
            else if ((firstLetter == thirdLetter) && (firstLetter != secondLetter) && (secondLetter == fourthLetter))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main()
        {
            int magicWeight = int.Parse(Console.ReadLine());
            magicWeight -= 40;
            int[] numbers =
            {
                0, 1, 2, 3, 4, 5, 6, 7, 8, 9
            };
            char[] letters =
            {
                'A',
                'B',
                'C',
                'E',
                'H',
                'K',
                'M',
                'P',
                'T',
                'X'
            };
            int[] lettersWeights =
            {
                10,
                20,
                30,
                50,
                80,
                110,
                130,
                160,
                200,
                240
            };

            int countOfAnswers = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int firstNum = numbers[i];
                for (int j = 0; j < numbers.Length; j++)
                {
                    int secondNum = numbers[j];
                    for (int k = 0; k < numbers.Length; k++)
                    {
                        int thirdNum = numbers[k];
                        for (int l = 0; l < numbers.Length; l++)
                        {
                            int fourthNum = numbers[l];
                            for (int m = 0; m < letters.Length; m++)
                            {
                                int firstLetterWeight = lettersWeights[m];
                                for (int n = 0; n < letters.Length; n++)
                                {
                                    int secondLetterWeight = lettersWeights[n];
                                    int currentWeight = firstNum + secondNum + thirdNum + fourthNum +
                                        firstLetterWeight + secondLetterWeight;
                                    if (currentWeight == magicWeight)
                                    {
                                        string currentLicenseThatHasMagicWeight = firstNum + "" +
                                                                                  secondNum +
                                                                                  thirdNum + fourthNum +
                                                                                  letters[m] + letters[n];
                                        if (CheckIfLicenseIsCorrect(currentLicenseThatHasMagicWeight.Substring(0, 4)))
                                        {
                                            // Console.WriteLine("CA" + currentLicenseThatHasMagicWeight);
                                            countOfAnswers++;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine(countOfAnswers);
        }
    }
}
