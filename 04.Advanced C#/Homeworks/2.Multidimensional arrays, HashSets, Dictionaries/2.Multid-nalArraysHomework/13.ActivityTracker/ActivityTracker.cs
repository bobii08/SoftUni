namespace _13.ActivityTracker
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    internal class ActivityTracker
    {
        private static void Main()
        {
            int dataLines = int.Parse(Console.ReadLine());
            string inputLine = string.Empty;
            var database = new SortedDictionary<int, SortedDictionary<string, double>>();
            for (int i = 0; i < dataLines; i++)
            {
                inputLine = Console.ReadLine();
                string[] arguments = inputLine.Split();
                var date = DateTime.ParseExact(arguments[0], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                int month = date.Month;
                string name = arguments[1];
                double distance = double.Parse(arguments[2]);

                if (database.ContainsKey(month))
                {
                    if (database[month].ContainsKey(name))
                    {
                        database[month][name] += distance;
                        continue;
                    }

                    database[month][name] = distance;
                    continue;
                }

                database[month] = new SortedDictionary<string, double>();
                database[month][name] = distance;
            }

            for (int i = 0; i < database.Count; i++)
            {
                int currentMonth = database.ElementAt(i).Key;
                Console.Write(currentMonth + ": ");
                var currentMonthData = database.ElementAt(i);
                var currentMonthNamesData = currentMonthData.Value;
                for (int j = 0; j < currentMonthNamesData.Count; j++)
                {
                    string currentName = currentMonthNamesData.ElementAt(j).Key;
                    double currentDistance = currentMonthNamesData.ElementAt(j).Value;

                    if (j == database.ElementAt(i).Value.Count - 1)
                    {
                        Console.Write(currentName + "(" + currentDistance + ")");
                        break;
                    }

                    Console.Write(currentName + "(" + currentDistance + "), ");
                }

                Console.WriteLine();
            }
        }
    }
}