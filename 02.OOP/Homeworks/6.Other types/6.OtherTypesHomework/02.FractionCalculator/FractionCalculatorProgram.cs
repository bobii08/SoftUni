using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.FractionCalculator
{
    class FractionCalculatorProgram
    {
        static void Main()
        {
            Fraction fraction1 = new Fraction(22, 7);
            Fraction fraction2 = new Fraction(40, 4);
            Fraction result = fraction1 + fraction2;
            Console.WriteLine("The result is different than the one in the example because I have found the greatest common divisor(GCD) for the numerator and denominator and have devided them by it(the GCD)");
            Console.WriteLine(result.Numerator);
            Console.WriteLine(result.Denominator);
            Console.WriteLine(result);
        }
    }
}
