namespace _08.UseYourChainsBuddy
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.RegularExpressions;

    internal class UseYourChainsBuddy
    {
        private static readonly int positionOfSmallA = 97;

        private static void Main()
        {
            Console.SetIn(new StreamReader(Console.OpenStandardInput(8192)));
            string html = Console.ReadLine();

            string patternForTextBetweenPTags = "(?<=<p>).+?(?=<\\/p>)";
            var regex = new Regex(patternForTextBetweenPTags);
            List<string> texts = new List<string>();

            var matches = regex.Matches(html);
            for (int i = 0; i < matches.Count; i++)
            {
                texts.Add(matches[i].ToString());
            }

            string patternToReplace = "[^a-z0-9]";
            regex = new Regex(patternToReplace);
            for (int i = 0; i < texts.Count; i++)
            {
                texts[i] = regex.Replace(texts[i], " ");
            }

            Dictionary<char, char> aToMLetters = new Dictionary<char, char>();
            Dictionary<char, char> nToZLetters = new Dictionary<char, char>();

            for (int i = positionOfSmallA; i < positionOfSmallA + 13; i++)
            {
                aToMLetters.Add((char)i, (char)(i + 13));
                nToZLetters.Add((char)(i + 13), (char)i);
            }

            regex = new Regex(" {2,}");
            for (int i = 0; i < texts.Count; i++)
            {
                var currentText = texts[i];
                var charArray = new List<char>(currentText);
                for (int j = 0; j < charArray.Count; j++)
                {
                    char currentSymbol = charArray[j];
                    if (currentSymbol >= 'a' && currentSymbol <= 'm')
                    {
                        charArray[j] = aToMLetters[currentSymbol];
                    }
                    else if (currentSymbol >= 'n' && currentSymbol <= 'z')
                    {
                        charArray[j] = nToZLetters[currentSymbol];
                    }
                }

                texts[i] = string.Join(string.Empty, charArray);
                texts[i] = regex.Replace(texts[i], " ");
            }

            Console.WriteLine(string.Join(string.Empty, texts));
        }
    }
}