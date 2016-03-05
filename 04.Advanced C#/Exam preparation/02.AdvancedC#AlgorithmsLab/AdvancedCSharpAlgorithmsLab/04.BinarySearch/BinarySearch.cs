using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BinarySearch
{
    class BinarySearch
    {
        static void Main()
        {
            int[] sortedNumbers =
                Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            int num = int.Parse(Console.ReadLine());
            int index = LinearSearch(sortedNumbers, num);
            index = BinarySearchAlgorithm(sortedNumbers, num);
            Console.WriteLine(index);
        }

        static int BinarySearchAlgorithm(int[] sortedArray, int num)
        {
            int min = 0;
            int max = sortedArray.Length - 1;
            int midIndex = 0;
            while (min < max)
            {
                midIndex = (max + min) / 2;
                if (sortedArray[midIndex] == num)
                {
                    if (midIndex > 0)
                    {
                        if (sortedArray[midIndex] == sortedArray[midIndex - 1])
                        {
                            max = midIndex - 1;
                            if (min == max)
                            {
                                return min;
                            }
                        }
                        else
                        {
                            return midIndex;
                        }
                    }
                    else
                    {
                        return midIndex;
                    }
                }
                else if (sortedArray[midIndex] < num)
                {
                    min = midIndex + 1;
                }
                else
                {
                    max = midIndex - 1;
                }
            }

            return -1;
        }

        static int LinearSearch(int[] sortedArray, int num)
        {
            for (int i = 0; i < sortedArray.Length; i++)
            {
                if (sortedArray[i] == num)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
