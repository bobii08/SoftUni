using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.NewHouse
{
    class NewHouse
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int heightFloor = n;
            int widhtFloor = n;
            int heightRoof = (n / 2) + 1;
            int widthRoof = n;

            int countLeftAndRightDashes = widthRoof / 2;
            int countAsteriks = 1;
            for (int i = 0; i < heightRoof; i++)
            {
                Console.Write(new string('-', countLeftAndRightDashes));
                Console.Write(new string('*', countAsteriks));
                Console.WriteLine(new string('-', countLeftAndRightDashes));
                countLeftAndRightDashes--;
                countAsteriks += 2;
            }

            for (int i = 0; i < heightFloor; i++)
            {
                Console.Write('|');
                Console.Write(new string('*', (widhtFloor - 2)));
                Console.WriteLine('|');
            }
        }
    }
}
