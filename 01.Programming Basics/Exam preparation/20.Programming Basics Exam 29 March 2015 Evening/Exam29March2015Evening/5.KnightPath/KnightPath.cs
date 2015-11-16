using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.KnightPath
{
    class KnightPath
    {
        private static int startingRowOfMatrix = 0;
        private static int startingColOfMatrix = 7;
        private static char[,] matrix = new char[8, 8];

        static void FillMatrix()
        {
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    matrix[row, col] = '0';
                }
            }
        }

        static bool CheckMove(string move, int numberOfMoves)
        {
            bool canProceed = true;
            switch (move)
            {
                case "left":
                    if (startingColOfMatrix - numberOfMoves >= 0)
                    {
                        startingColOfMatrix -= numberOfMoves;
                    }
                    else
                    {
                        canProceed = false;
                    }
                    break;
                case "right":
                    if (startingColOfMatrix + numberOfMoves < 8)
                    {
                        startingColOfMatrix += numberOfMoves;
                    }
                    else
                    {
                        canProceed = false;
                    }
                    break;
                case "up":
                    if (startingRowOfMatrix - numberOfMoves >= 0)
                    {
                        startingRowOfMatrix -= numberOfMoves;
                    }
                    else
                    {
                        canProceed = false;
                    }
                    break;
                case "down":
                    if (startingRowOfMatrix + numberOfMoves < 8)
                    {
                        startingRowOfMatrix += numberOfMoves;
                    }
                    else
                    {
                        canProceed = false;
                    }
                    break;
            }

            return canProceed;
        }

        static void Main()
        {
            FillMatrix();
            string command = Console.ReadLine();
            if (command == "stop")
            {
                return;
            }
            matrix[startingRowOfMatrix, startingColOfMatrix] = '1';
            while (command != "stop")
            {
                string[] words = command.Split();
                string firstMove = words[0];
                string secondMove = words[1];
                bool canMove = true;
                canMove = CheckMove(firstMove, 2);
                if (canMove)
                {
                    canMove = CheckMove(secondMove, 1);
                }

                if (canMove)
                {
                    if (matrix[startingRowOfMatrix, startingColOfMatrix] == '0')
                    {
                        matrix[startingRowOfMatrix, startingColOfMatrix] = '1';
                    }
                    else
                    {
                        matrix[startingRowOfMatrix, startingColOfMatrix] = '0';
                    }
                }

                command = Console.ReadLine();
            }

            StringBuilder currentRow = new StringBuilder();
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    currentRow.Append(matrix[i, j]);
                }

                int numberInDecimal = Convert.ToInt32(currentRow.ToString(), 2);
                if (numberInDecimal > 0)
                {
                    Console.WriteLine(numberInDecimal);
                }

                currentRow.Clear();
            }
        }
    }
}
