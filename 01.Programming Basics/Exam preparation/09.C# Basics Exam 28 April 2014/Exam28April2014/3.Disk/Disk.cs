using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Disk
{
    class Disk
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int radius = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            int center = n/2;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    int aSide = Math.Abs(col - center);
                    int bSide = Math.Abs(row - center);
                    if (Math.Sqrt(aSide * aSide + bSide * bSide) <= radius)
                    {
                        Console.Write('*');
                        continue;
                    }
                    /*
                    if (col == center)
                    {
                        if (row >= center - radius && row <= center + radius)
                        {
                            Console.Write('*');
                        }
                        else
                        {
                            Console.Write('.');
                        }
                    }
                    else if (row == center)
                    {
                        if (col >= center - radius && col <= center + radius)
                        {
                            Console.Write('*');
                        }
                        else
                        {
                            Console.Write('.');
                        }
                    }
                    */
                    else
                    {
                        Console.Write('.');
                    }
                } 
                Console.WriteLine();
            }
        }
    }
}
