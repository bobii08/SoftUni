namespace _03.MatrixShuffling
{
    using System;

    internal class MatrixShuffling
    {
        private static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            string[,] matrix = new string[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = Console.ReadLine();
                }
            }

            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] arrOfStrings = command.Split();
                if (arrOfStrings.Length != 5 || arrOfStrings[0] != "swap")
                {
                    Console.WriteLine("Invalid input");
                    command = Console.ReadLine();
                    continue;
                }

                int row1 = int.Parse(arrOfStrings[1]);
                int col1 = int.Parse(arrOfStrings[2]);
                int row2 = int.Parse(arrOfStrings[3]);
                int col2 = int.Parse(arrOfStrings[4]);

                if (!(ValidateRow(row1, matrix) && 
                    ValidateCol(col1, matrix) &&
                    ValidateRow(row2, matrix) &&
                    ValidateCol(col2, matrix)))
                {
                    Console.WriteLine("Invalid input");
                    command = Console.ReadLine();
                    continue;
                }
                
                SwapValues(matrix, row1, col1, row2, col2);
                PrintMatrix(matrix);

                command = Console.ReadLine();
            }
        }

        private static void SwapValues(string[,] matrix, int row1, int col1, int row2, int col2)
        {
            string oldValue = matrix[row1, col1];
            matrix[row1, col1] = matrix[row2, col2];
            matrix[row2, col2] = oldValue;
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }

        private static bool ValidateRow(int row, string[,] matrix)
        {
            if (row < 0 || row >= matrix.GetLength(0))
            {
                return false;
            }

            return true;
        }

        private static bool ValidateCol(int col, string[,] matrix)
        {
            if (col < 0 || col >= matrix.GetLength(1))
            {
                return false;
            }

            return true;
        }
    }
}