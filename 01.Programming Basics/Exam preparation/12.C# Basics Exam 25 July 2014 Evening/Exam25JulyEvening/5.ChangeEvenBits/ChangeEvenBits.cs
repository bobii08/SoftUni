using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _5.ChangeEvenBits
{
    class ChangeEvenBits
    {
        static void Main()
        {
            byte n = byte.Parse(Console.ReadLine());
            //long[] arr = new long[n];
            long max = 0;
            for (int i = 0; i < n; i++)
            {
                long currentNumber = long.Parse(Console.ReadLine());
                //arr[i] = long.Parse(Console.ReadLine());
                if (currentNumber > max)
                {
                    max = currentNumber;
                }
            }

            BigInteger l = BigInteger.Parse(Console.ReadLine());

            if (n == 0)
            {
                Console.WriteLine(l);
                Console.WriteLine(0);
                return;
            }
            int len = 0;
            string maxNumInBin = Convert.ToString(max, 2);
            len = maxNumInBin.Length;
            int numberOfChangedBits = 0;
            for (int index = 0; index < len; index++)
            {
                int mask = 1 << (index * 2);
                if ((l & mask) == 0)
                {
                    numberOfChangedBits++;
                    l |= mask;
                }
            }

            Console.WriteLine(l);
            Console.WriteLine(numberOfChangedBits);
        }
    }
}
