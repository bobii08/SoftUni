using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.MagicStrings
{
    class MagicStrings
    {
        static void Main()
        {
            int diff = int.Parse(Console.ReadLine());
            int[] arr = new int[4]
            {
                3, 4, 1, 5
            };

            char[] digitsIntoLetters = new char[4]
            {
                's',
                'n',
                'k',
                'p'
            };

            List<string> list = new List<string>();

            for (int i = 0; i < arr.Length; i++)
            {
                int digit = arr[i];
                for (int j = 0; j < arr.Length; j++)
                {
                    int digit2 = arr[j];
                    for (int k = 0; k < arr.Length; k++)
                    {
                        int digit3 = arr[k];
                        for (int l = 0; l < arr.Length; l++)
                        {
                            int digit4 = arr[l];
                            for (int m = 0; m < arr.Length; m++)
                            {
                                int digit5 = arr[m];
                                for (int n = 0; n < arr.Length; n++)
                                {
                                    int digit6 = arr[n];
                                    for (int o = 0; o < arr.Length; o++)
                                    {
                                        int digit7 = arr[o];
                                        for (int p = 0; p < arr.Length; p++)
                                        {
                                            int digit8 = arr[p];
                                            if (Math.Abs((digit + digit2 + digit3 + digit4) - 
                                                (digit5 + digit6 + digit7 + digit8)) == diff)
                                            {
                                                string strToBeAdded = digitsIntoLetters[i] + "" + digitsIntoLetters[j] +
                                                                      digitsIntoLetters[k] + digitsIntoLetters[l] +
                                                                      digitsIntoLetters[m] +
                                                                      digitsIntoLetters[n] + digitsIntoLetters[o] +
                                                                      digitsIntoLetters[p];
                                                list.Add(strToBeAdded);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            if (list.Count == 0)
            {
                Console.WriteLine("No");
                return;
            }

            list.Sort();
            foreach (var str in list)
            {
                Console.WriteLine(str);
            }
        }
    }
}
