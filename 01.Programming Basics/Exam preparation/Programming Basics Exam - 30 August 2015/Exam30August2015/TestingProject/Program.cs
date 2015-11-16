using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _5.WaveBits
{
    class WaveBits
    {
        static void Main()
        {
            ulong inputNumber = ulong.Parse(Console.ReadLine());
            string numberInBin = Convert.ToString((long)inputNumber, 2).PadLeft(32, '0');

            int finalStartingIndex = 0;
            int maxCount = 0;
            for (int index = 0; index < numberInBin.Length; index++)
            {
                int startingIndex = index;
                int currentCount = 0;
                bool startsWith1 = true;
                while (true)
                {
                    char firstBit = numberInBin[index];
                    char secondBit = numberInBin[index + 1];
                    char thirdBit = numberInBin[index + 2];
                    bool actionMade = false;
                    try
                    {
                        if (firstBit == '1' &&
                        secondBit == '0' &&
                        thirdBit == '1' &&
                        startsWith1)
                        {
                            currentCount += 3;
                            index += 3;
                            startsWith1 = false;
                            actionMade = true;
                            if (currentCount >= maxCount)
                            {
                                maxCount = currentCount;
                                finalStartingIndex = startingIndex;
                            }
                        }

                        if (numberInBin[index] == '0' &&
                            numberInBin[index + 1] == '1' &&
                            !startsWith1)
                        {
                            currentCount += 2;
                            index += 2;
                            actionMade = true;
                            if (currentCount >= maxCount)
                            {
                                maxCount = currentCount;
                                // finalStartingIndex = startingIndex;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        break;
                        throw;
                    }
                    if (!actionMade)
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
            string finalNumberInBin = strB.ToString();
            Console.WriteLine(Convert.ToInt64(finalNumberInBin, 2));
        }
    }
}
