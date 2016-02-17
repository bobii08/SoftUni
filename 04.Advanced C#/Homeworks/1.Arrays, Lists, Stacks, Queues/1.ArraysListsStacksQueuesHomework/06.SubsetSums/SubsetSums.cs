namespace _06.SubsetSums
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class SubsetSums
    {
        private static readonly List<List<int>> UniqueLists = new List<List<int>>();

        private static int totalMatchingSubsets = 0;

        private static void Gen01(int index, int[] arr, int[] nums, int sum)
        {
            if (index == arr.Length)
            {
                int currentSum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == 1)
                    {
                        currentSum += nums[i];
                    }
                }

                if (currentSum == sum && arr.Contains(1))
                {
                    var tempResult = new List<int>();
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] == 1)
                        {
                            tempResult.Add(nums[i]);
                        }
                    }

                    var sortedResult = new List<int>(tempResult);
                    sortedResult.Sort();
                    if (UniqueLists.Count == 0)
                    {
                        totalMatchingSubsets++;
                        UniqueLists.Add(sortedResult);
                        Console.WriteLine(string.Join(" + ", tempResult) + " = " + sum);
                    }
                    else
                    {
                        bool existsInUniqueLists = false;
                        for (int i = 0; i < UniqueLists.Count; i++)
                        {
                            var currentList = UniqueLists[i];
                            if (currentList.Count != sortedResult.Count)
                            {
                                continue;
                            }

                            int numberOfMatches = 0;
                            for (int j = 0; j < currentList.Count; j++)
                            {
                                if (currentList[j] == sortedResult[j])
                                {
                                    numberOfMatches++;
                                }
                                else
                                {
                                    break;
                                }
                            }

                            if (numberOfMatches == currentList.Count)
                            {
                                existsInUniqueLists = true;
                                break;
                            }
                        }

                        if (!existsInUniqueLists)
                        {
                            totalMatchingSubsets++;
                            UniqueLists.Add(sortedResult);
                            Console.WriteLine(string.Join(" + ", tempResult) + " = " + sum);
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i <= 1; i++)
                {
                    arr[index] = i;
                    Gen01(index + 1, arr, nums, sum);
                }
            }
        }

        private static void Main()
        {
            int sum = int.Parse(Console.ReadLine());
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] arr = new int[nums.Length];
            Gen01(0, arr, nums, sum);
            if (totalMatchingSubsets == 0)
            {
                Console.WriteLine("No matching subsets.");
            }
        }
    }
}