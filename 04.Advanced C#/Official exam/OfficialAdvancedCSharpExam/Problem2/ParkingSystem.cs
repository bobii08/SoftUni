namespace Problem2
{
    using System;
    using System.Linq;

    internal class ParkingSystem
    {
        private static void Main()
        {
            int[] rowAndCol =
                Console.ReadLine()
                    .Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            int rows = rowAndCol[0];
            int cols = rowAndCol[1];
            bool[,] matrix = new bool[rows, cols];
            //string line = Console.ReadLine();

            // int[] arr = new int[(cols - 1) * 2];
            int[] arr = new int[cols * 2];
            int currentNum = 1;
            for (int i = 0; i < arr.Length - 1; i += 2)
            {
                arr[i] = -currentNum;
                arr[i + 1] = currentNum;
                currentNum++;
            }

            int currentMoves = 0;
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "stop")
                {
                    break;
                }
                string[] args = line.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                int z = int.Parse(args[0]);
                int x = int.Parse(args[1]);
                int y = int.Parse(args[2]);
                //currentMoves = Math.Abs(x - z) + 1;
                if (x > z)
                {
                    currentMoves = x - z + 1;
                }
                if (z > x)
                {
                    currentMoves = z - x + 1;
                }
                if (x == z)
                {
                    currentMoves = 1;
                }
                //y > 0 && y < matrix.GetLength(1) && x > 0 && x < matrix.GetLength(0) && 
                if ((y > 0 && y < matrix.GetLength(1)) && (x >= 0 && x < matrix.GetLength(0)) && !matrix[x, y])
                {
                    currentMoves += y;
                    Console.WriteLine(currentMoves);
                    matrix[x, y] = true;
                }
                else
                {
                    int index = 0;
                    int downIndex = -1;
                    int updIndex = 1;
                    bool even = true;
                    while (true)
                    {
                        //int curentY = y + arr[index];
                        int curentY = 0;
                        if (even)
                        {
                            curentY = y + downIndex;
                            downIndex--;
                            even = false;
                        }
                        else
                        {
                            even = true;
                            curentY = y + updIndex;
                            updIndex++;
                        }

                        if (curentY > 0 && curentY < matrix.GetLength(1))
                        {
                            if (!matrix[x, curentY])
                            {
                                currentMoves += curentY;
                                matrix[x, curentY] = true;
                                Console.WriteLine(currentMoves);
                                break;   
                            }
                        }

                        index++;
                        if (index >= arr.Length)
                        {
                            Console.WriteLine("Row {0} full", x);
                            break;
                        }
                    }
                }

                //line = Console.ReadLine();
            }
        }
    }
}