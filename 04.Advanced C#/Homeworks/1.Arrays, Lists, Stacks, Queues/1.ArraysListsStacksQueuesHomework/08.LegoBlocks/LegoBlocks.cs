namespace _08.LegoBlocks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class LegoBlocks
    {
        private static readonly List<List<int>> ListOfRows = new List<List<int>>();

        private static int[][] firstJaggedArray;

        private static int[][] secondJaggedArray;

        private static void InitializeJaggedArray(int n, out int[][] jaggedArray)
        {
            for (int row = 0; row < n; row++)
            {
                ListOfRows.Add(new List<int>());
                string currentLine = Console.ReadLine().Trim();
                int[] numbers =
                    currentLine.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
                ListOfRows[row].AddRange(numbers);
            }

            jaggedArray = new int[ListOfRows.Count][];
            for (int row = 0; row < jaggedArray.Length; row++)
            {
                jaggedArray[row] = new int[ListOfRows[row].Count];
                for (int col = 0; col < ListOfRows[row].Count; col++)
                {
                    int numberToAdd = ListOfRows[row][col];
                    jaggedArray[row][col] = numberToAdd;
                }
            }

            ListOfRows.Clear();
        }

        private static void Swap<T>(ref T v1, ref T v2)
        {
            T oldValue = v1;
            v1 = v2;
            v2 = oldValue;
        }

        private static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            InitializeJaggedArray(n, out firstJaggedArray);
            InitializeJaggedArray(n, out secondJaggedArray);

            for (int row = 0; row < secondJaggedArray.Length; row++)
            {
                int currentRowLength = secondJaggedArray[row].Length;

                for (int col = 0; col < currentRowLength / 2; col++)
                {
                    Swap(ref secondJaggedArray[row][col], ref secondJaggedArray[row][currentRowLength - col - 1]);
                }
            }

            int totalCellsOnFirstRow = firstJaggedArray[0].Length + secondJaggedArray[0].Length;
            bool fitArrays = true;
            for (int row = 1; row < firstJaggedArray.Length; row++)
            {
                if ((firstJaggedArray[row].Length + secondJaggedArray[row].Length) != totalCellsOnFirstRow)
                {
                    fitArrays = false;
                    break;
                }
            }

            List<List<int>> finalResult = new List<List<int>>();
            if (fitArrays)
            {
                for (int row = 0; row < n; row++)
                {
                    finalResult.Add(new List<int>());
                    for (int colInFirstArray = 0; colInFirstArray < firstJaggedArray[row].Length; colInFirstArray++)
                    {
                        finalResult[row].Add(firstJaggedArray[row][colInFirstArray]);
                    }

                    for (int colInSecondArray = 0; colInSecondArray < secondJaggedArray[row].Length; colInSecondArray++)
                    {
                        finalResult[row].Add(secondJaggedArray[row][colInSecondArray]);
                    }
                }

                for (int row = 0; row < finalResult.Count; row++)
                {
                    Console.WriteLine("[" + string.Join(", ", finalResult[row]) + "]");
                }
            }
            else
            {
                int totalNumberOfCells = 0;
                for (int row = 0; row < firstJaggedArray.Length; row++)
                {
                    totalNumberOfCells += firstJaggedArray[row].Length;
                    totalNumberOfCells += secondJaggedArray[row].Length;
                }

                Console.WriteLine("The total number of cells is: " + totalNumberOfCells);
            }
        }
    }
}