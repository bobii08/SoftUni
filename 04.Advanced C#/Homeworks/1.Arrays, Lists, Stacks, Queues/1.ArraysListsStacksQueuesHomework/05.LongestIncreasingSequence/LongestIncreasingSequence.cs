namespace _05.LongestIncreasingSequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class LongestIncreasingSequence
    {
        private static void Main()
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var longestSequence = new List<int>();
            var currentSequence = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int firstElement = nums[i];
                currentSequence.Clear();
                currentSequence.Add(firstElement);
                while (i < nums.Length)
                {
                    if (i + 1 == nums.Length)
                    {
                        Console.WriteLine(string.Join(" ", currentSequence));
                        break;
                    }

                    if (nums[i + 1] > nums[i])
                    {
                        currentSequence.Add(nums[i + 1]);
                        i++;
                    }
                    else
                    {
                        Console.WriteLine(string.Join(" ", currentSequence));
                        break;
                    }
                }

                if (currentSequence.Count > longestSequence.Count)
                {
                    longestSequence.Clear();
                    longestSequence.AddRange(currentSequence);

                    // currentSequence.ForEach(e => longestSequence.Add(e)); // -> also possible
                }
            }

            Console.WriteLine("Longest: {0}", string.Join(" ", longestSequence));
        }
    }
}