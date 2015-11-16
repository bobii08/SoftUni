using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SumOf3Numbers
{
    class SumOf3Numbers
    {
        static void Main()
        {
            Console.Write("First number: ");
            double firstNum = double.Parse(Console.ReadLine());
            Console.Write("Second number: ");
            double secondNum = double.Parse(Console.ReadLine());
            Console.Write("Thrid number: ");
            double thirdNumber = double.Parse(Console.ReadLine());
            double sum = firstNum + secondNum + thirdNumber;
            Console.WriteLine("The sum of the three numbers is: " + sum);
        }
    }
}
