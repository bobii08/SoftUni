namespace _06.NumberCalculations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class NumberCalculations
    {
        private static void Main()
        {
            Console.Write("Enter a sequence of double numbers: ");
            List<double> doubleNumbers = Console.ReadLine().Split().Select(double.Parse).ToList();
            Console.Write("Enter a sequence of decimal numbers: ");
            List<decimal> decimalNumbers = Console.ReadLine().Split().Select(decimal.Parse).ToList();

            Console.WriteLine("double numbers");
            CalculateMinimumMaximumAverageSumAndProduct(doubleNumbers);
            Console.WriteLine("decimal numbers");
            CalculateMinimumMaximumAverageSumAndProduct(decimalNumbers);
        }

        private static void CalculateMinimumMaximumAverageSumAndProduct(List<decimal> numbers)
        {
            decimal min = decimal.MaxValue;
            decimal max = decimal.MinValue;
            decimal sum = 0;
            decimal product = 1;

            for (int i = 0; i < numbers.Count; i++)
            {
                decimal currentNumber = numbers[i];
                if (currentNumber > max)
                {
                    max = currentNumber;
                }

                if (currentNumber < min)
                {
                    min = currentNumber;
                }

                sum += currentNumber;
                product *= currentNumber;
            }

            Console.WriteLine("Minimum number: " + min);
            Console.WriteLine("Maximum number: " + max);
            Console.WriteLine("Average: " + (sum / numbers.Count));
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Product: " + product);
        }

        private static void CalculateMinimumMaximumAverageSumAndProduct(List<double> numbers)
        {
            double min = double.MaxValue;
            double max = double.MinValue;
            double sum = 0;
            double product = 1;

            for (int i = 0; i < numbers.Count; i++)
            {
                double currentNumber = numbers[i];
                if (currentNumber > max)
                {
                    max = currentNumber;
                }

                if (currentNumber < min)
                {
                    min = currentNumber;
                }

                sum += currentNumber;
                product *= currentNumber;
            }

            Console.WriteLine("Minimum number: " + min);
            Console.WriteLine("Maximum number: " + max);
            Console.WriteLine("Average: " + (sum / numbers.Count));
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Product: " + product);
        }
    }
}