using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.JoroTheFootballPlayer
{
    class JoroTheFootballPlayer
    {
        static void Main()
        {
            string year = Console.ReadLine();
            double numberOfHolidays = double.Parse(Console.ReadLine());
            double weekendsInHomeTown = double.Parse(Console.ReadLine());

            double normalWeekends = 52 - weekendsInHomeTown;
            double gamesDuringHolidays = numberOfHolidays / 2;
            double gamesDuringNormalWeekends = (normalWeekends / 3) * 2;
            double gamesInHisHometown = weekendsInHomeTown;

            double gamesPlayed = gamesDuringHolidays + gamesDuringNormalWeekends + gamesInHisHometown;
            if (year == "t")
            {
                gamesPlayed += 3;
            }
            
            Console.WriteLine(Math.Floor(gamesPlayed));
        }
    }
}
