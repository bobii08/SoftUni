namespace _03.FindMinMaxAverage
{
    using System;
    using System.Collections.Generic;

    internal class FindMinMaxAverage
    {
        private static void Main()
        {
            string[] numbers = Console.ReadLine().Split(' ');

            var roundNumbers = new List<int>();
            var floatingPointNumbers = new List<double>();

            for (int i = 0; i < numbers.Length; i++)
            {
                double currentNumber = double.Parse(numbers[i]);
                if (currentNumber % 1 == 0)
                {
                    roundNumbers.Add((int)currentNumber);
                }
                else
                {
                    floatingPointNumbers.Add(currentNumber);
                }
            }

            double minFloatingPointNum = double.MaxValue;
            double maxFloatingPointNum = double.MinValue;
            double sumFloatingPointNums = 0;
            foreach (var num in floatingPointNumbers)
            {
                if (num < minFloatingPointNum)
                {
                    minFloatingPointNum = num;
                }

                if (num > maxFloatingPointNum)
                {
                    maxFloatingPointNum = num;
                }

                sumFloatingPointNums += num;
            }

            int minRoundNum = int.MaxValue;
            int maxRoundNum = int.MinValue;
            int sumRoundNums = 0;
            foreach (var num in roundNumbers)
            {
                if (num < minRoundNum)
                {
                    minRoundNum = num;
                }

                if (num > maxRoundNum)
                {
                    maxRoundNum = num;
                }

                sumRoundNums += num;
            }

            Console.WriteLine(
                "[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:0.00}", 
                string.Join(", ", floatingPointNumbers), 
                minFloatingPointNum, 
                maxFloatingPointNum, 
                sumFloatingPointNums, 
                sumFloatingPointNums / floatingPointNumbers.Count);
            Console.WriteLine(
                "[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:0.00}", 
                string.Join(", ", roundNumbers), 
                minRoundNum, 
                maxRoundNum, 
                sumRoundNums, 
                (double)sumRoundNums / roundNumbers.Count);
        }
    }
}