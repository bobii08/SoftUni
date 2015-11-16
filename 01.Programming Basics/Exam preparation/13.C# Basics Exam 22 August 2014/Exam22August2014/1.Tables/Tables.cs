using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _1.Tables
{
    internal class Tables
    {
        private static void Main()
        {
            BigInteger firstBundle = BigInteger.Parse(Console.ReadLine());
            BigInteger secondBundle = BigInteger.Parse(Console.ReadLine());
            BigInteger thirdBundle = BigInteger.Parse(Console.ReadLine());
            BigInteger fourthBundle = BigInteger.Parse(Console.ReadLine());
            int tablesTopsAvailable = int.Parse(Console.ReadLine());
            int tablesToBeMade = int.Parse(Console.ReadLine());

            BigInteger totalLegsAvailable = firstBundle*1 +
                                            secondBundle*2 +
                                            thirdBundle*3 +
                                            fourthBundle*4;
            BigInteger legsNeeded = tablesToBeMade*4;

            // count tables made
            BigInteger tablesMade = 0;
            BigInteger tablesThatCanBeMadeWithTheLegs = totalLegsAvailable/4;
            if (tablesTopsAvailable == tablesThatCanBeMadeWithTheLegs)
            {
                tablesMade = tablesTopsAvailable;
            }
            else
            {
                tablesMade = Math.Min((long) (tablesTopsAvailable), (long) tablesThatCanBeMadeWithTheLegs);
            }

            BigInteger legsLeft = totalLegsAvailable - legsNeeded;
            if (tablesMade > tablesToBeMade)
            {
                Console.WriteLine("more: {0}", (tablesMade - tablesToBeMade));
                Console.Write("tops left: {0}", (tablesMade - tablesToBeMade));
                Console.WriteLine(", legs left: {0}", legsLeft);
            }

            if (tablesMade < tablesToBeMade)
            {
                Console.WriteLine("less: {0}", (tablesMade - tablesToBeMade));
                Console.Write("tops needed: {0}", tablesToBeMade - tablesMade);
                if (legsLeft < 0)
                {
                    Console.WriteLine(", legs needed: {0}", Math.Abs((long)legsLeft));
                }
                else
                {
                    Console.WriteLine(", legs needed: 0");
                }
            }

            if (tablesMade == tablesToBeMade)
            {
                Console.WriteLine("Just enough tables made: {0}", tablesToBeMade);
            }
        }
    }
}
