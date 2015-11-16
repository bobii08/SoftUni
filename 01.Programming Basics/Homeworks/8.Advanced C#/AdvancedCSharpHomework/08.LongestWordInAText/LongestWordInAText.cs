using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.LongestWordInAText
{
    class LongestWordInAText
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] words = input.Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);
            string longestWord = "";
            foreach (var currentWord in words)
            {
                if (currentWord.Length > longestWord.Length)
                {
                    longestWord = currentWord;
                }
            }

            Console.WriteLine(longestWord);
        }
    }
}
