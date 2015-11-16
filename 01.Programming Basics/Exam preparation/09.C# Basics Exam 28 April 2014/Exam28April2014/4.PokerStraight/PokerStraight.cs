using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.PokerStraight
{
    class PokerStraight
    {
        static void Main()
        {
            long weight = long.Parse(Console.ReadLine());
            string[] faces =
            {
                "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"
            };
            int[] facesWeighs =
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14
            };
            string[] suits =
            {
                "C", "D", "H", "S"
            };
            int[] suitsWeights =
            {
                1, 2, 3, 4
            };

            int result = 0;
            string firstCard = String.Empty;
            string secondCard = String.Empty;
            string thirdCard = String.Empty;
            string fourthCard = String.Empty;
            string fifthCard = String.Empty;
            for (int i = 0; i < faces.Length - 4; i++)
            {
                for (int j = 0; j < suits.Length; j++)
                {
                    firstCard = faces[i] + suits[j];
                    for (int k = i + 1; k < faces.Length - 3; k++)
                    {
                        for (int l = 0; l < suits.Length; l++)
                        {
                            secondCard = faces[k] + suits[l];
                            for (int m = k + 1; m < faces.Length - 2; m++)
                            {
                                for (int n = 0; n < suits.Length; n++)
                                {
                                    thirdCard = faces[m] + suits[n];
                                    for (int o = m + 1; o < faces.Length - 1; o++)
                                    {
                                        for (int p = 0; p < suits.Length; p++)
                                        {
                                            fourthCard = faces[o] + suits[p];
                                            for (int q = o + 1; q < faces.Length; q++)
                                            {
                                                for (int r = 0; r < suits.Length; r++)
                                                {
                                                    fifthCard = faces[q] + suits[r];
                                                    long firstCardWeight = 10 * facesWeighs[i] + suitsWeights[j];
                                                    long secondCardWeight = 20 * facesWeighs[k] + suitsWeights[l];
                                                    long thirdCardWeight = 30 * facesWeighs[m] + suitsWeights[n];
                                                    long fourthCardWeight = 40 * facesWeighs[o] + suitsWeights[p];
                                                    long fifthCardWeight = 50 * facesWeighs[q] + suitsWeights[r];
                                                    long totalWeight = firstCardWeight + secondCardWeight +
                                                                      thirdCardWeight +
                                                                      fourthCardWeight + fifthCardWeight;
                                                    if (totalWeight == weight && (q - o == 1) && (o - m == 1) &&
                                                        (m - k == 1) && (k - i == 1))
                                                    {
                                                        //Console.WriteLine("({0} {1} {2} {3} {4})",
                                                        //  firstCard, secondCard, thirdCard, fourthCard, fifthCard);
                                                        result++;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
