using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.TheExplorer
{
    class TheExplorer
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            // print first line
            Console.Write(new string('-', n / 2));
            Console.Write('*');
            Console.WriteLine(new string('-', n / 2));

            int leftAndRightDashes = (n / 2) - 1;
            int middleDashes = 1;
            int countTop = 1;

            for (int i = 1; i <= n - 2; i++)
            {
                if (countTop < n / 2)
                {
                    Console.Write(new string('-', leftAndRightDashes));
                    Console.Write('*');
                    Console.Write(new string('-', middleDashes));
                    Console.Write('*');
                    Console.WriteLine(new string('-', leftAndRightDashes));
                    leftAndRightDashes--;
                    middleDashes += 2;
                }
                else if (countTop == n / 2)
                {
                    Console.Write(new string('-', leftAndRightDashes));
                    Console.Write('*');
                    Console.Write(new string('-', middleDashes));
                    Console.Write('*');
                    Console.WriteLine(new string('-', leftAndRightDashes));
                }
                else
                {
                    leftAndRightDashes++;
                    middleDashes -= 2;
                    Console.Write(new string('-', leftAndRightDashes));
                    Console.Write('*');
                    Console.Write(new string('-', middleDashes));
                    Console.Write('*');
                    Console.WriteLine(new string('-', leftAndRightDashes));
                }

                countTop++;
            }

            // print last line
            Console.Write(new string('-', n / 2));
            Console.Write('*');
            Console.WriteLine(new string('-', n / 2));
        }
    }
}
