using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ExchangeVarialbeValues
{
    class ExchangeVarialbeValues
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("Before: ");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            int temporaryVar = a;
            a = b;
            b = temporaryVar;
            Console.WriteLine("After: ");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
        }
    }
}
