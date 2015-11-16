using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BiggestTriple
{
    class BiggestTriple
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] numbers = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] arr = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                arr[i] = int.Parse(numbers[i]);
            }

            string currentSequence = null;
            string sequenceWithHighestSum = null;
            int biggestSum = int.MinValue;
            int currentSum = 0;

            for (int i = 0; i < arr.Length; i += 3)
            {
                int firstNum = arr[i];
                if (i + 2 < arr.Length)
                {
                    int secondNum = arr[i + 1];
                    int thirdNum = arr[i + 2];
                    currentSequence = firstNum + " " + secondNum + " " + thirdNum;
                    currentSum = firstNum + secondNum + thirdNum;
                    if (currentSum > biggestSum)
                    {
                        biggestSum = currentSum;
                        sequenceWithHighestSum = currentSequence;
                    }
                }
                else if (i + 2 == arr.Length)
                {
                    int secondNum = arr[i + 1];
                    currentSequence = firstNum + " " + secondNum;
                    currentSum = firstNum + secondNum;
                    if (currentSum > biggestSum)
                    {
                        biggestSum = currentSum;
                        sequenceWithHighestSum = currentSequence;
                    }
                }
                else
                {
                    currentSequence = firstNum.ToString();
                    currentSum = firstNum;
                    if (currentSum > biggestSum)
                    {
                        biggestSum = currentSum;
                        sequenceWithHighestSum = currentSequence;
                    }
                }
            }

            Console.WriteLine(sequenceWithHighestSum);
        }
    }
}
