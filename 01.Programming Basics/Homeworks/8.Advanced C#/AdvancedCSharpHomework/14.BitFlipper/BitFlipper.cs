using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.BitFlipper
{
    class BitFlipper
    {
        static void Main()
        {
            // moje da trqbva da izpolzvam biginteger
            ulong number = ulong.Parse(Console.ReadLine());
            string binary = Convert.ToString((long)number, 2).PadLeft(64, '0');
            StringBuilder result = new StringBuilder();
            for (int pos = 0; pos < binary.Length; pos++)
            {
                char currentBit = binary[pos];
                if (pos <= binary.Length - 3)
                {
                    if ((currentBit == binary[pos + 1]) && (currentBit == binary[pos + 2]))
                    {
                        if (currentBit == '1')
                        {
                            result.Append("000");
                        }
                        else
                        {
                            result.Append("111");
                        }

                        pos += 2;
                    }
                    else
                    {
                        result.Append(currentBit.ToString());
                    }
                }
                else
                {
                    result.Append(currentBit.ToString());
                }
            }

            ulong resultDecimal = 0;
            int power = 63;
            int position = 0;
            while (true)
            {
                char currentChar = result.ToString()[position];
                resultDecimal += ulong.Parse(currentChar.ToString()) * (ulong)(Math.Pow(2, power));
                power--;
                position++;
                if (position == 64)
                {
                    break;
                }
            }

            Console.WriteLine(resultDecimal);
        }
    }
}
