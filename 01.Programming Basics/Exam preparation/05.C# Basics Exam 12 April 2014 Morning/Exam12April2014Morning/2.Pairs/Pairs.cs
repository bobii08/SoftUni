using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Pairs
{
    class Pairs
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] numbersStr = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int p = 0;
            int[] arr = new int[numbersStr.Length];
            foreach (var str in numbersStr)
            {
                arr[p] = int.Parse(str);
                p++;
            }

            int[] pairsSums = new int[arr.Length / 2];
            int position = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                pairsSums[position] += arr[i];
                if (i % 2 != 0)
                {
                    position++;
                }
            }

            int maxDifference = 0;
            for (int i = 0; i < pairsSums.Length - 1; i++)
            {
                int currentDifference = Math.Abs(pairsSums[i] - pairsSums[i + 1]);
                if (currentDifference > maxDifference)
                {
                    maxDifference = currentDifference;
                }
            }

            if (maxDifference == 0)
            {
                Console.WriteLine("Yes, value={0}", pairsSums[0]);
            }
            else
            {
                Console.WriteLine("No, maxdiff={0}", maxDifference);
            }
        }
    }
}
