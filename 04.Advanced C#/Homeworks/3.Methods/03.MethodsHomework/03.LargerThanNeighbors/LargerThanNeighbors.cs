namespace _03.LargerThanNeighbors
{
    using System;

    internal class LargerThanNeighbors
    {
        private static void Main()
        {
            int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };            
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(IsLargerThanNeighbors(numbers, i));
            }
        }

        private static bool IsLargerThanNeighbors(int[] arr, int position)
        {
            if (position > 0 && position < arr.Length - 1)
            {
                if (arr[position] > arr[position - 1] && arr[position] > arr[position + 1])
                {
                    return true;
                }

                return false;
            }
            else if (position == 0)
            {
                if (arr[position] > arr[position + 1])
                {
                    return true;
                }

                return false;
            }
            else
            {
                if (arr[position] > arr[position - 1])
                {
                    return true;
                }

                return false;
            }
        }
    }
}