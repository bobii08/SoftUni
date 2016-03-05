namespace _04.SrabskoUnleashed
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    //  Lepa Brena @Sunny Beach 25 3500
    //  Dragana @Sunny Beach 23 3500
    //  Ceca @Sunny Beach 28 3500
    //  Mile Kitic @Sunny Beach 21 3500
    //  Ceca @Sunny Beach 35 3500
    //  Ceca @Sunny Beach 70 15000
    //  Saban Saolic @Sunny Beach 120 35000
    //End


    internal class SrabskoUnleashed
    {
        private static void Main()
        {
            string line = Console.ReadLine();

            Dictionary<string, List<Singer>> data = new Dictionary<string, List<Singer>>();
            string pattern =
                @"(\D+)\s@(\D+)\s(\d+)\s(\d+)";
            Regex regex = new Regex(pattern);
            while (line != "End")
            {
                if (regex.IsMatch(line))
                {
                    var match = regex.Match(line);
                    string singerName = match.Groups[1].Value;
                    string venueName = match.Groups[2].Value;
                    long ticketsPrice = long.Parse(match.Groups[3].Value);
                    long ticketsCount = long.Parse(match.Groups[4].Value);

                    if (!data.ContainsKey(venueName))
                    {
                        data[venueName] = new List<Singer>();
                    }
                    
                    if (data[venueName].FirstOrDefault(s => s.Name == singerName) == null)
                    {
                        data[venueName].Add(new Singer(singerName, 0));
                    }

                    var venue = data[venueName];
                    var singer = venue.FirstOrDefault(s => s.Name == singerName);
                    singer.Money += ticketsPrice * ticketsCount;
                }

                line = Console.ReadLine();
            }

            foreach (var venueData in data)
            {
                Console.WriteLine(venueData.Key);
                var orderedSingersByDesc = venueData.Value.OrderByDescending(s => s.Money);
                foreach (var singer in orderedSingersByDesc)
                {
                    Console.WriteLine("#  {0} -> {1}", singer.Name, singer.Money);
                }
            }
        }
    }

    class Singer
    {
        public Singer(string name, long money)
        {
            this.Name = name;
            this.Money = money;
        }

        public string Name { get; set; }

        public long Money { get; set; }
    }
}