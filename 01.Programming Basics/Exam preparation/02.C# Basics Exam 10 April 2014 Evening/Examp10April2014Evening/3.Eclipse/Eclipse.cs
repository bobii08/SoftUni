using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Eclipse
{
    class Eclipse
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            // first line
            Console.Write(" " + new string('*', ((2 * n) - 2)) + " ");
            Console.Write(new string(' ', n - 1));
            Console.WriteLine(" " + new string('*', ((2 * n) - 2)) + " ");

            for (int i = 1; i <= n - 2; i++)
            {
                if (i == ((n - 2) / 2) + 1)
                {
                    Console.Write('*' + new string('/', ((2 * n) - 2)) + '*');
                    Console.Write(new string('-', n - 1));
                    Console.WriteLine('*' + new string('/', ((2 * n) - 2)) + '*');
                }
                else
                {
                    Console.Write('*' + new string('/', ((2 * n) - 2)) + '*');
                    Console.Write(new string(' ', n - 1));
                    Console.WriteLine('*' + new string('/', ((2 * n) - 2)) + '*');
                }
            }

            // last line
            Console.Write(" " + new string('*', ((2 * n) - 2)) + " ");
            Console.Write(new string(' ', n - 1));
            Console.WriteLine(" " + new string('*', ((2 * n) - 2)) + " ");
        }
    }
}
