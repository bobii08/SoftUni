using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.PlaidTowel
{
    class PlaidTowel
    {
        private static void PrintSymbol(char symbol, int times)
        {
            Console.Write(new string(symbol, times));
        }

        private static void PrintTop(int size, char backgroundSymbol, char rhombusSymbol)
        {
            int count1 = size;
            int count2 = 0;
            int count3 = (size * 4 + 1) - 2 - 2 * size;

            for (int i = 0; i < size; i++)
            {
                if (i == 0)
                {
                    PrintSymbol(backgroundSymbol, count1);
                    Console.Write(rhombusSymbol);
                    PrintSymbol(backgroundSymbol, count3);
                    Console.Write(rhombusSymbol);
                    PrintSymbol(backgroundSymbol, count1);
                    Console.WriteLine();
                    count1--;
                    count2++;
                    count3 -= 2;
                }
                else
                {
                    PrintSymbol(backgroundSymbol, count1);
                    Console.Write(rhombusSymbol);
                    PrintSymbol(backgroundSymbol, count2);
                    Console.Write(rhombusSymbol);
                    PrintSymbol(backgroundSymbol, count3);
                    Console.Write(rhombusSymbol);
                    PrintSymbol(backgroundSymbol, count2);
                    Console.Write(rhombusSymbol);
                    PrintSymbol(backgroundSymbol, count1);
                    Console.WriteLine();
                    count1--;
                    count2 += 2;
                    count3 -= 2;
                }
            }
        }

        private static void PrintBottom(int size, char backgroundSymbol, char rhombusSymbol)
        {
            int count1 = 1;
            int count2 = (size * 4 + 1) / 2 - 3;
            int count3 = 1;

            for (int i = 0; i < size - 1; i++)
            {
                PrintSymbol(backgroundSymbol, count1);
                Console.Write(rhombusSymbol);
                PrintSymbol(backgroundSymbol, count2);
                Console.Write(rhombusSymbol);
                PrintSymbol(backgroundSymbol, count3);
                Console.Write(rhombusSymbol);
                PrintSymbol(backgroundSymbol, count2);
                Console.Write(rhombusSymbol);
                PrintSymbol(backgroundSymbol, count1);
                Console.WriteLine();
                count1++;
                count2 -= 2;
                count3 += 2;
            }
        }

        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            char backgroundSymbol = char.Parse(Console.ReadLine());
            char rhombusSymbol = char.Parse(Console.ReadLine());
            
            // first top
            PrintTop(size, backgroundSymbol, rhombusSymbol);

            int someSize = (size*4 + 1)/2;

            // middle
            Console.Write(rhombusSymbol);
            Console.Write(new string(backgroundSymbol, (someSize) - 1));
            Console.Write(rhombusSymbol);
            Console.Write(new string(backgroundSymbol, (someSize) - 1));
            Console.Write(rhombusSymbol);
            Console.WriteLine();

            // first bottom
            PrintBottom(size, backgroundSymbol, rhombusSymbol);

            // second top
            PrintTop(size, backgroundSymbol, rhombusSymbol);

            // middle
            Console.Write(rhombusSymbol);
            Console.Write(new string(backgroundSymbol, (someSize) - 1));
            Console.Write(rhombusSymbol);
            Console.Write(new string(backgroundSymbol, (someSize) - 1));
            Console.Write(rhombusSymbol);
            Console.WriteLine();

            // second bottom
            PrintBottom(size, backgroundSymbol, rhombusSymbol);

            int count1 = size;
            int count2 = 0;
            int count3 = (size * 4 + 1) - 2 - 2 * size;
            PrintSymbol(backgroundSymbol, count1);
            Console.Write(rhombusSymbol);
            PrintSymbol(backgroundSymbol, count3);
            Console.Write(rhombusSymbol);
            PrintSymbol(backgroundSymbol, count1);
            Console.WriteLine();
        }
    }
}
