using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.ChessQueens
{
    class ChessQueens
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            char[] rowsLetters = new char[20];
            for (int i = 0; i < 20; i++)
            {
                rowsLetters[i] = (char)(97 + i);
            }
            string[] colsNumbers = new string[20];
            for (int i = 0; i < 20; i++)
            {
                colsNumbers[i] = (i + 1).ToString();
            }

            int countValidPositions = 0;
            if (size <= 1)
            {
                Console.WriteLine("No valid positions");
                return;
            }
            for (int row = 0; row < size; row++)
            {
                int x1 = row;
                for (int col = 0; col < size; col++)
                {
                    int y1 = col;
                    // --->
                    if (y1 + 1 + distance < size)
                    {
                        Console.WriteLine("{0}{1} - {2}{3}", rowsLetters[x1], colsNumbers[y1],
                            rowsLetters[x1], colsNumbers[y1 + 1 + distance]);
                        countValidPositions++;
                    }
                    // down
                    if (x1 + 1 + distance < size)
                    {
                        Console.WriteLine("{0}{1} - {2}{3}", rowsLetters[x1], colsNumbers[y1], 
                            rowsLetters[x1 + 1 + distance], colsNumbers[y1]);
                        countValidPositions++;
                    }
                    // checked
                    if (x1 - 1 - distance >= 0)
                    {
                        Console.WriteLine("{0}{1} - {2}{3}", rowsLetters[x1], colsNumbers[y1],
                            rowsLetters[x1 - 1 - distance], colsNumbers[y1]);
                        countValidPositions++;
                    }
                    
                    // checked
                    if (y1 - 1 - distance >= 0)
                    {
                        Console.WriteLine("{0}{1} - {2}{3}", rowsLetters[x1], colsNumbers[y1],
                            rowsLetters[x1], colsNumbers[y1 - 1 - distance]);
                        countValidPositions++;
                    }
                    // checked
                    if ((x1 - 1 - distance >= 0) && (y1 - 1 - distance >= 0))
                    {
                        Console.WriteLine("{0}{1} - {2}{3}", rowsLetters[x1], colsNumbers[y1],
                            rowsLetters[x1 - 1 - distance], colsNumbers[y1 - 1 - distance]);
                        countValidPositions++;
                    }
                    // checked
                    if ((x1 - 1 - distance >= 0) && (y1 + 1 + distance < size))
                    {
                        Console.WriteLine("{0}{1} - {2}{3}", rowsLetters[x1], colsNumbers[y1],
                            rowsLetters[x1 - 1 - distance], colsNumbers[y1 + 1 + distance]);
                        countValidPositions++;
                    }
                    // checked
                    if ((x1 + 1 + distance < size) && (y1 - 1 - distance >= 0))
                    {
                        Console.WriteLine("{0}{1} - {2}{3}", rowsLetters[x1], colsNumbers[y1],
                            rowsLetters[x1 + 1 + distance], colsNumbers[y1 - 1 - distance]);
                        countValidPositions++;
                    }
                    // checked
                    if ((x1 + 1 + distance < size) && (y1 + 1 + distance < size))
                    {
                        Console.WriteLine("{0}{1} - {2}{3}", rowsLetters[x1], colsNumbers[y1],
                            rowsLetters[x1 + 1 + distance], colsNumbers[y1 + 1 + distance]);
                        countValidPositions++;
                    }
                }
            }

            if (countValidPositions == 0)
            {
                Console.WriteLine("No valid positions");
            }
        }
    }
}
