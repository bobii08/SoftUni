using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.BitsUp
{
    class BitsUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());
            int[] bytes = new int[n];
            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] = int.Parse(Console.ReadLine());
            }

            char[] bits = new char[8 * n];
            int positionInBits = 0;
            for (int i = 0; i < bytes.Length; i++)
            {
                int number = bytes[i];
                string numberInBin = Convert.ToString(number, 2).PadLeft(8, '0');
                for (int j = 0; j < numberInBin.Length; j++)
                {
                    bits[positionInBits] = numberInBin[j];
                    positionInBits++;
                }
            }

            for (int i = 1; i < bits.Length; i += step)
            {
                bits[i] = '1';
            }

            int[] newBytes = new int[n];
            int newBytesCount = 0;
            for (int i = 0; i < bits.Length; i += 8)
            {
                StringBuilder strBuilder = new StringBuilder();
                for (int j = i; j < i + 8; j++)
                {
                    strBuilder.Append(bits[j]);
                }

                newBytes[newBytesCount] = Convert.ToInt32(strBuilder.ToString(), 2);
                newBytesCount++;
            }

            foreach (var newByte in newBytes)
            {
                Console.WriteLine(newByte);
            }
        }
    }
}
