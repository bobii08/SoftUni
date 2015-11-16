using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main()
        {
            int? integerVarialbe = null;
            double? doubleVariable = null;
            Console.WriteLine("Integer variable: " + integerVarialbe);
            Console.WriteLine("Double variable: " + doubleVariable);
            Console.WriteLine("Integer varialbe + 5 = " + (integerVarialbe + 5));
            Console.WriteLine("Integer variable + null = " + integerVarialbe + null);
            Console.WriteLine("Double varialbe + 5 = " + (doubleVariable + 5));
            Console.WriteLine("Double variable + null = " + doubleVariable + null);
        }
    }
}
