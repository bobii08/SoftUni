using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.OddEvenElements
{
    class OddEvenElements
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] numbersStr = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}",
                    "No", "No", "No", "No", "No", "No");
                return;
            }

            int p = 0;
            double[] numbers = new double[numbersStr.Length];
            int currentLength = 0;
            foreach (var str in numbersStr)
            {
                double currentNum = 0;
                if (double.TryParse(str, out currentNum))
                {
                    numbers[p] = currentNum;
                    currentLength++;
                }
                if (currentLength == p)
                {
                    Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}",
                    "No", "No", "No", "No", "No", "No");
                    return;
                }
                p++;
            }

            double sumOddElements = 0;
            double minOddElements = double.MaxValue;
            double maxOddElements = double.MinValue;
            double sumEvenElements = 0;
            double minEvenElements = double.MaxValue;
            double maxEvenElements = double.MinValue;

            if (numbersStr.Length == 0)
            {
                Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}",
                    "No", "No", "No", "No", "No", "No");
                return;
            }

            if (numbers.Length == 1)
            {
                sumOddElements += numbers[0];
                minOddElements = numbers[0];
                maxOddElements = numbers[0];
                Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}",
                sumOddElements, minOddElements, maxOddElements, "No", "No", "No");
                return;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                double currentNumber = numbers[i];
                if (i % 2 == 0)
                {
                    sumOddElements += currentNumber;
                    if (currentNumber < minOddElements)
                    {
                        minOddElements = currentNumber;
                    }
                    if (currentNumber > maxOddElements)
                    {
                        maxOddElements = currentNumber;
                    }
                }
                else
                {
                    sumEvenElements += currentNumber;
                    if (currentNumber < minEvenElements)
                    {
                        minEvenElements = currentNumber;
                    }
                    if (currentNumber > maxEvenElements)
                    {
                        maxEvenElements = currentNumber;
                    }
                }
            }

            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}",
                sumOddElements, minOddElements, maxOddElements, sumEvenElements, minEvenElements, maxEvenElements);
        }
    }
}
