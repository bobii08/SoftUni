using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MinMaxSumAndAverageOfNNums
{
    class MinMaxSumAndAverageOfNNums
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            int min = int.MaxValue;
            int max = int.MinValue;
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int currentNum = nums[i];
                sum += currentNum;
                if (currentNum < min)
                {
                    min = currentNum;
                }
                if (currentNum > max)
                {
                    max = currentNum;
                }
            }

            Console.WriteLine("min = {0}\nmax = {1}\nsum = {2}\navg = {3:0.00}",
                min, max, sum, ((double)sum / n));
        }
    }
}
