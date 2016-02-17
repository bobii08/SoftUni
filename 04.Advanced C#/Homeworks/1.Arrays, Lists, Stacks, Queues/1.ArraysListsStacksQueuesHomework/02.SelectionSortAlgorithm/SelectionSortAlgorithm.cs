namespace _02.SelectionSortAlgorithm
{
    using System;
    using System.Linq;

    internal class SelectionSortAlgorithm
    {
        private static void Main()
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minNumber = arr[i];
                int j = i + 1;
                int index = 0;
                while (j < arr.Length)
                {
                    if (arr[j] < minNumber)
                    {
                        minNumber = arr[j];
                        index = j;
                    }

                    j++;
                }

                if (arr[i] != minNumber)
                {
                    int oldValue = arr[i];
                    arr[i] = arr[index];
                    arr[index] = oldValue;
                }
            }

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}