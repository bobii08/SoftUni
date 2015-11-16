using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace _1.ExamSchedule
{
    class ExamSchedule
    {
        static void Main()
        {
            int startHour = int.Parse(Console.ReadLine());
            int startMinutes = int.Parse(Console.ReadLine());
            string partOfTheDay = Console.ReadLine();
            int durationHours = int.Parse(Console.ReadLine());
            int durationMinutes = int.Parse(Console.ReadLine());

            if (startHour == 12 && partOfTheDay == "AM")
            {
                startHour = 0;
            }
            else if (startHour != 12 && partOfTheDay == "PM")
            {
                startHour += 12;
            }

            int finalHour = startHour + durationHours;
            int finalMinutes = startMinutes + durationMinutes;

            if (finalMinutes > 60)
            {
                finalHour += 1;
                finalMinutes -= 60;
            }

            if (finalHour > 12 && finalHour < 24)
            {
                finalHour = finalHour - 12;
                if (partOfTheDay == "AM")
                {
                    partOfTheDay = "PM";
                }
                else
                {
                    partOfTheDay = "AM";
                }
            }
            else if (finalHour > 24)
            {
                finalHour = finalHour - 36;
            }

            if (partOfTheDay == "AM" && finalHour == 0)
            {
                Console.WriteLine(12 + ":" + ((finalMinutes < 10) ? ("0" + finalMinutes) : finalMinutes.ToString()) +
                                  ":" +
                                  partOfTheDay);
            }
            else
            {
                Console.WriteLine(((finalHour >= 1 && finalHour <= 11)
                    ? ("0" + finalHour)
                    : ((finalHour > 12)
                        ? ("0" + (finalHour - 12))
                        : finalHour.ToString())) + ":" +
                                  ((finalMinutes < 10) ? ("0" + finalMinutes) : finalMinutes.ToString()) + ":" +
                                  partOfTheDay);
            }
        }
    }
}
