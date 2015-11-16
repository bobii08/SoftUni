using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _05.Calculate1Plus1FactDividedByXEtc
{
    class Calculate1Plus1FactDividedByXEtc
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("x = ");
            int x = int.Parse(Console.ReadLine());

            BigInteger[] factorials = new BigInteger[n + 1];
            factorials[1] = 1;
            factorials[2] = 2;
            for (int num = 3; num <= n; num++)
            {
                int numToBeSumed = num;
                BigInteger factorial = 1;
                while (numToBeSumed > 1)
                {
                    factorial *= numToBeSumed;
                    numToBeSumed--;
                }

                factorials[num] = factorial;
            }

            double sum = 1;
            for (int i = 1; i <= n; i++)
            {
                sum += (double)factorials[i] / Math.Pow(x, i);
            }

            Console.WriteLine("{0:0.00000}", sum);
        }
    }
}
