using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.GalacticGPS
{
    class GalacticGpsProgram
    {
        static void Main()
        {
            Location home = new Location(18.037986, 28.870097, Planet.Earth);
            Console.WriteLine(home);
            
            Location workOffice = new Location(28.0826, 30.01097, Planet.Earth);
            Console.WriteLine(workOffice);
        }
    }
}
