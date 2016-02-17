using System;
using System.Collections.Generic;

internal class PythagoreanNumbers
{
    private const int k = 3;

    private static int n;

    private static int[] freeValuesArr;

    private static int[] combinationsArr;

    private static int totalCount = 0;

    private static void Main()
    {
        n = int.Parse(Console.ReadLine());
        freeValuesArr = new int[n];
        for (int i = 0; i < n; i++)
        {
            freeValuesArr[i] = int.Parse(Console.ReadLine());
        }

        combinationsArr = new int[k];
        GenerateCombinationsWithRepetitions(0, 0);
        if (totalCount == 0)
        {
            Console.WriteLine("No");
        }
    }

    private static void GenerateCombinationsWithRepetitions(int index, int start)
    {
        if (index >= k)
        {
            var list = new List<int>();
            for (int i = 0; i < combinationsArr.Length; i++)
            {
                list.Add(freeValuesArr[combinationsArr[i]]);
            }

            list.Sort();
            int firstSide = (list[0] * list[0]) + (list[1] * list[1]);
            int secondSide = list[2] * list[2];
            if (firstSide == secondSide)
            {
                totalCount++;
                Console.WriteLine("{0}*{0} + {1}*{1} = {2}*{2}", list[0], list[1], list[2]);
            }

            return;
        }

        for (int i = start; i < n; i++)
        {
            combinationsArr[index] = i;
            GenerateCombinationsWithRepetitions(index + 1, i);
        }
    }
}