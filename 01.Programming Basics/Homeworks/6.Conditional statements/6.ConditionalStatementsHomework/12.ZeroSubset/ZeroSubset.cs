using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ZeroSubset
{
    class ZeroSubset
    {
        static void Main()
        {
            string numbersString = Console.ReadLine();
            string[] numbersArr = numbersString.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
            int[] arr = new int[numbersArr.Length];
            int p = 0;
            foreach (var str in numbersArr)
            {
                arr[p] = int.Parse(str);
                p++;
            }

            Console.WriteLine("Sequences of numbers which some is 0");
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int currentFirstNumber = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int currentSecondNumber = arr[j];
                    if (currentFirstNumber + currentSecondNumber == 0)
                    {
                        Console.WriteLine(currentFirstNumber + " + " + currentSecondNumber + " = 0");
                    }
                }
            }

            for (int i = 0; i < arr.Length - 2; i++)
            {
                int fNum = arr[i];
                for (int j = i + 1; j < arr.Length - 1; j++)
                {
                    int sNum = arr[j];
                    for (int k = j + 1; k < arr.Length; k++)
                    {
                        int tNum = arr[k];
                        if (fNum + sNum + tNum == 0)
                        {
                            Console.WriteLine(fNum + " + " + sNum + " + " + tNum + " = 0");
                        }
                    }
                }
            }

            for (int i = 0; i < arr.Length - 3; i++)
            {
                int firstNum = arr[i];
                for (int j = i + 1; j < arr.Length - 2; j++)
                {
                    int secondNum = arr[j];
                    for (int k = j + 1; k < arr.Length - 1; k++)
                    {
                        int thirdNum = arr[k];
                        for (int l = k + 1; l < arr.Length; l++)
                        {
                            int fouthNum = arr[l];
                            if (firstNum + secondNum + thirdNum + fouthNum == 0)
                            {
                                Console.WriteLine(firstNum + " + " + secondNum + " + " + thirdNum + " + " + fouthNum + " = 0");
                            }
                        }
                    }
                }
            }

            if (arr[0] + arr[1] + arr[2] + arr[3] + arr[4] == 0)
            {
                Console.WriteLine(arr[0] + " + " + arr[1] + " + " + arr[2] + " + " + arr[3] + " + " + arr[4] + " = 0");
            }
        }
    }
}
