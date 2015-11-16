using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.JumpingSums
{
    class JumpingSums
    {
        static void Main()
        {
            string S = Console.ReadLine();
            int jumps = int.Parse(Console.ReadLine());
            int[] numbers = S.Split().Select(int.Parse).ToArray();
            int currentJumps = 1;
            int max = int.MinValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentSum = 0;
                while (currentJumps <= jumps)
                {

                    currentJumps++;
                }

                if (currentSum > max)
                {
                    max = currentSum;
                }
            }

        }
    }
}
