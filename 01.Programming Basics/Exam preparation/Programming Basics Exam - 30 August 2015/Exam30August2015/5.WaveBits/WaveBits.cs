using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.WaveBits
{
    class WaveBits
    {
        static void Main()
        {
            ulong inputNumber = ulong.Parse(Console.ReadLine());
            string numberInBin = Convert.ToString((long)inputNumber, 2);
            int finalStartingIndex = 0; 
            int maxCount = 0;
            for (int index = 0; index < numberInBin.Length; index++)
            {
                int startingIndex = index;
                int currentCount = 0;
                bool startsWith1 = true;
                while (true)
                {
                    bool actionMade = false;
                    if ((index + 2 < numberInBin.Length) && startsWith1)
                    {
                        char firstBit = numberInBin[index];
                        char secondBit = numberInBin[index + 1];
                        char thirdBit = numberInBin[index + 2];
                        if (firstBit == '1' &&
                            secondBit == '0' &&
                            thirdBit == '1' &&
                            startsWith1)
                        {
                            currentCount += 3;
                            index += 3;
                            startsWith1 = false;
                            if (currentCount >= maxCount)
                            {
                                maxCount = currentCount;
                                finalStartingIndex = startingIndex;
                            }
                            actionMade = true;
                        }
                    }
                    else if (index + 1 < numberInBin.Length)
                    {
                        if (numberInBin[index] == '0' &&
                            numberInBin[index + 1] == '1' &&
                            !startsWith1)
                        {
                            currentCount += 2;
                            index += 2;
                            if (currentCount >= maxCount)
                            {
                                maxCount = currentCount;
                                finalStartingIndex = startingIndex;
                            }
                            actionMade = true;
                        }
                    }

                    if(!actionMade)
                    {
                        break;
                    }
                }
            }

            if (maxCount == 0)
            {
                Console.WriteLine("No waves found!");
                return;
            }
            StringBuilder strB = new StringBuilder(numberInBin);
            strB.Remove(finalStartingIndex, maxCount);
            if (strB.Length == 0)
            {
                strB.Append('0');
            }
            string finalNumberInBin = strB.ToString();
            Console.WriteLine(Convert.ToInt64(finalNumberInBin, 2));
        }
    }
}
