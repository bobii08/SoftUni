using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.ExamSchedule
{
    class ExamSchedule
    {
        static void Main()
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            string partOfTheDay = Console.ReadLine();
            int durationHours = int.Parse(Console.ReadLine());
            int durationMinutes = int.Parse(Console.ReadLine());

            int endingHour = 0;
            int endingMinutes = 0;
            string endingPartOfTheDay = "";
            if (hour + durationHours <= 11)
            {
                endingHour = hour + durationHours;
                endingPartOfTheDay = partOfTheDay;
            }
            else if (hour + durationHours == 12)
            {
                endingHour = 12;
                if (partOfTheDay == "AM")
                {
                    endingPartOfTheDay = "PM";
                }
                else
                {
                    endingPartOfTheDay = "AM";
                }
            }
            else if (hour + durationHours > 12)
            {
                endingHour = (hour + durationHours) - 12;
                if (partOfTheDay == "AM")
                {
                    endingPartOfTheDay = "PM";
                }
                else
                {
                    endingPartOfTheDay = "AM";
                }
            }

            if (minutes + durationMinutes < 60)
            {
                endingMinutes = minutes + durationMinutes;
            }
            else if (minutes + durationMinutes >= 60)
            {
                endingMinutes = (minutes + durationMinutes) - 60;
                endingHour++;
                if (endingHour == 12)
                {
                    if (partOfTheDay == "AM")
                    {
                        endingPartOfTheDay = "PM";
                    }
                    else
                    {
                        endingPartOfTheDay = "AM";
                    }
                }
                else if (endingHour > 12)
                {
                    endingHour = endingHour - 12;
                    if (partOfTheDay == "AM")
                    {
                        endingPartOfTheDay = "PM";
                    }
                    else
                    {
                        endingPartOfTheDay = "AM";
                    }
                }
            }

            Console.WriteLine("{0}:{1}:{2}", ((endingHour < 10) ? ("0" + endingHour) : endingHour.ToString()),
                ((endingMinutes < 10) ? ("0" + endingMinutes) : endingMinutes.ToString()), endingPartOfTheDay);
        }
    }
}
