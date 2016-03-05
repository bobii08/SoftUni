using System.Collections.Generic;

namespace PracticeProject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Text.RegularExpressions;

    internal class PracticeProjectProgram
    {
        private static void Main()
        {
            long sum = 0;
            long n = long.Parse(Console.ReadLine());
            bool[] e = new bool[n];//by default they're all false
            for (int i = 2; i < n; i++)
            {
                e[i] = true;//set all numbers to true
            }
            //weed out the non primes by finding mutiples 
            for (int j = 2; j < n; j++)
            {
                if (e[j])//is true
                {
                    for (long p = 2; (p * j) < n; p++)
                    {
                        e[p * j] = false;
                    }
                }
            }

            var result = new List<int>();
            for (int i = 0; i < e.Length; i++)
            {
                if (e[i])
                {
                    result.Add(i);
                }
            }

            Console.WriteLine(string.Join(", ", result));

            long count = long.Parse(Console.ReadLine());
            List<Location> locations = new List<Location>();
            // #([a-zA-Z]+):\s*@([a-zA-Z]+)\s*?([0-9]{1,2}:[0-9]{1,2})
//            string pattern = @"\S*#([a-zA-Z]+):.*@([a-zA-Z]+).*?([0-9]{1,2}:[0-9]{1,2})\S*";

//            string pattern = @"#([a-zA-Z]+):\s*@([a-zA-Z]+)\s*?([0-9]{1,2}:[0-9]{1,2})";
            string pattern = @"^#([a-zA-Z]+):\s*@([a-zA-Z]+)\s*([0-9]+:[0-9]{1,2})$";

            Regex regex = new Regex(pattern);
            for (int i = 0; i < count; i++)
            {
                string line = Console.ReadLine();
                var matches = regex.Matches(line);
                //if (matches.Count >= 1)
                //{
                    foreach (Match match in matches)
                    {
                        string personName = match.Groups[1].Value;
                        string locationName = match.Groups[2].Value;
                        string[] timeArr = match.Groups[3].Value.Split(
                            new char[] { ':' },
                            StringSplitOptions.RemoveEmptyEntries);
                        //if (timeArr.Length >= 2)
                        //{
                            string hour = timeArr[0];
                            string minute = timeArr[1];
                            int hourInt = int.Parse(hour);
                            int minuteInt = int.Parse(minute);
                            if (hourInt < 0 || hourInt > 23 || minuteInt < 0 || minuteInt > 59)
                            {
                                continue;
                            }

                            if (locations.FirstOrDefault(l => l.Name == locationName) == null)
                            {
                                locations.Add(new Location(locationName));
                            }

                            var currentLocation = locations.FirstOrDefault(l => l.Name == locationName);

                            if (currentLocation.Persons.FirstOrDefault(p => p.Name == personName) == null)
                            {
                                currentLocation.Persons.Add(new Person(personName));
                            }

                            var currentPerson = currentLocation.Persons.FirstOrDefault(p => p.Name == personName);
                            if (currentPerson.HourAndMinutes.FirstOrDefault(hm => hm.Hour == hourInt && hm.Minute == minuteInt) == null)
                            {
                                currentPerson.HourAndMinutes.Add(new HourAndMinute(hourInt, minuteInt));
                            }

                            //var currentHourAndMinute = currentPerson.HourAndMinutes.FirstOrDefault(hm => hm.Hour == hourInt && hm.Minute == hm.Minute);
                        //}
                    //}
                }
            }

            List<string> validLocations = Console.ReadLine().Split(new char[] { ',', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var orderedLocations = locations.OrderBy(l => l.Name);
            foreach (var location in orderedLocations)
            {
                string locName = location.Name;
                if (validLocations.Contains(locName))
                {
                    Console.WriteLine("{0}:", locName);
                    int personNum = 1;
                    var orderedPersons = location.Persons.OrderBy(p => p.Name); //!
                    foreach (var person in orderedPersons)
                    {
                        string personName = person.Name;
                        Console.Write("{0}. {1} -> ", personNum, personName);
                        personNum++;
                        List<HourAndMinute> currentHourAndMinutes = new List<HourAndMinute>();
                        var orderedHourAndMin = person.HourAndMinutes.OrderBy(ham => ham.Hour).ThenBy(ham => ham.Minute);
                        foreach (var hourAndMinute in orderedHourAndMin)
                        {
                            currentHourAndMinutes.Add(hourAndMinute);
                        }

                        Console.WriteLine(string.Join(", ", currentHourAndMinutes));
                    }
                }
            }
        }
    }

    public class Location
    {
        public Location(string name)
        {
            this.Name = name;
            this.Persons = new List<Person>();
        }

        public string Name { get; set; }

        public List<Person> Persons { get; set; }
    }

    public class Person
    {
        public Person(string name)
        {
            this.Name = name;
            this.HourAndMinutes = new List<HourAndMinute>();
        }

        public string Name { get; set; }

        public List<HourAndMinute> HourAndMinutes { get; set; }
    }

    public class HourAndMinute
    {
        public HourAndMinute(int hour, int minute)
        {
            this.Hour = hour;
            this.Minute = minute;
        }

        public int Hour { get; set; }

        public int Minute { get; set; }

        public override string ToString()
        {
            return this.Hour + ":" + (this.Minute < 10 ? "0" + this.Minute : this.Minute.ToString());
        }
    }
}