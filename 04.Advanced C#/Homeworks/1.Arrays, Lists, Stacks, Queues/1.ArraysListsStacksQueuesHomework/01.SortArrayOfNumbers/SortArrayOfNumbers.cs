namespace _01.SortArrayOfNumbers
{
    using System;
    using System.Linq;

    internal class SortArrayOfNumbers
    {
        private static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        int oldValue = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = oldValue;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}