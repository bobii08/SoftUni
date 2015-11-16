using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("sign infront of the product of the 3 numbers is: " + 0);
                return;
            }

            Console.Write("sign infront of the product of the 3 numbers is: ");
            if (a > 0)
            {
                if (b > 0)
                {
                    if (c > 0)
                    {
                        Console.WriteLine('+');
                    }
                    else
                    {
                        Console.WriteLine('-');
                    }
                }
                else
                {
                    if (c > 0)
                    {
                        Console.WriteLine('-');
                    }
                    else
                    {
                        Console.WriteLine('+');
                    }
                }
            }
            else
            {
                if (b > 0)
                {
                    if (c > 0)
                    {
                        Console.WriteLine('-');
                    }
                    else
                    {
                        Console.WriteLine('+');
                    }
                }
                else
                {
                    if (c > 0)
                    {
                        Console.WriteLine('+');
                    }
                    else
                    {
                        Console.WriteLine('-');
                    }
                }
            }
        }
    }
}
