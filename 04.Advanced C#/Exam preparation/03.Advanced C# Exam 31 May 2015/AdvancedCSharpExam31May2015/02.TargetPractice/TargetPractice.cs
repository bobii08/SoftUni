namespace _02.TargetPractice
{
    using System;
    using System.Linq;

    internal class TargetPractice
    {
        private static void Main()
        {
            int[] rowAndCol =
                Console.ReadLine()
                    .Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            int matrixRow = rowAndCol[0];
            int matrixCol = rowAndCol[1];
            string snake = Console.ReadLine();
            char[,] matrix = new char[matrixRow, matrixCol];

            FillMatrix(matrix, matrixRow, matrixCol, snake);

            int[] indices = Console.ReadLine()
                    .Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            int attackRow = indices[0];
            int attackCol = indices[1];
            int radius = indices[2];

            for (int i = 0; i < matrixRow; i++)
            {
                for (int j = 0; j < matrixCol; j++)
                {
                    if (IsCellInside(attackRow, attackCol, i, j, radius))
                    {
                        matrix[i, j] = ' ';
                    }
                }
            }

            FallDown(matrix);

            PrintMatrix(matrix);
        }

        static void FallDown(char[,] matrix)
        {
            bool hasChanged = true;
            while (hasChanged)
            {
                hasChanged = false;
                for (int row = matrix.GetLength(0) - 2; row >= 0; row--)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        char currentSymbol = matrix[row, col];
                        char downSymbol = matrix[row + 1, col];
                        if (downSymbol == ' ' && currentSymbol != ' ')
                        {
                            hasChanged = true;
                            matrix[row + 1, col] = matrix[row, col];
                            matrix[row, col] = ' ';
                        }
                    }
                }
            }
        }

        static bool IsCellInside(int attackRow, int attackCol, int rowY, int colX, int radius)
        {
            double radiusToCheck =
                Math.Sqrt(Math.Abs(rowY - attackRow) * Math.Abs(rowY - attackRow) +
                Math.Abs(attackCol - colX) * Math.Abs(attackCol - colX));

            if (radiusToCheck > radius)
            {
                return false;
            }

            return true;
        }

        static void FillMatrix(char[,] matrix, int matrixRow, int matrixCol, string snake)
        {
            int col = matrixCol - 1;
            int snakeIndex = 0;
            bool left = true;
            bool right = false;
            for (int row = matrixRow - 1; row >= 0; row--)
            {
                while (true)
                {
                    if (left)
                    {
                        if (snakeIndex == snake.Length)
                        {
                            snakeIndex = 0;
                        }

                        matrix[row, col] = snake[snakeIndex];
                        col--;
                        snakeIndex++;
                        if (col == -1)
                        {
                            col = 0;
                            left = false;
                            right = true;
                            break;
                        }
                    }

                    if (right)
                    {
                        if (snakeIndex == snake.Length)
                        {
                            snakeIndex = 0;
                        }

                        matrix[row, col] = snake[snakeIndex];
                        col++;
                        snakeIndex++;
                        if (col == matrixCol)
                        {
                            col = matrixCol - 1;
                            left = true;
                            right = false;
                            break;
                        }
                    }
                }
            }
        }

        static void PrintMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}