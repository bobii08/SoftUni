using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Electricity
{
    class Electricity
    {
        private const double LampConsumption = 100.53;
        private const double ComputerConsumption = 125.9;

        static void Main()
        {
            int floors = int.Parse(Console.ReadLine());
            int flats = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            string[] strs = time.Split(':');
            int hours = int.Parse(strs[0]);
            int minutes = int.Parse(strs[1]);
            int totalFlats = floors * flats;

            double consumptionInOneFlat = 0;
            if (hours >= 14 && hours <= 18)
            {
                consumptionInOneFlat += 2 * LampConsumption;
                consumptionInOneFlat += 2 * ComputerConsumption;
            }
            else if (hours >= 19 && hours <= 23)
            {
                consumptionInOneFlat += 7 * LampConsumption;
                consumptionInOneFlat += 6 * ComputerConsumption;
            }
            else if(hours >= 0 && hours <= 8)
            {
                consumptionInOneFlat += LampConsumption;
                consumptionInOneFlat += 8 * ComputerConsumption;
            }

            Console.WriteLine(Math.Floor(totalFlats * consumptionInOneFlat) + " Watts");
            // Console.WriteLine(Math.Round(totalFlats * consumptionInOneFlat, MidpointRounding.AwayFromZero) + " Watts");
        }
    }
}
