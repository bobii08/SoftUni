using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CalculateNFactDevidedByKFact
{
    class CalculateNFactDevidedByKFact
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long nFactorial = 1;
            long kFactorial = 1;

            while (true)
            {
                if (n > 1)
                {
                    nFactorial *= n;
                    n--;
                }
                if (k > 1)
                {
                    kFactorial *= k;
                    k--;
                }
                if (n == k) // n == 1 && k == 1
                {
                    Console.WriteLine(nFactorial / kFactorial);
                    break;
                }
            }
        }
    }
}
