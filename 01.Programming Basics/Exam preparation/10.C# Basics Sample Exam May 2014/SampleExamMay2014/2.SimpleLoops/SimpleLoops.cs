using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _2.SimpleLoops
{
    class SimpleLoops
    {
        static void Main()
        {
            BigInteger firstNum = BigInteger.Parse(Console.ReadLine());
            BigInteger secondNum = BigInteger.Parse(Console.ReadLine());
            BigInteger thirdNum = BigInteger.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());

            if (position == 1)
            {
                Console.WriteLine(firstNum);
                return;
            }
            if (position == 2)
            {
                Console.WriteLine(secondNum);
                return;
            }
            if (position == 3)
            {
                Console.WriteLine(thirdNum);
                return;
            }
            BigInteger nextNum = 0;
            for (int i = 4; i <= position; i++)
            {
                nextNum = firstNum + secondNum + thirdNum;
                firstNum = secondNum;
                secondNum = thirdNum;
                thirdNum = nextNum;
            }

            Console.WriteLine(nextNum);
        }
    }
}
