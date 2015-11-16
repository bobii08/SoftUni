using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.GrandTheftExamo
{
    class GrandTheftExamo
    {
        private static long totalSlappedThieves = 0;
        private static long totalEscapedThieves = 0;
        private static long totalBeers = 0;

        private static void DoCalculation(long currentThieves, long currentBeers)
        {
            long remainingThieves = 0;
            if (currentThieves >= 5)
            {
                totalSlappedThieves += 5;
                remainingThieves = currentThieves - 5;
            }
            else
            {
                totalSlappedThieves += currentThieves;
                remainingThieves = 0;
            }

            totalEscapedThieves += remainingThieves;
            totalBeers += currentBeers;
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string firstLine = Console.ReadLine();
                string secondLine = Console.ReadLine();

                long thieves = long.Parse(firstLine);
                long beers = long.Parse(secondLine);

                DoCalculation(thieves, beers);
            }

            Console.WriteLine("{0} thieves slapped.", totalSlappedThieves);
            Console.WriteLine("{0} thieves escaped.", totalEscapedThieves);
            Console.WriteLine("{0} packs, {1} bottles.", (totalBeers / 6), (totalBeers % 6));
        }
    }
}
