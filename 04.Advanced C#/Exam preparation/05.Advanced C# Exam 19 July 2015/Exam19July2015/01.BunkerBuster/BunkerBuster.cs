namespace _01.BunkerBuster
{
    using System;
    using System.Linq;

    internal class BunkerBuster
    {
        private static void Main()
        {
            int[] rowsAndCols =
                Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            int row = rowsAndCols[0];
            int col = rowsAndCols[1];

            int[,] matrix = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                string[] cols = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < cols.Length; j++)
                {
                    matrix[i, j] = int.Parse(cols[j]);
                }
            }

            string shot = Console.ReadLine();
            while (shot != "cease fire!")
            {
                string[] args = shot.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int currRow = int.Parse(args[0]);
                int currCol = int.Parse(args[1]);
                char force = char.Parse(args[2]);

                Bombard(matrix, currRow, currCol, force);
                shot = Console.ReadLine();
            }

            int cellsDestroyed = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] <= 0)
                    {
                        cellsDestroyed++;
                    }
                }
            }

            Console.WriteLine("Destroyed bunkers: {0}", cellsDestroyed);
            Console.WriteLine("Damage done: {0:p1}", (double)cellsDestroyed / (row * col));
        }

        private static void Bombard(int[,] matrix, int row, int col, int force)
        {
            matrix[row, col] -= force;
            int halfForce = (int)Math.Ceiling((double)force / 2);
            if (IsValidRowAndCol(matrix, row - 1, col - 1))
            {
                matrix[row - 1, col - 1] -= halfForce;
            }

            if (IsValidRowAndCol(matrix, row - 1, col))
            {
                matrix[row - 1, col] -= halfForce;
            }

            if (IsValidRowAndCol(matrix, row - 1, col + 1))
            {
                matrix[row - 1, col + 1] -= halfForce;
            }

            if (IsValidRowAndCol(matrix, row, col + 1))
            {
                matrix[row, col + 1] -= halfForce;
            }

            if (IsValidRowAndCol(matrix, row + 1, col + 1))
            {
                matrix[row + 1, col + 1] -= halfForce;
            }

            if (IsValidRowAndCol(matrix, row + 1, col))
            {
                matrix[row + 1, col] -= halfForce;
            }

            if (IsValidRowAndCol(matrix, row + 1, col - 1))
            {
                matrix[row + 1, col - 1] -= halfForce;
            }

            if (IsValidRowAndCol(matrix, row, col - 1))
            {
                matrix[row, col - 1] -= halfForce;
            }
        }

        private static bool IsValidRowAndCol(int[,] matrix, int row, int col)
        {
            if (row < 0 || row >= matrix.GetLength(0) || col < 0 || col >= matrix.GetLength(1))
            {
                return false;
            }

            return true;
        }
    }
}