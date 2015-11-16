using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.FloatOrDouble
{
    class FloatOrDouble
    {
        static void Main()
        {
            double firstVar = 34.567839023;
            Console.WriteLine(firstVar + " of type " + firstVar.GetType());
            float secondVar = 12.345f;
            Console.WriteLine(secondVar + " of type " + secondVar.GetType());
            double thirdVar = 8923.1234857;
            Console.WriteLine(thirdVar + " of type " + thirdVar.GetType());
            float fourthVar = 3456.091f;
            Console.WriteLine(fourthVar + " of type " + fourthVar.GetType());
            Console.WriteLine("\nNO PRECISION IS LOST");
        }
    }
}
