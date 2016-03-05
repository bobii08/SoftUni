namespace _04.PopulationCounter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class PopulationCounter
    {
        private static void Main()
        {
            string line = Console.ReadLine();
            List<Country> countries = new List<Country>();
            while (line != "report")
            {
                string[] args = line.Split('|');
                string cityName = args[0];
                string countryName = args[1];
                long population = long.Parse(args[2]);

                if (countries.FirstOrDefault(c => c.Name == countryName) == null)
                {
                    countries.Add(new Country(countryName));
                }

                var country = countries.FirstOrDefault(c => c.Name == countryName);

                country.AddCity(cityName, population);
                
                line = Console.ReadLine();
            }

            var orderedCountries = countries.OrderByDescending(country => country.TotalPopulation);
            foreach (var orderedCountry in orderedCountries)
            {
                //orderedCountry.OrderCities();
                Console.WriteLine("{0} (total population: {1})", orderedCountry.Name, orderedCountry.TotalPopulation);
                //foreach (var keyValuePair in orderedCountry.Result)
                //{
                //    Console.WriteLine("=>{0}: {1}", keyValuePair.Key, keyValuePair.Value);
                //}

                // the above is another correct way, but more complicated
                var orderedCitiesOfCountry = orderedCountry.Cities.OrderByDescending(kvp => kvp.Value);
                foreach (var keyValuePair in orderedCitiesOfCountry)
                {
                    Console.WriteLine("=>{0}: {1}", keyValuePair.Key, keyValuePair.Value);
                }
            }
        }
    }

    public class Country
    {
        public Country(string name)
        {
            this.Name = name;
            this.Cities = new Dictionary<string, long>();
        }

        public string Name { get; set; }

        public Dictionary<string, long> Cities { get; set; }

        public IOrderedEnumerable<KeyValuePair<string, long>> Result { get; set; }

        public long TotalPopulation { get; set; }

        public void OrderCities()
        {
            this.Result = this.Cities.OrderByDescending(c => c.Value);
        }

        public void AddCity(string name, long population)
        {
            this.Cities.Add(name, population);
            this.TotalPopulation += population;
        }
    }
}