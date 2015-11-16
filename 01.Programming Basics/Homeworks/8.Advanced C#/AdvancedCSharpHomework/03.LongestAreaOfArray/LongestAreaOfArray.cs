using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LongestAreaOfArray
{
    class LongestAreaOfArray
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] strings = new string[n];
            for (int i = 0; i < n; i++)
            {
                strings[i] = Console.ReadLine();
            }

            int longestCount = 1;
            string word = strings[0];
            for (int i = 0; i < strings.Length - 1; i++)
            {
                string currentWord = strings[i];
                int currentCount = 1;
                int j = i + 1;
                while (true)
                {
                    if (currentWord == strings[j])
                    {
                        currentCount++;
                    }
                    else
                    {
                        break;
                    }

                    if (currentCount > longestCount)
                    {
                        longestCount = currentCount;
                        word = currentWord;
                    }

                    j++;
                    if (j == strings.Length)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine("result: ");
            Console.WriteLine(longestCount);
            for (int i = 0; i < longestCount; i++)
            {
                Console.WriteLine(word);
            }
        }
    }
}
