namespace _07.QueryMess
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    internal class QueryMess
    {
        private static void Main()
        {
            var lines = new List<string>();
            var keyValuePairs = new Dictionary<string, List<string>>();
            string inputLine = Console.ReadLine();
            while (inputLine != "END")
            {
                lines.Add(inputLine);
                inputLine = Console.ReadLine();
            }

            var patternToReplace = "%20|\\+";
            var patternToReplace2 = " +";
            var patternToRemove1 = ".+\\?";
            var regexToReplace1 = new Regex(patternToReplace);
            var regexToReplace2 = new Regex(patternToReplace2);
            var regetToRemove1 = new Regex(patternToRemove1);
            for (int i = 0; i < lines.Count; i++)
            {
                lines[i] = regetToRemove1.Replace(lines[i], string.Empty);
                string[] currentKeyValuePairs = lines[i].Split(new char[] { '&' }, StringSplitOptions.RemoveEmptyEntries);
                
                for (int j = 0; j < currentKeyValuePairs.Length; j++)
                {
                    var currentKeyValuePair = currentKeyValuePairs[j].Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                    if (currentKeyValuePair.Length < 2)
                    {
                        continue;
                    }
                    var key = currentKeyValuePair[0];
                    var value = currentKeyValuePair[1];

                    key = regexToReplace1.Replace(key, " ").Trim();
                    value = regexToReplace1.Replace(value, " ").Trim();
                    key = regexToReplace2.Replace(key, " ");
                    value = regexToReplace2.Replace(value, " ");
                    if (!keyValuePairs.ContainsKey(key))
                    {
                        keyValuePairs[key] = new List<string>();
                    }
                    
                    keyValuePairs[key].Add(value);
                }

                for (int j = 0; j < keyValuePairs.Count; j++)
                {
                    var currentKeyValuePair = keyValuePairs.ElementAt(j);
                    var currentList = new List<string>();
                    for (int k = 0; k < currentKeyValuePair.Value.Count; k++)
                    {
                        currentList.Add(currentKeyValuePair.Value[k]);
                    }

                    Console.Write(currentKeyValuePair.Key + "=[" + string.Join(", ", currentList) + "]");
                }

                if (i < lines.Count - 1)
                {
                    Console.WriteLine();                    
                }

                keyValuePairs.Clear();
            }
        }
    }
}