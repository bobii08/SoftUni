using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.AgeAfter10Years
{
    class AgeAfter10Years
    {
        static void Main()
        {
            Console.Write("Now: ");
            DateTime yourBirthday = DateTime.Parse(Console.ReadLine());
            Console.Write("After 10 years: ");
            Console.WriteLine(DateTime.Now.Year - yourBirthday.Year);
        }
    }
}
