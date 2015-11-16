using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.BitKiller
{
    class BitKiller
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());

            int position = 1;
            int toBeAdded = 0;
            StringBuilder strB = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                string currentNumberBin = Convert.ToString(currentNumber, 2).PadLeft(8, '0');
                for (int j = 0; j < currentNumberBin.Length; j++)
                {
                    if (j + toBeAdded != position)
                    {
                        strB.Append(currentNumberBin[j]);
                    }
                    else
                    {
                        position += step;
                    }
                }

                toBeAdded += 8;
            }

            if (strB.Length % 8 != 0)
            {
                strB.Append(new string('0', (8 - strB.Length % 8)));
            }

            int p = 0;
            int count = 0;
            while (p < strB.Length)
            {
                string binaryNumber = strB.ToString().Substring(0, 8);
                Console.WriteLine(Convert.ToInt32(binaryNumber, 2));
                strB.Remove(0, 8);
            }
        }
    }
}
