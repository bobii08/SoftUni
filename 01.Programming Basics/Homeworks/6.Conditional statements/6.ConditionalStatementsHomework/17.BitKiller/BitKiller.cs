using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _17.BitKiller
{
    class BitKiller
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());
            int[] bytes = new int[n];
            for (int i = 0; i < n; i++)
            {
                bytes[i] = int.Parse(Console.ReadLine());
            }

            List<char> listOfBits = new List<char>();
            for (int i = 0; i < n; i++)
            {
                int currentByte = bytes[i];
                string strCurrentByte = Convert.ToString(currentByte, 2).PadLeft(8, '0');
                for (int j = 0; j < strCurrentByte.Length; j++)
                {
                    char currentBit = strCurrentByte[j];
                    listOfBits.Add(currentBit);
                }
            }

            for (int i = 1; i < listOfBits.Count; i += (step - 1))
            {
                listOfBits.RemoveAt(i);
            }

            int lengthArr;
            if (listOfBits.Count % 8 == 0)
            {
                lengthArr = listOfBits.Count / 8;
            }
            else
            {
                lengthArr = (listOfBits.Count / 8) + 1;
            }

            string[] strings = new string[lengthArr];
            for (int i = 0; i < strings.Length; i++)
            {
                strings[i] = string.Empty;
            }

            int position = 0;
            for (int i = 0; i < listOfBits.Count; i++)
            {
                char currentBit = listOfBits[i];
                strings[position] += currentBit;
                if (i % 7 == 0 && i != 0)
                {
                    position++;
                }
            }

            if (strings[lengthArr - 1].Length < 8)
            {
                int zerosToBeAdded = 8 - strings[lengthArr - 1].Length;
                for (int i = 0; i < zerosToBeAdded; i++)
                {
                    strings[lengthArr - 1] += "0";
                }
            }

            foreach (var s in strings)
            {
                Console.WriteLine(Convert.ToInt64(s, 2));
            }
        }
    }
}
