using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _2.SumOfElements
{
    class SumOfElements
    {
        static void Main()
        {
            string inputLine = Console.ReadLine();
            string[] elements = inputLine.Split(' ');
            
            BigInteger[] numbers = new BigInteger[elements.Length];
            for (int i = 0; i < elements.Length; i++)
            {
                numbers[i] = BigInteger.Parse(elements[i]);
            }

            BigInteger minimumDifference = ulong.MaxValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                BigInteger numberToBeChecked = numbers[i];
                BigInteger sumOfOtherNumbers = 0;
                foreach (var num in numbers)
                {
                    sumOfOtherNumbers += num;
                }

                sumOfOtherNumbers -= numberToBeChecked;
                if (sumOfOtherNumbers == numberToBeChecked)
                {
                    Console.WriteLine("Yes, sum={0}", sumOfOtherNumbers);
                    break;
                }

                BigInteger currentDifference = numberToBeChecked - sumOfOtherNumbers;

                if (currentDifference < 0)
                {
                    currentDifference *= -1;
                }
                if (currentDifference < minimumDifference)
                {
                    minimumDifference = currentDifference;
                }

                if (i == numbers.Length - 1)
                {
                    Console.WriteLine("No, diff={0}", minimumDifference);
                }
            }
        }
    }
}
