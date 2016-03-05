namespace _02.RadioactiveMutantVampireBunnies
{
    using System;
    using System.Linq;

    internal class RadioactiveMutantVampireBunnies
    {
        private static int diedRow = 0;

        private static int diedCol = 0;

        private static int escapedRow = 0;

        private static int escapedCol = 0;

        private static bool hasDied = false;
        
        private static void Main()
        {
            string rowColLine = Console.ReadLine();
            int[] rowAndCol =
                rowColLine.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int row = rowAndCol[0];
            int col = rowAndCol[1];

            char[,] matrix = new char[row, col];
            Player player = new Player();
            for (int i = 0; i < row; i++)
            {
                string lineStr = Console.ReadLine();
                for (int j = 0; j < lineStr.Length; j++)
                {
                    matrix[i, j] = lineStr[j];
                    if (matrix[i, j] == 'P')
                    {
                        player.Row = i;
                        player.Col = j;
                    }
                }
            }

            string moves = Console.ReadLine();

            for (int i = 0; i < moves.Length; i++)
            {
                char currentMove = moves[i];
                switch (currentMove)
                {
                    case 'L':
                        if (CheckHasEscaped(matrix, player.Row, player.Col - 1))
                        {
                            matrix[player.Row, player.Col] = '.';
                            escapedRow = player.Row;
                            escapedCol = player.Col;
                            MoveBunny(matrix);
                            PrintMatrix(matrix);
                            Console.WriteLine("won: {0} {1}", escapedRow, escapedCol);
                            Environment.Exit(1);
                        }

                        matrix[player.Row, player.Col] = '.';
                        player.Col -= 1;
                        MovePlayer(matrix, player);
                        break;
                    case 'R':
                        if (CheckHasEscaped(matrix, player.Row, player.Col + 1))
                        {
                            matrix[player.Row, player.Col] = '.';
                            escapedRow = player.Row;
                            escapedCol = player.Col;
                            MoveBunny(matrix);
                            PrintMatrix(matrix);
                            Console.WriteLine("won: {0} {1}", escapedRow, escapedCol);
                            Environment.Exit(1);
                        }

                        matrix[player.Row, player.Col] = '.';
                        player.Col += 1;
                        MovePlayer(matrix, player);
                        break;
                    case 'U':
                        if (CheckHasEscaped(matrix, player.Row - 1, player.Col))
                        {
                            matrix[player.Row, player.Col] = '.';
                            escapedRow = player.Row;
                            escapedCol = player.Col;
                            MoveBunny(matrix);
                            PrintMatrix(matrix);
                            Console.WriteLine("won: {0} {1}", escapedRow, escapedCol);
                            Environment.Exit(1);
                        }

                        matrix[player.Row, player.Col] = '.';
                        player.Row -= 1;
                        MovePlayer(matrix, player);
                        break;
                    case 'D':
                        if (CheckHasEscaped(matrix, player.Row + 1, player.Col))
                        {
                            matrix[player.Row, player.Col] = '.';
                            escapedRow = player.Row;
                            escapedCol = player.Col;
                            MoveBunny(matrix);
                            PrintMatrix(matrix);
                            Console.WriteLine("won: {0} {1}", escapedRow, escapedCol);
                            Environment.Exit(1);
                        }

                        matrix[player.Row, player.Col] = '.';
                        player.Row += 1;
                        MovePlayer(matrix, player);
                        break;
                }
            }
        }

        static void MoveBunny(char[,] matrix)
        {
            bool[,] boolMatrix = new bool[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 'B')
                    {
                        boolMatrix[i, j] = true;
                    }
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (boolMatrix[row, col])
                    {
                        if (ValidRow(matrix, row - 1))
                        {
                            if (matrix[row - 1, col] == 'P')
                            {
                                diedRow = row - 1;
                                diedCol = col;
                                hasDied = true;
                            }

                            matrix[row - 1, col] = 'B';
                        }

                        if (ValidRow(matrix, row + 1))
                        {
                            if (matrix[row + 1, col] == 'P')
                            {
                                diedRow = row + 1;
                                diedCol = col;
                                hasDied = true;
                            }

                            matrix[row + 1, col] = 'B';
                        }

                        if (ValidCol(matrix, col - 1))
                        {
                            if (matrix[row, col - 1] == 'P')
                            {
                                diedRow = row;
                                diedCol = col - 1;
                                hasDied = true;
                            }

                            matrix[row, col - 1] = 'B';
                        }

                        if (ValidCol(matrix, col + 1))
                        {
                            if (matrix[row, col + 1] == 'P')
                            {
                                diedRow = row;
                                diedCol = col + 1;
                                hasDied = true;
                            }

                            matrix[row, col + 1] = 'B';
                        }
                    }
                }
            }
        }

        private static void MovePlayer(char[,] matrix, Player player)
        {
            if (matrix[player.Row, player.Col] == '.')
            {
                matrix[player.Row, player.Col] = 'P';                
            }

            if (CheckIfBunny(matrix, player))
            {
                diedRow = player.Row;
                diedCol = player.Col;
                MoveBunny(matrix);
                PrintMatrix(matrix);
                Console.WriteLine("dead: {0} {1}", diedRow, diedCol);
                Environment.Exit(1);
            }
            else
            {
                MoveBunny(matrix);
                if (hasDied)
                {
                    PrintMatrix(matrix);
                    Console.WriteLine("dead: {0} {1}", diedRow, diedCol);
                    Environment.Exit(1);
                }
            }
        }

        static bool CheckHasEscaped(char[,] matrix, int row, int col)
        {
            if (row < 0 || row >= matrix.GetLength(0) || col < 0 || col >= matrix.GetLength(1))
            {
                return true;
            }

            return false;
        }

        static void PrintMatrix(char[,] matrix)
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

        struct Player
        {
            public int Row { get; set; }
            public int Col { get; set; }
        }

        static bool CheckIfBunny(char[,] matrix, Player player)
        {
            if (matrix[player.Row, player.Col] == 'B')
            {
                return true;
            }

            return false;
        }

        static bool ValidRow(char[,] matrix, int row)
        {
            if (row < 0 || row >= matrix.GetLength(0))
            {
                return false;
            }

            return true;
        }

        static bool ValidCol(char[,] matrix, int col)
        {
            if (col < 0 || col >= matrix.GetLength(1))
            {
                return false;
            }

            return true;
        }
    }
}