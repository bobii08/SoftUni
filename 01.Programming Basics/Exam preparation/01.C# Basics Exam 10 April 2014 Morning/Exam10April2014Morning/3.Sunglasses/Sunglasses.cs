using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Sunglasses
{
    class Sunglasses
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            // print first line
            Console.WriteLine(new string('*', 2 * n) + new string(' ', n) + new string('*', 2 * n));

            // print lenses
            for (int i = 1; i <= n - 2; i++)
            {
                if (i == ((n - 2) / 2) + 1)
                {
                    Console.WriteLine('*' + new string('/', (2 * n) - 2) + '*' + new string('|', n) +
                        '*' + new string('/', (2 * n) - 2) + '*');
                }
                else
                {
                    Console.WriteLine('*' + new string('/', (2 * n) - 2) + '*' + new string(' ', n) +
                        '*' + new string('/', (2 * n) - 2) + '*');
                }
            }

            // print last line
            Console.WriteLine(new string('*', 2 * n) + new string(' ', n) + new string('*', 2 * n));
        }
    }
}
