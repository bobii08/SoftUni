using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.MorseCodeNumbers
{
    class MorseCodeNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int firstDigit = n / 1000;
            int secondDigit = (n / 100) % 10;
            int thirdDigit = (n / 10) % 10;
            int fourthDigit = n % 10;
            int nSum = firstDigit + secondDigit + thirdDigit + fourthDigit;

            string[] arr =
            {
                "-----",
                ".----",
                "..---",
                "...--",
                "....-",
                "....."
            };

            int count = 0;
            for (int i = 0; i <= 5; i++)
            {
                if (i == 0)
                {
                    if (nSum != 0)
                    {
                        continue;
                    }
                }
                for (int j = 0; j <= 5; j++)
                {
                    if (j == 0)
                    {
                        if (nSum != 0)
                        {
                            continue;
                        }
                    }
                    for (int k = 0; k <= 5; k++)
                    {
                        if (k == 0)
                        {
                            if (nSum != 0)
                            {
                                continue;
                            }
                        }
                        for (int l = 0; l <= 5; l++)
                        {
                            if (l == 0)
                            {
                                if (nSum != 0)
                                {
                                    continue;
                                }
                            }
                            for (int m = 0; m <= 5; m++)
                            {
                                if (m == 0)
                                {
                                    if (nSum != 0)
                                    {
                                        continue;
                                    }
                                }
                                for (int o = 0; o <= 5; o++)
                                {
                                    if (o == 0)
                                    {
                                        if (nSum != 0)
                                        {
                                            continue;
                                        }
                                    }
                                    int product = i * j * k * l * m * o;
                                    if (product == nSum)
                                    {
                                        Console.WriteLine(arr[i] + "|" + arr[j] + "|" + arr[k] + "|" +
                                            arr[l] + "|" + arr[m] + "|" + arr[o] + "|");
                                        count++;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            if (count == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
