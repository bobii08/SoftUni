using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sort3NumbersWithNestedIfs
{
    class Sort3NumbersWithNestedIfs
    {
        static void Main()
        {
            Console.WriteLine("Enter three numbers to be sorted: ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if (a >= b)
            {
                if (b >= c)
                {
                    Console.WriteLine("{0} {1} {2}", a, b, c);
                    return;
                }
                if (c >= b && a >= c)
                {
                    Console.WriteLine("{0} {1} {2}", a, c, b);
                    return;
                }
            }
            if (b >= a)
            {
                if (a >= c)
                {
                    Console.WriteLine("{0} {1} {2}", b, a, c);
                    return;
                }
                if (c >= a && b >= c)
                {
                    Console.WriteLine("{0} {1} {2}", b, c, a);
                    return;
                }
            }
            if (c >= a)
            {
                if (a >= b)
                {
                    Console.WriteLine("{0} {1} {2}", c, a, b);
                    return;
                }
                if (b >= a && c >= b)
                {
                    Console.WriteLine("{0} {1} {2}", c, b, a);
                    return;
                }
            }
        }
    }
}
