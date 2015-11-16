using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.SequenceOfKNumbers
{
    class SequenceOfKNumbers
    {
        static void Main()
        {
            string strNumbers = Console.ReadLine();
            int k = int.Parse(Console.ReadLine());
            List<int> listOfNumbers = strNumbers.Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                int currentCount = 1;
                while (true)
                {
                    if (i == listOfNumbers.Count - 1)
                    {
                        if (currentCount < k)
                        {
                            char charToBePrinted = listOfNumbers[i].ToString()[0];
                            for (int j = 0; j < currentCount; j++)
                            {
                                Console.Write(listOfNumbers[i] + " ");
                            }

                            break;
                        }
                        else if (currentCount == k)
                        {
                            break;
                        }
                        else
                        {
                            int numbersLeft = currentCount % k;
                            char charToBePrinted = listOfNumbers[i].ToString()[0];
                            for (int j = 0; j < numbersLeft; j++)
                            {
                                Console.Write(listOfNumbers[i] + " ");
                            }

                            break;
                        }
                    }
                    if (listOfNumbers[i] == listOfNumbers[i + 1])
                    {
                        currentCount++;
                        i++;
                    }
                    else
                    {
                        if (currentCount < k)
                        {
                            char charToBePrinted = listOfNumbers[i].ToString()[0];
                            for (int j = 0; j < currentCount; j++)
                            {
                                Console.Write(listOfNumbers[i] + " ");
                            }

                            break;
                        }
                        else if (currentCount == k)
                        {
                            break;
                        }
                        else
                        {
                            int numbersLeft = currentCount % k;
                            char charToBePrinted = listOfNumbers[i].ToString()[0];
                            for (int j = 0; j < numbersLeft; j++)
                            {
                                Console.Write(listOfNumbers[i] + " ");
                            }

                            break;
                        }
                    }
                }
            }
        }
    }
}
