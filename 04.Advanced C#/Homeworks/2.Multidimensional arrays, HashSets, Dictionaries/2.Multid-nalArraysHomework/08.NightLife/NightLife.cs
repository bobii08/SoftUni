namespace _08.NightLife
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class NightLife
    {
        private static void Main()
        {
            var database = new Dictionary<string, SortedDictionary<string, SortedSet<string>>>();
            string line = Console.ReadLine();

            while (line != "END")
            {
                string[] args = line.Split(';');
                string city = args[0];
                string venue = args[1];
                string performer = args[2];

                if (!database.ContainsKey(city))
                {
                    var performers = new SortedSet<string>();
                    performers.Add(performer);
                    var venueWithPerformers = new SortedDictionary<string, SortedSet<string>>();
                    venueWithPerformers.Add(venue, performers);
                    database[city] = venueWithPerformers;
                }
                else
                {
                    if (!database[city].ContainsKey(venue))
                    {
                        var performers = new SortedSet<string>();
                        performers.Add(performer);
                        database[city].Add(venue, performers);
                        database[city][venue] = performers;
                    }
                    else
                    {
                        database[city][venue].Add(performer);
                    }
                }

                line = Console.ReadLine();
            }

            for (int i = 0; i < database.Count; i++)
            {
                var currentCityWithVenues = database.ElementAt(i);
                Console.WriteLine(currentCityWithVenues.Key);
                for (int j = 0; j < currentCityWithVenues.Value.Count; j++)
                {
                    var currentVenue = currentCityWithVenues.Value.ElementAt(j);
                    Console.WriteLine("->" + currentVenue.Key + ":" + string.Join(", ", currentVenue.Value));
                }
            }
        }
    }
}