using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.WorkHours
{
    class WorkHours
    {
        static void Main()
        {
            double h = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());

            double totalWorkHours = d * 12;
            double actualWorkHours = totalWorkHours * 0.9;
            double hoursSpentInWorking = actualWorkHours * (p / 100);

            if (hoursSpentInWorking >= h)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            Console.WriteLine(Math.Floor(hoursSpentInWorking - h));
        }
    }
}
