using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.LargestRectangle
{
    class LargestRectangle
    {
        static void Main()
        {
            string line = Console.ReadLine();
            List<List<string>> matrixInput = new List<List<string>>();
            int currentRow = 0;
            while (line != "END")
            {
                var strings = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                matrixInput.Add(new List<string>());
                for (int i = 0; i < strings.Length; i++)
                {
                    matrixInput[currentRow].Add(strings[i]);
                }

                currentRow++;
                line = Console.ReadLine();
            }

            string[,] matrix = new string[matrixInput.Count, matrixInput[0].Count];
            for (int i = 0; i < matrixInput.Count; i++)
            {
                for (int j = 0; j < matrixInput[0].Count; j++)
                {
                    matrix[i, j] = matrixInput[i][j];
                }
            }

            int maxArea = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    for (int right = col; right < matrix.GetLength(1); right++)
                    {
                        for (int down = row; down < matrix.GetLength(0); down++)
                        {
                            for (int left = col; left >= 0; left--)
                            {
                                for (int up = row; up >= 0; up--)
                                {
                                    
                                }
                            }
                        }
                    }
                }
            }

            var a = 1;
        }
    }
}
