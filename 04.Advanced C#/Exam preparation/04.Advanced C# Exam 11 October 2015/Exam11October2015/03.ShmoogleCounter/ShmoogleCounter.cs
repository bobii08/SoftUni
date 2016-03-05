namespace _03.ShmoogleCounter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    internal class ShmoogleCounter
    {
        private static void Main(string[] args)
        {
            List<string> lines = new List<string>();
            string line = Console.ReadLine();
            while (line != "//END_OF_CODE")
            {
                lines.Add(line);
                line = Console.ReadLine();
            }

            string pattern = @"(double|int) ([^A-Z][\w]*)[ ;),]";
            Regex regex = new Regex(pattern);
            List<string> doubles = new List<string>();
            List<string> ints = new List<string>();
            for (int i = 0; i < lines.Count; i++)
            {
                string currentLine = lines[i];
                var matches = regex.Matches(currentLine);
                if (matches.Count > 0)
                {
                    foreach (Match match in matches)
                    {
                        string dataType = match.Groups[1].Value;
                        string identifier = match.Groups[2].Value;
                        if (dataType == "double")
                        {
                            doubles.Add(identifier);
                        }
                        else
                        {
                            ints.Add(identifier);
                        }
                    }
                }
            }

            doubles.Sort();
            ints.Sort();
            Console.WriteLine("   ");
            Console.WriteLine("\t");
            if (!doubles.Any())
            {
                Console.WriteLine("Doubles: None");
            }
            else
            {
                Console.WriteLine("Doubles: {0}", string.Join(", ", doubles));
            }

            if (!ints.Any())
            {
                Console.WriteLine("Ints: None");
            }
            else
            {
                Console.WriteLine("Ints: {0}", string.Join(", ", ints));
            }
            Console.WriteLine("   ");
            Console.WriteLine("\t");
        }
    }
}