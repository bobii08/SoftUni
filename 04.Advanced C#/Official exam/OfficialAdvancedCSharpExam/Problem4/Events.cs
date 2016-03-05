namespace Problem4
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    internal class Events
    {
        private static void Main()
        {
            // moje da napravish edin masiv ot validni stoinosti za chasovete i minutitte
            int count = int.Parse(Console.ReadLine());
            SortedDictionary<string, SortedDictionary<string, SortedSet<string>>> data =
                new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();
            // #([a-zA-Z]+):\s*@([a-zA-Z]+)\s*?([0-9]{1,2}:[0-9]{1,2})
            // #([a-zA-Z]+):.*@([a-zA-Z]+).*?([0-9]{1,2}:[0-9]{1,2})
            string pattern = @"\S*#([a-zA-Z]+):\s*@([a-zA-Z]+)\s*([0-9]{1,2}:[0-9]{1,2})\S*";
            Regex regex = new Regex(pattern);
            for (int i = 0; i < count; i++)
            {
                string line = Console.ReadLine();
                var match = regex.Match(line);
                
                if (regex.IsMatch(line) && match.Groups.Count >= 4)
                {
                    string personName = match.Groups[1].Value;
                    string townName = match.Groups[2].Value;
                    string time = match.Groups[3].Value;

                    if (!data.ContainsKey(townName))
                    {
                        data[townName] = new SortedDictionary<string, SortedSet<string>>();
                    }

                    if (!data[townName].ContainsKey(personName))
                    {
                        data[townName][personName] = new SortedSet<string>();
                    }

                    //if (!data[townName][personName].Contains(time))
                    //{
                    //    data[townName][personName].Add(time);
                    //}

                    data[townName][personName].Add(time);

                    //data[townName][personName][hourInt] = minuteInt;

                    //if (data[townName][personName].ContainsKey(hourInt))
                    //{
                    //    if (data[townName][personName].ContainsValue(minuteInt))
                    //    {
                    //        continue;
                    //    }
                    //    else
                    //    {
                    //        data[townName][personName].Add(hourInt, minuteInt);
                    //    }
                    //}

                    //data[townName][personName].Add(hourInt, minuteInt);

                }

            }

            List<string> locations =
                Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            foreach (var town in data)
            {
                string townName = town.Key;
                if (locations.Contains(townName))
                {
                    Console.WriteLine("{0}:", townName);
                    int currentPerson = 1;
                    foreach (var person in town.Value)
                    {
                        string personName = person.Key;
                        Console.Write("{0}. {1} -> ", currentPerson, personName);
                        currentPerson++;
                        // var sortedTimes = person.Value.OrderBy(sth => sth.Key).ThenBy(sth => sth.Value);

                        SortedSet<string> times = new SortedSet<string>();
                        foreach (var hourAndMinute in person.Value)
                        {
                            times.Add(hourAndMinute);
                        }

                        Console.WriteLine(string.Join(", ", times));
                    }
                }
            }
        }
    }
}