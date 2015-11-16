using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1.Cinema
{
    class Cinema
    {
        static void Main()
        {
            string typeOfProjection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            int numberOfPeople = rows * columns;
            double price = 0;
            if (typeOfProjection == "Premiere")
            {
                price = 12;
            }
            else if (typeOfProjection == "Normal")
            {
                price = 7.5;
            }
            else
            {
                price = 5;
            }

            Console.WriteLine("{0:0.00} leva", (numberOfPeople * price));
        }
    }
}
