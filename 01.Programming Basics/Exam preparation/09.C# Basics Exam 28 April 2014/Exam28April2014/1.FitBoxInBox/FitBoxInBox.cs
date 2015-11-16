using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.FitBoxInBox
{
    class FitBoxInBox
    {
        static void Main()
        {
            int firstBoxX = int.Parse(Console.ReadLine());
            int firstBoxY = int.Parse(Console.ReadLine());
            int firstBoxZ = int.Parse(Console.ReadLine()); 
            int secondBoxX = int.Parse(Console.ReadLine());
            int secondBoxY = int.Parse(Console.ReadLine()); 
            int secondBoxZ = int.Parse(Console.ReadLine());

            int[] firstboxArr =
            {
                firstBoxX, firstBoxY, firstBoxZ
            };

            int[] secondBoxArr =
            {
                secondBoxX, secondBoxY, secondBoxZ
            };

            // determine which box is the smaller one
            int maxLengthFirstBox = firstboxArr.Max();
            int maxLengthSecondBox = secondBoxArr.Max();


            bool firstBoxIsSmaller = true;
            if (maxLengthFirstBox > maxLengthSecondBox)
            {
                firstBoxIsSmaller = false;
            }

            if (firstBoxIsSmaller)
            {
                for (int i = 0; i < 3; i++)
                {
                    int firstNumber = secondBoxArr[i];
                    for (int j = 0; j < 3; j++)
                    {
                        int secondNumber = secondBoxArr[j];
                        if (firstNumber != secondNumber)
                        {
                            for (int k = 0; k < 3; k++)
                            {
                                int thirdNumber = secondBoxArr[k];
                                if (secondNumber != thirdNumber && firstNumber != thirdNumber)
                                {
                                    if (firstBoxX < firstNumber && firstBoxY < secondNumber && firstBoxZ < thirdNumber)
                                    {
                                        Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})",
                                            firstBoxX, firstBoxY, firstBoxZ, firstNumber, secondNumber, thirdNumber);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    int firstNumber = firstboxArr[i];
                    for (int j = 0; j < 3; j++)
                    {
                        int secondNumber = firstboxArr[j];
                        if (firstNumber != secondNumber)
                        {
                            for (int k = 0; k < 3; k++)
                            {
                                int thirdNumber = firstboxArr[k];
                                if (secondNumber != thirdNumber && firstNumber != thirdNumber)
                                {
                                    if (secondBoxX < firstNumber && secondBoxY < secondNumber && secondBoxZ < thirdNumber)
                                    {
                                        Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})",
                                            secondBoxX, secondBoxY, secondBoxZ, firstNumber, secondNumber, thirdNumber);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
