namespace _06.Palindromes
{
    using System;
    using System.Collections.Generic;

    internal class Palindromes
    {
        private static void Main()
        {
            SortedSet<string> sortedSet = new SortedSet<string>();
            string inputLine = Console.ReadLine();
            string[] strings = inputLine.Split(
                new[] { ' ', ',', '.', '?', '!' }, 
                StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < strings.Length; i++)
            {
                if (CheckIfPalindrome(strings[i]))
                {
                    sortedSet.Add(strings[i]);
                }
            }

            Console.WriteLine(string.Join(", ", sortedSet));
        }

        private static bool CheckIfPalindrome(string str)
        {
            bool result = true;
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - 1 - i])
                {
                    result = false;
                }
            }

            return result;
        }
    }
}