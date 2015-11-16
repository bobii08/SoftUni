using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.GravitationOnTheMoon
{
    class GravitationOnTheMoon
    {
        static void Main()
        {
            Console.Write("Weight on the Earth: ");
            double weightOnTheEarth = double.Parse(Console.ReadLine());
            double weightOnTheMoon = (17 * weightOnTheEarth) / 100;
            Console.WriteLine("Weight on the Moon: {0}", weightOnTheMoon);
        }
    }
}
