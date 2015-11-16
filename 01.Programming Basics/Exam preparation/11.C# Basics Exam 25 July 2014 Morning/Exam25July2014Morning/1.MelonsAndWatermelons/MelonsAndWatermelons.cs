using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.MelonsAndWatermelons
{
    class MelonsAndWatermelons
    {
        static void Main()
        {
            int s = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            if (d == 0)
            {
                Console.WriteLine("Equal amount: 0");
                return;
            }

            int countOfWatermelons = 0;
            int countOfMelons = 0;
            for (int i = s; i < s + d; i++)
            {
                int remainder = i % 7;
                switch (remainder)
                {
                    case 1:
                        countOfWatermelons++;
                        break;
                    case 2:
                        countOfMelons += 2;
                        break;
                    case 3:
                        countOfWatermelons++;
                        countOfMelons++;
                        break;
                    case 4:
                        countOfWatermelons += 2;
                        break;
                    case 5:
                        countOfWatermelons += 2;
                        countOfMelons += 2;
                        break;
                    case 6:
                        countOfWatermelons++;
                        countOfMelons += 2;
                        break;
                }
            }

            if (countOfWatermelons > countOfMelons)
            {
                Console.WriteLine("{0} more watermelons", countOfWatermelons - countOfMelons);
            }
            else if (countOfMelons > countOfWatermelons)
            {
                Console.WriteLine("{0} more melons", countOfMelons - countOfWatermelons);
            }
            else
            {
                Console.WriteLine("Equal amount: {0}", countOfWatermelons);
            }
        }
    }
}
