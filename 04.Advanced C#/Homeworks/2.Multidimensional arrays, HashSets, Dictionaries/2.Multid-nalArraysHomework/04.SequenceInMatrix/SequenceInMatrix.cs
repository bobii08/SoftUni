namespace _04.SequenceInMatrix
{
    using System;
    using System.Collections.Generic;

    internal class SequenceInMatrix
    {
        private static void Main()
        {
            Console.Write("Rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Cols: ");
            int cols = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter {0} rows with {1} cols to fill the matrix", rows, cols);
            string[,] matrix = new string[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                string line = Console.ReadLine();
                string[] elements = line.Split();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = elements[col];
                }
            }

            string bestElement = string.Empty;
            int maxCount = 0;
            int currentCount = 0;
            // line
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    string currentElement = matrix[row, col];
                    currentCount = 1;
                    while (col + 1 < cols)
                    {
                        if (matrix[row, col + 1] == currentElement)
                        {
                            currentCount++;
                            col++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                        bestElement = currentElement;
                    }
                }
            }

            // column
            for (int col = 0; col < cols; col++)
            {
                for (int row = 0; row < rows; row++)
                {
                    string currentElement = matrix[row, col];
                    currentCount = 1;
                    while (row + 1 < rows)
                    {
                        if (matrix[row + 1, col] == currentElement)
                        {
                            currentCount++;
                            row++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                        bestElement = currentElement;
                    }
                }
            }

            // left diagonal
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    string currentElement = matrix[row, col];
                    currentCount = 1;
                    while (row + 1 < rows && col + 1 < cols)
                    {
                        if (matrix[row + 1, col + 1] == currentElement)
                        {
                            currentCount++;
                            row++;
                            col++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                        bestElement = currentElement;
                    }
                }
            }

            // right diagonal
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    string currentElement = matrix[row, col];
                    currentCount = 1;
                    while (row + 1 < rows && col - 1 > 0)
                    {
                        if (matrix[row + 1, col - 1] == currentElement)
                        {
                            currentCount++;
                            row++;
                            col--;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                        bestElement = currentElement;
                    }
                }
            }

            var result = new List<string>();
            for (int i = 0; i < maxCount; i++)
            {
                result.Add(bestElement);
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}