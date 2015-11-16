using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MatrixOfNumbers
{
    class MatrixOfNumbers
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int numberToBePrinted = i;
                for (int j = 1; j <= n; j++)
                {
                    Console.Write(numberToBePrinted++ + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
