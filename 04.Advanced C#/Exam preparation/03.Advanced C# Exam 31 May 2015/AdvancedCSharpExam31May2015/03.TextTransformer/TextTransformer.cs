namespace _03.TextTransformer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    internal class TextTransformer
    {
        private static void Main()
        {
            StringBuilder strB = new StringBuilder();
            string line = Console.ReadLine();
            while (line != "burp")
            {
                strB.Append(line);
                line = Console.ReadLine();
            }

            string singleLine = strB.ToString();
            string pattern = "\\s+";
            Regex regex = new Regex(pattern);
            singleLine = regex.Replace(singleLine, " ");

            pattern = @"([$%&'])([^$%&']+)\1";
            regex = new Regex(pattern);
            var matches = regex.Matches(singleLine);
            
            List<char> symbolsArr = new List<char>()
            {
                '$', '%', '&', '\''
            };

            StringBuilder result = new StringBuilder();
            foreach (Match match in matches)
            {
                char symbol = match.Groups[1].Value[0];
                string word = match.Groups[2].Value;
                int power = symbolsArr.IndexOf(symbol) + 1;
                for (int i = 0; i < word.Length; i++)
                {
                    char currentChar = word[i];
                    char resultingChar;
                    if (i % 2 == 0)
                    {
                        resultingChar = (char)(currentChar + power);
                    }
                    else
                    {
                        resultingChar = (char)(currentChar - power);
                    }

                    result.Append(resultingChar);
                }

                result.Append(" ");
            }

            Console.WriteLine(result);
        }
    }
}