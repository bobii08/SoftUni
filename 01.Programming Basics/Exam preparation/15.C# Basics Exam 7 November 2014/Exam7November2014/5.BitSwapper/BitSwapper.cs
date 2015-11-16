using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace _5.BitSwapper
{
    class BitSwapper
    {
        static void Main()
        {
            uint firstNum = uint.Parse(Console.ReadLine());
            uint secondNum = uint.Parse(Console.ReadLine());
            uint thirdNum = uint.Parse(Console.ReadLine());
            uint fourthNum = uint.Parse(Console.ReadLine());

            uint[] nums =
            {
                firstNum, secondNum, thirdNum, fourthNum
            };

            string firstLine = Console.ReadLine();
            string secondLine = Console.ReadLine();

            uint[] firstLineSeparateNumbers = firstLine.Split().Select(uint.Parse).ToArray();
            uint[] secondLineSeparateNumbers = secondLine.Split().Select(uint.Parse).ToArray();

            ulong firstNumberPosition = ulong.Parse(firstLineSeparateNumbers[1].ToString());
            ulong secondNumberPosition = ulong.Parse(secondLineSeparateNumbers[1].ToString());

            int firstIndex = 0;
            int secondIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == ulong.Parse(firstLineSeparateNumbers[0].ToString()))
                {
                    firstIndex = i;
                }
                if (nums[i] == ulong.Parse(secondLineSeparateNumbers[0].ToString()))
                {
                    secondIndex = i;
                }
            }

            uint firstNumExtraction = (nums[firstIndex] >> firstNumberPosition) & 15;
            uint secondNumExtraction = (nums[secondIndex] >> secondNumberPosition) & 15;

            // nulirame wsichki bitove na konkretnite pozicii
            nums[firstIndex] = nums[firstIndex] & ((~15) << firstNumberPosition);

        }
    }
}
