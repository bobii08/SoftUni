using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MatrixOfPalindromes
{
    class MatrixOfPalindromes
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');
            int rows = int.Parse(numbers[0]);
            int cols = int.Parse(numbers[1]);

            for (int i = 0; i < rows; i++)
            {
                int toBeAdded = 0;
                for (int j = 0; j < cols; j++)
                {
                    Console.Write((char)(i+97)+""+(char)(i+toBeAdded+97) + ""+(char)(i+97)+ " ");
                    toBeAdded++;
                }

                Console.WriteLine();
            }
        }
    }
}
