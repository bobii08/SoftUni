using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.TheBiggestOfFiveNumbers
{
    class TheBiggestOfFiveNumbers
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());

            Console.Write("Maximum number: ");
            if (a > Math.Max(b, c) && a > Math.Max(d, e))
            {
                Console.WriteLine(a);
            }
            else if (b > Math.Max(a, c) && b > Math.Max(d, e))
            {
                Console.WriteLine(b);
            }
            else if (c > Math.Max(a, b) && c > Math.Max(d, e))
            {
                Console.WriteLine(c);
            }
            else if (d > Math.Max(a, b) & d > Math.Max(c, e))
            {
                Console.WriteLine(d);
            }
            else
            {
                Console.WriteLine(e);
            }
        }
    }
}
