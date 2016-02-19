namespace _01.SeriesOfLetters
{
    using System;
    using System.Text.RegularExpressions;

    internal class SeriesOfLetters
    {
        private static void Main()
        {
            string input = Console.ReadLine();
            string pattern;
            Regex regex;
            for (int i = 97; i < 123; i++)
            {
                pattern = string.Format(@"{0}+", Convert.ToChar(i));
                regex = new Regex(pattern);
                input = regex.Replace(input, Convert.ToChar(i).ToString());
            }

            for (int i = 65; i < 91; i++)
            {
                pattern = string.Format(@"{0}+", Convert.ToChar(i));
                regex = new Regex(pattern);
                input = regex.Replace(input, Convert.ToChar(i).ToString());
            }

            Console.WriteLine(input);
        }
    }
}