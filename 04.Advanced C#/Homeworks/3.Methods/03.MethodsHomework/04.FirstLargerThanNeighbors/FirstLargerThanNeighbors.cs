namespace _04.FirstLargerThanNeighbors
{
    using System;

    internal class FirstLargerThanNeighbors
    {
        private static void Main()
        {
            int[] sequenceOne = { 1, 3, 4, 5, 1, 0, 5 };
            int[] sequenceTwo = { 1, 2, 3, 4, 5, 6, 6 };
            int[] sequenceThree = { 1, 1, 1 };
            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbors(sequenceOne));
            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbors(sequenceTwo));
            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbors(sequenceThree));
        }

        private static int GetIndexOfFirstElementLargerThanNeighbors(int[] arr)
        {
            for (int index = 0; index < arr.Length; index++)
            {
                if (index > 0 && index < arr.Length - 1)
                {
                    if (arr[index] > arr[index - 1] && arr[index] > arr[index + 1])
                    {
                        return index;
                    }
                }
            }

            return -1;
        }
    }
}