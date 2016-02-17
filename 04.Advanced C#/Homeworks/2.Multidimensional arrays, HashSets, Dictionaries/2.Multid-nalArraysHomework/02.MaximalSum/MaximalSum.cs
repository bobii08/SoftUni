namespace _02.MaximalSum
{
    using System;
    using System.Linq;

    internal class MaximalSum
    {
        private static void Main()
        {
            int[] rowAndCol = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = rowAndCol[0];
            int cols = rowAndCol[1];
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                int[] currentCol = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < currentCol.Length; col++)
                {
                    matrix[row, col] = currentCol[col];
                }
            }

            int maxSum = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;
            if (rows >= 3 && cols >= 3)
            {
                for (int row = 0; row < matrix.GetLength(0) - 2; row++)
                {
                    for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                    {
                        int currentSum = 0;
                        for (int currentRow = row; currentRow < row + 3; currentRow++)
                        {
                            for (int currentCol = col; currentCol < col + 3; currentCol++)
                            {
                                currentSum += matrix[currentRow, currentCol];
                            }
                        }

                        if (currentSum > maxSum)
                        {
                            maxSum = currentSum;
                            bestRow = row;
                            bestCol = col;
                        }
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Sum = " + maxSum);
                for (int row = bestRow; row < bestRow + 3; row++)
                {
                    for (int col = bestCol; col < bestCol + 3; col++)
                    {
                        if (matrix[row, col] < 10)
                        {
                            Console.Write(matrix[row, col] + "  ");
                        }
                        else
                        {
                            Console.Write(matrix[row, col] + " ");
                        }
                    }

                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("The matrix is not big enough!");
            }
        }
    }
}