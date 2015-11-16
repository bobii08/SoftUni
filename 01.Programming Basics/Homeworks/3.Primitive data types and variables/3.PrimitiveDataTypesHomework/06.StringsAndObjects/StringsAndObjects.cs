using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main()
        {
            string firstVar = "Hello";
            string secondVar = "World";
            object objectVar = firstVar + " " + secondVar;
            string thirdVar = (string) objectVar;
            Console.WriteLine("First string variable: " + firstVar);
            Console.WriteLine("Second string variable: " + secondVar);
            Console.WriteLine("Object variable: " + objectVar);
            Console.WriteLine("Third string variable: " + thirdVar);
        }
    }
}
