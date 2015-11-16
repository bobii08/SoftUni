using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.PandaScotlandFlag
{
    class PandaScotlandFlag
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char[] alphabet =
            {
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 
                'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
            };
            int numbeOfMiddleSymbols = n - 2;
            int numberOfLeftAndRightSymbols = 0;
            int position = 0;
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string('~', numberOfLeftAndRightSymbols));
                Console.Write(alphabet[position++]);
                if (position == 26)
                {
                    position = 0;
                }
                Console.Write(new string('#', numbeOfMiddleSymbols));
                Console.Write(alphabet[position++]);
                if (position == 26)
                {
                    position = 0;
                }
                Console.WriteLine(new string('~', numberOfLeftAndRightSymbols));
                numbeOfMiddleSymbols -= 2;
                numberOfLeftAndRightSymbols++;
            }

            Console.WriteLine(new string('-', n / 2) + alphabet[position++] + new string('-', n / 2));
            numbeOfMiddleSymbols = 1;
            numberOfLeftAndRightSymbols = n/2 - 1;
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string('~', numberOfLeftAndRightSymbols));
                Console.Write(alphabet[position++]);
                if (position == 26)
                {
                    position = 0;
                }
                Console.Write(new string('#', numbeOfMiddleSymbols));
                Console.Write(alphabet[position++]);
                if (position == 26)
                {
                    position = 0;
                }
                Console.WriteLine(new string('~', numberOfLeftAndRightSymbols));
                numbeOfMiddleSymbols += 2;
                numberOfLeftAndRightSymbols--;
            }
        }
    }
}
