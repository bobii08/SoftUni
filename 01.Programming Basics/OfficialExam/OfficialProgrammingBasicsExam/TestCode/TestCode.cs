using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCode
{
    class TestCode
    {
        static void Main()
        {
            ulong totalScore = 0;
            ulong totalLightsOn = 0;
            string fistLine = Console.ReadLine();
            string secondLine = Console.ReadLine();
            int[] positions = secondLine.Split().Select(int.Parse).ToArray();
            uint number = uint.Parse(fistLine);
            string numberInBin = Convert.ToString(number, 2).PadLeft(32, '0');

            char[] bits = new char[32];
            for (int i = 0; i < numberInBin.Length; i++)
            {
                bits[i] = numberInBin[i];
            }

            while (true)
            {
                for (int i = 0; i < positions.Length; i++)
                {
                    int currentPosition = positions[i];
                    if (bits[bits.Length - currentPosition - 1] == '1')
                    {
                        bits[bits.Length - currentPosition - 1] = '0';
                    }
                    else
                    {
                        bits[bits.Length - currentPosition - 1] = '1';
                    }
                }

                StringBuilder strB = new StringBuilder();
                foreach (var bit in bits)
                {
                    strB.Append(bit);
                }

                totalScore += Convert.ToUInt64(strB.ToString(), 2);
                for (int i = 0; i < bits.Length; i++)
                {
                    if (bits[i] == '1')
                    {
                        totalLightsOn++;
                    }
                }

                fistLine = Console.ReadLine();
                if (fistLine == "Stop, God damn it")
                {
                    break;
                }
                secondLine = Console.ReadLine();
                positions = secondLine.Split().Select(int.Parse).ToArray();
                number = uint.Parse(fistLine);
                numberInBin = Convert.ToString(number, 2).PadLeft(32, '0');
                bits = new char[32];
                for (int i = 0; i < numberInBin.Length; i++)
                {
                    bits[i] = numberInBin[i];
                }
            }

            Console.WriteLine("Bohemcho left {0} lights on and his score is {1}", totalLightsOn, totalScore);
        }
    }
}
