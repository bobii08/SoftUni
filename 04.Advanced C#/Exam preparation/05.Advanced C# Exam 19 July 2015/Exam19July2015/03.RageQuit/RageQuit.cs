namespace _03.RageQuit
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    
    internal class RageQuit
    {
        private static void Main()
        {
            // Console.SetIn(new StreamReader(Console.OpenStandardInput(16384)));
            string inputLine = Console.ReadLine();
            string pattern = @"([^\d]{1,20})(\d{1,2})";
            Regex regex = new Regex(pattern);
            var matches = regex.Matches(inputLine);
            StringBuilder result = new StringBuilder();
            foreach (Match match in matches)
            {
                string currentString = match.Groups[1].Value.ToUpper();
                int repeatCount = int.Parse(match.Groups[2].Value);
                for (int i = 0; i < repeatCount; i++)
                {
                    result.Append(currentString);
                }
            }

            Console.WriteLine("Unique symbols used: {0}", result.ToString().Distinct().Count());
            Console.WriteLine(result);
        }
    }
}