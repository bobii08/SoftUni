using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _11.StudentCables
{
    class StudentCables
    {
        static void Main()
        {
            int numberOfCables = int.Parse(Console.ReadLine());
            List<BigInteger> cablesLength = new List<BigInteger>();
            for (int i = 0; i < numberOfCables; i++)
            {
                BigInteger length = BigInteger.Parse(Console.ReadLine());
                string measure = Console.ReadLine();
                if (measure == "meters")
                {
                    length *= 100;
                }

                cablesLength.Add(length);
            }

            for (int i = 0; i < cablesLength.Count; i++)
            {
                if (cablesLength[i] < 20)
                {
                    cablesLength.RemoveAt(i);
                    i--;
                }
            }

            int timesBy3 = cablesLength.Count - 1;

            BigInteger total = 0;
            foreach (var cableLength in cablesLength)
            {
                total += cableLength;
            }

            total -= timesBy3 * 3;

            BigInteger numberOfStudetnCables = total / 504;

            Console.WriteLine(numberOfStudetnCables);
            Console.WriteLine(total % 504);
        }
    }
}
