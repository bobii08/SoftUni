using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.HalfSum
{
    class HalfSum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[2 * n];
            for (int i = 0; i < 2 * n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int firstSum = 0;
            for (int i = 0; i < n; i++)
            {
                firstSum += arr[i];
            }

            int secondSum = 0;
            for (int i = n; i < 2 * n; i++)
            {
                secondSum += arr[i];
            }

            if (firstSum == secondSum)
            {
                Console.WriteLine("Yes, sum={0}", firstSum);
            }
            else
            {
                Console.WriteLine("No, diff={0}", Math.Abs(firstSum - secondSum));
            }
        }
    }
}
