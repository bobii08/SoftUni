namespace _05.CollectTheCoins
{
    using System;
    using System.Collections.Generic;

    internal class CollectTheCoins
    {
        private static char[][] jaggedArray;

        private static int coinsCollected = 0;

        private static int wallsHit = 0;

        private static readonly Dictionary<int, List<int>> VisitedCellsWithCoins = new Dictionary<int, List<int>>();

        private static void Main()
        {
            jaggedArray = new char[4][];
            for (int currentRow = 0; currentRow < 4; currentRow++)
            {
                string line = Console.ReadLine();
                jaggedArray[currentRow] = new char[line.Length];
                for (int j = 0; j < line.Length; j++)
                {
                    jaggedArray[currentRow][j] = line[j];
                }
            }

            string lastLine = Console.ReadLine();
            char[] commands = new char[lastLine.Length];
            for (int i = 0; i < lastLine.Length; i++)
            {
                commands[i] = lastLine[i];
            }
            
            int row = 0;
            int col = 0;
            for (int index = 0; index < commands.Length; index++)
            {
                char currentCommand = commands[index];
                switch (currentCommand)
                {
                    case 'V':
                        if (IsInRange(row + 1, col))
                        {
                            row += 1;
                        }
                        else
                        {
                            wallsHit++;
                            break;
                        }

                        CheckIfThereIsACoin(row, col);
                        break;
                    case '>':
                        if (IsInRange(row, col + 1))
                        {
                            col += 1;
                        }
                        else
                        {
                            wallsHit++;
                            break;
                        }

                        CheckIfThereIsACoin(row, col);
                        break;
                    case '^':
                        if (IsInRange(row - 1, col))
                        {
                            row -= 1;
                        }
                        else
                        {
                            wallsHit++;
                            break;
                        }

                        CheckIfThereIsACoin(row, col);
                        break;
                    case '<':
                        if (IsInRange(row, col - 1))
                        {
                            col -= 1;
                        }
                        else
                        {
                            wallsHit++;
                            break;
                        }

                        CheckIfThereIsACoin(row, col);
                        break;
                }
            }

            Console.WriteLine("Coins collected: " + coinsCollected);
            Console.WriteLine("Walls hit: " + wallsHit);
        }

        private static bool IsInRange(int row, int col)
        {
            if ((row >= 0 && row < jaggedArray.Length) && (col >= 0 && col < jaggedArray[row].Length))
            {
                return true;
            }

            return false;
        }

        private static void CheckIfThereIsACoin(int row, int col)
        {
            if (!VisitedCellsWithCoins.ContainsKey(row))
            {
                if (jaggedArray[row][col] == '$')
                {
                    coinsCollected++;
                    VisitedCellsWithCoins[row] = new List<int>();
                    VisitedCellsWithCoins[row].Add(col);
                }
            }
            else
            {
                if (!VisitedCellsWithCoins[row].Contains(col))
                {
                    if (jaggedArray[row][col] == '$')
                    {
                        coinsCollected++;
                        VisitedCellsWithCoins[row].Add(col);
                    }
                }
            }
        }
    }
}