using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.NestedLoops
{
    class NestedLoops
    {
        static void Main()
        {
            string secretNumber = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int countOfAnswers = 0;
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int k = 1; k <= 9; k++)
                    {
                        for (int l = 1; l <= 9; l++)
                        {
                            string wordToCheck = i + "" + j + k + l;
                            if (CheckIfNumberMatchesTheConditions(secretNumber, b, c, wordToCheck))
                            {
                                Console.Write(wordToCheck + " ");
                                countOfAnswers++;
                            }
                        }
                    }
                }
            }

            if (countOfAnswers == 0)
            {
                Console.WriteLine("No");
            }
        }

        static bool CheckIfNumberMatchesTheConditions(string secretNumber, int b, int c, string numberToCheck)
        {
            int countOfBools = 0;
            bool[] arrOfTruePositionsInSecretNumber =
            {
                true, true, true, true
            };
            bool[] arrOfTruePositionsInNumberToCheck =
            {
                true, true, true, true
            };
            if (secretNumber[0] == numberToCheck[0])
            {
                countOfBools++;
                arrOfTruePositionsInSecretNumber[0] = false;
                arrOfTruePositionsInNumberToCheck[0] = false;
            }
            if (secretNumber[1] == numberToCheck[1])
            {
                countOfBools++;
                arrOfTruePositionsInSecretNumber[1] = false;
                arrOfTruePositionsInNumberToCheck[1] = false;
            }
            if (secretNumber[2] == numberToCheck[2])
            {
                countOfBools++;
                arrOfTruePositionsInSecretNumber[2] = false;
                arrOfTruePositionsInNumberToCheck[2] = false;
            }
            if (secretNumber[3] == numberToCheck[3])
            {
                countOfBools++;
                arrOfTruePositionsInSecretNumber[3] = false;
                arrOfTruePositionsInNumberToCheck[3] = false;
            }
            if (countOfBools != b)
            {
                return false;
            }

            int countOfCows = 0;
            for (int i = 0; i < 4; i++)
            {
                char letterInSecretNum = secretNumber[i];
                for (int j = 0; j < 4; j++)
                {
                    char letterInNumToCheck = numberToCheck[j];
                    if (letterInSecretNum == letterInNumToCheck &&
                        arrOfTruePositionsInSecretNumber[i] && arrOfTruePositionsInNumberToCheck[j])
                    {
                        countOfCows++;
                        arrOfTruePositionsInSecretNumber[i] = false;
                        arrOfTruePositionsInNumberToCheck[j] = false;
                    }
                }
            }

            if (countOfCows == c)
            {
                return true;
            }

            return false;
        }
    }
}
