namespace _04.OlympicsAreComing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    internal class OlympicsAreComing
    {
        private static void Main()
        {
            string line = Console.ReadLine();
            string pattern = "\\s+";
            Regex regex = new Regex(pattern);
            List<Country> countries = new List<Country>();
            while (line != "report")
            {
                string[] args = line.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                string athleteName = regex.Replace(args[0], " ").Trim();
                string countryName = regex.Replace(args[1], " ").Trim();

                if (countries.FirstOrDefault(c => c.Name == countryName) == null)
                {
                    countries.Add(new Country(countryName));
                }

                var country = countries.FirstOrDefault(c => c.Name == countryName);

                if (!country.AthletesAndWins.ContainsKey(athleteName))
                {
                    country.AthletesAndWins.Add(athleteName, 0);
                }

                country.AthletesAndWins[athleteName]++;
                country.TotalWins++;

                line = Console.ReadLine();
            }

            var sortedCountries = countries.OrderByDescending(c => c.TotalWins);
            foreach (var sortedCountry in sortedCountries)
            {
                Console.WriteLine("{0} ({1} participants): {2} wins", 
                    sortedCountry.Name,
                    sortedCountry.AthletesAndWins.Count,
                    sortedCountry.TotalWins); // can be replaced with sortedCountry.AthletesAndWins.Sum(aw => aw.Value);
            }
        }
    }

    class Country
    {
        public Country(string name)
        {
            this.Name = name;
            this.AthletesAndWins = new Dictionary<string, long>();
        }

        public Dictionary<string, long> AthletesAndWins { get; set; }

        public string Name { get; set; }

        public long TotalWins { get; set; }
    }
}