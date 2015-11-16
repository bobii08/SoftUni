using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ComparingFloats
{
    class ComparingFloats
    {
        static void Main()
        {
            Console.Write("Enter first floating-point number: ");
            float firstNumber = float.Parse(Console.ReadLine());
            Console.Write("Enter second floating-point number: ");
            float secondNumber = float.Parse(Console.ReadLine());
            if (firstNumber == secondNumber)
            {
                Console.WriteLine("The numbers are equal!");
            }
            else
            {
                Console.WriteLine("The numbers are NOT equal!");
            }
        }
    }
}
