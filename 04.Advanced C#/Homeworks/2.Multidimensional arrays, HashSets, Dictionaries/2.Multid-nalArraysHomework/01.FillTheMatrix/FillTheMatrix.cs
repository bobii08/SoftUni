namespace _01.FillTheMatrix
{
    using System;

    internal class FillTheMatrix
    {
        private static void Main()
        {
            Console.Write("Enter size of array: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            FillMatrixPatternA(matrix);
            PrintMatrix(matrix);
            Console.WriteLine();
            FillMatrixPatternB(matrix);
            PrintMatrix(matrix);
        }

        private static void FillMatrixPatternA(int[,] matrix)
        {
            int currentNumber = 1;
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    matrix[row, col] = currentNumber;
                    currentNumber++;
                }
            }
        }

        private static void FillMatrixPatternB(int[,] matrix)
        {
            int col = 0;
            int row = 0;
            int currentNum = 1;

            while (col < matrix.GetLength(1))
            {
                if (col % 2 == 0)
                {
                    while (row < matrix.GetLength(0))
                    {
                        matrix[row, col] = currentNum;
                        currentNum++;
                        row++;
                    }

                    col++;
                    row--;
                }
                else
                {
                    while (row >= 0)
                    {
                        matrix[row, col] = currentNum;
                        currentNum++;
                        row--;
                    }

                    row++;
                    col++;
                }
            }
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
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

        /*
        private static void FillMatrixPatternB2(int[,] matrix)
        {
            bool down = true;
            int currentNumber = 1;
            int row = 0;
            int col = 0;
            while (true)
            {
                if (down)
                {
                    matrix[row, col] = currentNumber;
                    currentNumber++;
                    row++;
                    if (row == matrix.GetLength(0))
                    {
                        if (col == matrix.GetLength(1) - 1)
                        {
                            return;
                        }

                        row--;
                        col++;
                        down = false;
                    }
                }
                else
                {
                    matrix[row, col] = currentNumber;
                    currentNumber++;
                    row--;
                    if (row == -1)
                    {
                        if (col == matrix.GetLength(1) - 1)
                        {
                            return;
                        }

                        row++;
                        col++;
                        down = true;
                    }
                }
            }
        }*/
         
    }
}