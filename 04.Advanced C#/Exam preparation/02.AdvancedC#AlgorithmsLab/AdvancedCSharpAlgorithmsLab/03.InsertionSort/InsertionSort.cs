using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.InsertionSort
{
    class InsertionSort
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 1; i < numbers.Length; i++)
            {
                int currentNum = numbers[i];
                if (numbers[i - 1] > currentNum)
                {
                    int j = i - 1;
                    int n = 0;
                    while (j >= 0 && numbers[j] > currentNum)
                    {
                        numbers[j + 1] = numbers[j];
                        n++;
                        j--;
                    }

                    numbers[i - n] = currentNum;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
