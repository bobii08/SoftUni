using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.BitPaths
{
    class BitPaths
    {
        private static string[,] board = new string[8, 4];

        private static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 0)
            {
                Console.WriteLine(0);
                Console.WriteLine(0);
                return;
            }
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    board[i, j] = "0";
                }
            }

            for (int i = 0; i < n; i++)
            {
                string currentLine = Console.ReadLine();
                string[] strs = currentLine.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                int currentCol = int.Parse(strs[0]);
                for (int row = 0; row < 8; row++)
                {
                    if (board[row, currentCol] == "1")
                    {
                        board[row, currentCol] = "0";
                    }
                    else
                    {
                        board[row, currentCol] = "1";
                    }
                    if (row == 7)
                    {
                        break;
                    }
                    string num = strs[row + 1];
                    if (num == "-1")
                    {
                        currentCol--;
                    }
                    else if (num == "+1")
                    {
                        currentCol++;
                    }
                }
            }

            int sum = 0;
            for (int row = 0; row < 8; row++)
            {
                string wordOnRow = "";
                for (int col = 0; col < 4; col++)
                {
                    wordOnRow += board[row, col];
                }

                sum += Convert.ToInt32(wordOnRow, 2);
            }

            Console.WriteLine(Convert.ToString(sum, 2));
            Console.WriteLine(Convert.ToString(sum, 16).ToUpper());
        }
    }
}
