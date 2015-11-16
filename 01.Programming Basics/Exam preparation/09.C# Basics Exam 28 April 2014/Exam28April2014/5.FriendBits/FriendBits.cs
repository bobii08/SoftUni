using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.FriendBits
{
    class FriendBits
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());
            string numberBin = Convert.ToString(n, 2);
            StringBuilder friendBits = new StringBuilder();
            StringBuilder aloneBits = new StringBuilder();

            for (int i = 0; i < numberBin.Length; i++)
            {
                char currentBit = numberBin[i];
                int currentCount = 1;
                while (i < numberBin.Length)
                {
                    if (i == numberBin.Length - 1)
                    {
                        if (currentCount > 1)
                        {
                            for (int j = 0; j < currentCount; j++)
                            {
                                friendBits.Append(currentBit);
                            }
                        }
                        else
                        {
                            aloneBits.Append(currentBit);
                        }

                        break;
                    }
                    if (currentBit == numberBin[i + 1])
                    {
                        currentCount++;
                        i++;
                    }
                    else
                    {
                        if (currentCount > 1)
                        {
                            for (int j = 0; j < currentCount; j++)
                            {
                                friendBits.Append(currentBit);
                            }
                        }
                        else
                        {
                            aloneBits.Append(currentBit);
                        }
                        break;
                    }
                }
            }

            if (friendBits.Length > 0)
            {
                Console.WriteLine(Convert.ToInt32(friendBits.ToString(), 2));    
            }
            else
            {
                Console.WriteLine(0);
            }
            if (aloneBits.Length < 1)
            {
                Console.WriteLine(0);
                return;
            }
            Console.WriteLine(Convert.ToInt32(aloneBits.ToString(), 2));
        }
    }
}
