using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Volleyball
{
    class Volleyball
    {
        private const int WeekendsSuitableForPlay = 48;

        static void Main()
        {
            string year = Console.ReadLine();
            double holidays = double.Parse(Console.ReadLine());
            double weekendsInHomeTown = double.Parse(Console.ReadLine());

            double result = 0;
            result += (2 * holidays) / 3;
            // result += WeekendsSuitableForPlay-weekendsInHomeTown;
            result += (3 * (WeekendsSuitableForPlay - weekendsInHomeTown)) / 4;
            result += weekendsInHomeTown;
            if (year == "leap")
            {
                result += (15 * result) / 100;
            }

            Console.WriteLine(Math.Floor(result));
        }
    }
}
