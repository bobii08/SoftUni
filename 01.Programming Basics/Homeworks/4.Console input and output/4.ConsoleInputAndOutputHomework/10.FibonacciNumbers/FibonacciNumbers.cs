using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine(0);
            }
            else if (n == 2)
            {
                Console.WriteLine(0 + " " + 1);
            }
            else if (n > 2)
            {
                int firstNum = 0;
                int secondNum = 1;
                Console.Write(firstNum + " " + secondNum);
                for (int i = 2; i < n; i++)
                {
                    int thirdNum = firstNum + secondNum;
                    Console.Write(" " + thirdNum);
                    firstNum = secondNum;
                    secondNum = thirdNum;
                }

                Console.WriteLine();
            }
        }
    }
}
