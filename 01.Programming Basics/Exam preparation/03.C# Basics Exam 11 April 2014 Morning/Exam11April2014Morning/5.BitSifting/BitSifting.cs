using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _5.BitSifting
{
    class BitSifting
    {
        static void Main()
        {
            ulong numberToBeSieved = ulong.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            ulong[] arr = new ulong[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = ulong.Parse(Console.ReadLine());
            }

            string binaryNumberToBeSieved = Convert.ToString((long)numberToBeSieved, 2).PadLeft(64, '0');
            int countOf1Bits = 0;
            bool[] boolArr = new bool[64];
            for (int i = 0; i < boolArr.Length; i++)
            {
                boolArr[i] = true;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                string binaryCurrentNumber = Convert.ToString((long)arr[i], 2).PadLeft(64, '0');
                for (int j = 0; j < binaryCurrentNumber.Length; j++)
                {
                    if (binaryCurrentNumber[j] == '1')
                    {
                        boolArr[j] = false;
                    }
                }
            }

            for (int i = 0; i < binaryNumberToBeSieved.Length; i++)
            {
                char currentBit = binaryNumberToBeSieved[i];
                if (currentBit == '1' && boolArr[i] == true)
                {
                    countOf1Bits++;
                }
            }

            Console.WriteLine(countOf1Bits);
        }
    }
}
