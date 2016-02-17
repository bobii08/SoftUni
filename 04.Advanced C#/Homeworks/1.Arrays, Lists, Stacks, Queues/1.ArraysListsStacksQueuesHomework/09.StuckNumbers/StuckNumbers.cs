namespace _09.StuckNumbers
{
    using System;
    using System.Linq;

    internal class StuckNumbers
    {
        private const int k = 4;
        
        private static int stuckNumbersCount = 0;
        
        private static void Main()
        {
            int numberOfElements = int.Parse(Console.ReadLine());
            string inputLine = Console.ReadLine();
            if (numberOfElements <= 3)
            {
                Console.WriteLine("No");
                return;
            }
            
            int[] numbersInt =
                inputLine.Trim()
                    .Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            int[] arr = new int[k];
            GenerateVariationsWithNoRepetitions(0, numberOfElements, arr, numbersInt);
            if (stuckNumbersCount == 0)
            {
                Console.WriteLine("No");
            }
        }

        private static void GenerateVariationsWithNoRepetitions(int index, int numberOfElements, int[] variationsArr, int[] freeValuesArr)
        {
            if (index >= k)
            {
                if ((variationsArr[0] + string.Empty + variationsArr[1]) == (variationsArr[2] + string.Empty + variationsArr[3]))
                {
                    Console.WriteLine(variationsArr[0] + "|" + variationsArr[1] + "==" + variationsArr[2] + "|" + variationsArr[3]);
                    stuckNumbersCount++;
                }

                return;
            }

            for (int i = index; i < numberOfElements; i++)
            {
                variationsArr[index] = freeValuesArr[i];
                Swap(ref freeValuesArr[i], ref freeValuesArr[index]);
                GenerateVariationsWithNoRepetitions(index + 1, numberOfElements, variationsArr, freeValuesArr);
                Swap(ref freeValuesArr[i], ref freeValuesArr[index]);
            }
        }

        private static void Swap(ref int v1, ref int v2)
        {
            int old = v1;
            v1 = v2;
            v2 = old;
        }
    }
}