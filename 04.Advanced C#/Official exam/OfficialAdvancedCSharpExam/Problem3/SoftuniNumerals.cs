namespace Problem3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Numerics;

    internal class SoftuniNumerals
    {
        private static void Main()
        {
            // Use BigInteger
            // probvai da chetesh stringa otzad napred
            // probvai da vyrtish cikyl kogato izchislqvash stepenta na chislo
            List<string> symbols = new List<string>() { "aa", "aba", "bcc", "cc", "cdc" };
            
            string inputLine = Console.ReadLine();
            StringBuilder strB = new StringBuilder();
            for (int i = 0; i < inputLine.Length; i++)
            {
                char currentChar = inputLine[i];
                char nextChar = inputLine[i + 1];
                string str = currentChar + "" + nextChar;
                if (symbols.Contains(str))
                {
                    strB.Append(symbols.IndexOf(str));
                    i++;
                }
                else
                {
                    i = i + 2;
                    str += inputLine[i];
                    strB.Append(symbols.IndexOf(str));
                }
            }

            BigInteger count = 0;
            BigInteger result = 0;
            for (int i = strB.ToString().Length - 1; i >= 0; i--)
            {
                char currentChar = strB[i];
                int num = int.Parse(currentChar.ToString());
                BigInteger numToMultiply = 1;
                for (int j = 0; j < count; j++)
                {
                    numToMultiply *= 5;
                }

                if (num != 0)
                {
                    //result += (BigInteger)num * (BigInteger)Math.Pow(5, (double)count); -> ne dava vsichki tochki
                    result += (BigInteger)num * numToMultiply;
                }

                count++;
            }

            Console.WriteLine(result);
        }
    }
}