namespace _03.ExtractEmails
{
    using System;
    using System.Text.RegularExpressions;

    internal class ExtractEmails
    {
        private static void Main()
        {
            string input = Console.ReadLine();
            string pattern = " [a-z0-9]+[\\.\\-_]?[a-z0-9]+@(?:[a-z]+[-\\.]?[a-z]+)*(?:[a-z]+\\.[a-z]+){1}\\b";
            Regex regex = new Regex(pattern);
            var matches = regex.Matches(input);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value.Substring(1));
            }
        }
    }
}