using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.BeerTime
{
    class BeerTime
    {
        static void Main()
        {
            Console.WriteLine("Enter time in the following format: hh:mm tt (1:00 PM for example)");
            string time = Console.ReadLine();
            int indexOfColumn = time.IndexOf(":");
            string hours = time.Substring(0, indexOfColumn);
            string minutes = time.Substring(indexOfColumn + 1, 2);
            int indexOfWhiteSpace = time.IndexOf(" ");
            string designator = time.Substring(indexOfWhiteSpace + 1, 2);

            int intHours = int.Parse(hours);
            int intMinutes = int.Parse(minutes);

            if (intHours < 1 || intHours > 12 ||
                intMinutes < 0 || intMinutes > 59 || 
                (designator != "AM" && designator != "PM"))
            {
                Console.WriteLine("invalid time");
                return;
            }

            bool beerTime = false;

            if (designator == "PM")
            {
                if (intHours > 1 && intHours <= 11)
                {
                    beerTime = true;
                }
            }
            else if (designator == "AM")
            {
                if (intHours == 12 || (intHours >= 1 && intHours < 3))
                {
                    beerTime = true;
                }
            }

            Console.WriteLine(beerTime ? "beer time" : "non-beer time");
        }
    }
}
