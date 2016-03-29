namespace _03.WordCount
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;

    internal class WordCount
    {
        private static void Main()
        {
            using (var streamReaderWords = new StreamReader("../../words.txt"))
            {
                using (var streamReaderText = new StreamReader("../../text.txt"))
                {
                    using (var streamWriter = new StreamWriter("../../results.txt"))
                    {
                        List<string> words = new List<string>();
                        string word = streamReaderWords.ReadLine();
                        while (word != null)
                        {
                            words.Add(word);
                            word = streamReaderWords.ReadLine();
                        }

                        List<string> textLines = new List<string>();
                        string lineFromText = streamReaderText.ReadLine();
                        while (lineFromText != null)
                        {
                            textLines.Add(lineFromText);
                            lineFromText = streamReaderText.ReadLine();
                        }

                        Dictionary<string, int> wordCountPairs = new Dictionary<string, int>();
                        Regex regex = null;
                        foreach (var currentWord in words)
                        {
                            if (!wordCountPairs.ContainsKey(currentWord))
                            {
                                wordCountPairs.Add(currentWord, 0);
                            }

                            regex = new Regex(string.Format("\\b{0}\\b", currentWord), RegexOptions.IgnoreCase);
                            foreach (var textLine in textLines)
                            {
                                wordCountPairs[currentWord] += regex.Matches(textLine).Count;
                            }
                        }

                        var orderedKeyValuePairs = wordCountPairs.OrderByDescending(kvp => kvp.Value);
                        foreach (var wordCountPair in orderedKeyValuePairs)
                        {
                            string currentWord = wordCountPair.Key;
                            string currentCount = wordCountPair.Value.ToString();
                            streamWriter.WriteLine("{0} - {1}", currentWord, currentCount);
                        }
                    }
                }
            }
        }
    }
}