namespace _10.Plus_Remove
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal class PlusRemove
    {
        private static void Main()
        {
            var inputLinesList = new List<string>();
            while (true)
            {
                string currentLine = Console.ReadLine();
                if (currentLine == "END")
                {
                    break;
                }

                inputLinesList.Add(currentLine);
            }

            char[][] jaggedArray = new char[inputLinesList.Count][];
            bool[][] boolJaggedArray = new bool[jaggedArray.Length][];
            for (int i = 0; i < inputLinesList.Count; i++)
            {
                string currentLine = inputLinesList[i];
                jaggedArray[i] = new char[currentLine.Length];
                boolJaggedArray[i] = new bool[currentLine.Length];
                for (int j = 0; j < currentLine.Length; j++)
                {
                    jaggedArray[i][j] = currentLine[j];
                }
            }

            for (int row = 1; row < jaggedArray.Length - 1; row++)
            {
                for (int col = 1; col < jaggedArray[row].Length - 1; col++)
                {
                    char currentChar = jaggedArray[row][col];
                    if (IsInRange(row - 1, col, jaggedArray) &&
                        IsInRange(row, col + 1, jaggedArray) &&
                        IsInRange(row + 1, col, jaggedArray) && 
                        IsInRange(row, col - 1, jaggedArray) &&
                        Match(row - 1, col, jaggedArray, currentChar) &&
                        Match(row + 1, col, jaggedArray, currentChar) &&
                        Match(row, col - 1, jaggedArray, currentChar) &&
                        Match(row, col + 1, jaggedArray, currentChar))
                    {
                        boolJaggedArray[row][col] = true;
                        boolJaggedArray[row - 1][col] = true;
                        boolJaggedArray[row][col + 1] = true;
                        boolJaggedArray[row + 1][col] = true;
                        boolJaggedArray[row][col - 1] = true;
                    }
                }
            }

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                var currentLine = new StringBuilder();
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    if (!boolJaggedArray[row][col])
                    {
                        currentLine.Append(jaggedArray[row][col]);
                    }
                }

                Console.WriteLine(currentLine.ToString());
            }
        }

        private static bool IsInRange(int row, int col, char[][] jaggedArray)
        {
            if (row < jaggedArray.Length && col < jaggedArray[row].Length)
            {
                return true;
            }

            return false;
        }

        private static bool Match(int row, int col, char[][] jaggedArray, char ch)
        {
            if (ch.ToString().ToLower()[0] == jaggedArray[row][col].ToString().ToLower()[0])
            {
                return true;
            }

            return false;
        }
    }
}