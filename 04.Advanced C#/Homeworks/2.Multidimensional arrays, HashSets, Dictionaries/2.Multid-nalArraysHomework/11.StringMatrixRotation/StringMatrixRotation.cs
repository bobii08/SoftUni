namespace _11.StringMatrixRotation
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    internal class StringMatrixRotation
    {
        private static void Main()
        {
            string degreesStr = Console.ReadLine();
            string pattern = @"[0-9]+";
            Regex regex = new Regex(pattern);
            int degrees = int.Parse(regex.Match(degreesStr).ToString());
            List<string> inputLines = new List<string>();
            int maxLengthOfString = 0;
            string currentLine = Console.ReadLine();
            while (currentLine != "END")
            {
                if (string.IsNullOrEmpty(currentLine))
                {
                    break;
                }

                if (maxLengthOfString < currentLine.Length)
                {
                    maxLengthOfString = currentLine.Length;
                }

                inputLines.Add(currentLine);
                currentLine = Console.ReadLine();
            }

            char[,] matrix = new char[inputLines.Count, maxLengthOfString];

            for (int i = 0; i < inputLines.Count; i++)
            {
                string currentString = inputLines[i];
                for (int j = 0; j < currentString.Length; j++)
                {
                    matrix[i, j] = currentString[j];
                }
            }

            matrix = RotateMatrix(matrix, degrees);
            PrintMatrix(matrix);
        }

        private static char[,] RotateMatrix(char[,] matrix, int degrees)
        {
            char[,] resultMatrix;

            while (degrees % 10 == 0 && degrees != 0)
            {
                degrees /= 10;
            }
            
            int resultMatrixRow = 0;
            int resultMatrixCol = 0;
            switch ((degrees / 9) % 4)
            {
                case 1:
                    resultMatrix = new char[matrix.GetLength(1), matrix.GetLength(0)];
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                        {
                            resultMatrix[resultMatrixRow, resultMatrixCol] = matrix[row, col];
                            resultMatrixCol++;
                        }

                        resultMatrixCol = 0;
                        resultMatrixRow++;
                    }

                    return resultMatrix;
                case 2:
                    resultMatrix = new char[matrix.GetLength(0), matrix.GetLength(1)];
                    for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                    {
                        for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                        {
                            resultMatrix[resultMatrixRow, resultMatrixCol] = matrix[row, col];
                            resultMatrixCol++;
                        }

                        resultMatrixCol = 0;
                        resultMatrixRow++;
                    }

                    return resultMatrix;
                case 3:
                    resultMatrix = new char[matrix.GetLength(1), matrix.GetLength(0)];
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            resultMatrix[resultMatrixRow, resultMatrixCol] = matrix[row, col];
                            resultMatrixCol++;
                        }

                        resultMatrixCol = 0;
                        resultMatrixRow++;
                    }

                    return resultMatrix;
                default:
                    return matrix;
            }
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}