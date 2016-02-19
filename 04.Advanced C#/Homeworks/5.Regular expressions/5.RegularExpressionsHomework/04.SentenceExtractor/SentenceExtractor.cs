namespace _04.SentenceExtractor
{
    using System;
    using System.Text.RegularExpressions;

    internal class SentenceExtractor
    {
        private static void Main()
        {
            string text =
                "This is my cat! And this is my dog. We happily live in Paris – the most beautiful city in the world! Isn’t it great? Well it is. Is this what you want?";
            string keyword = Console.ReadLine();

            // string text = Console.ReadLine();
            string pattern = "\\b.*?[?.!]";
            Regex regex = new Regex(pattern);
            var matches = regex.Matches(text);
            string keywordInTheBeginning = keyword[0].ToString().ToUpper() + keyword.Substring(1) + " ";
            keyword = " " + keyword;
            Console.WriteLine("Text: {0}", text);
            Console.WriteLine();
            Console.WriteLine("Matches");
            foreach (Match match in matches)
            {
                if (match.ToString().Contains(keyword) || match.ToString().Contains(keywordInTheBeginning))
                {
                    Console.WriteLine(match);
                }
            }
        }
    }
}