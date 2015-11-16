using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _5.CatchTheBits
{
    class CatchTheBits
    {
        static void Main()
        {
            byte n = byte.Parse(Console.ReadLine());
            byte step = byte.Parse(Console.ReadLine());
            byte[] bytes = new byte[n];
            for (int i = 0; i < n; i++)
            {
                bytes[i] = byte.Parse(Console.ReadLine());
            }

            StringBuilder strB = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                byte currentByte = bytes[i];
                string currentByteStrToBin = Convert.ToString(currentByte, 2).PadLeft(8, '0');
                for (int j = 0; j < currentByteStrToBin.Length; j++)
                {
                    strB.Append(currentByteStrToBin[j]);
                }
            }

            StringBuilder newStrB = new StringBuilder();
            for (int i = 1; i < strB.Length; i += step)
            {
                newStrB.Append(strB[i]);
            }
        }
    }
}
