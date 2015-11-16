using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.RandomizeTheNumbers1ToN
{
    class RandomizeTheNumbers1ToN
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = i + 1;
            }

            bool[] arrBool = new bool[n];
            for (int i = 0; i < arrBool.Length; i++)
            {
                arrBool[i] = true;
            }

            Random rnd = new Random();
            Console.Write("Sequence: ");
            for (int i = 0; i < arr.Length; i++)
            {
                while (true)
                {
                    int index = rnd.Next(0, arr.Length);
                    if (arrBool[index])
                    {
                        Console.Write(arr[index] + " ");
                        arrBool[index] = false;
                        break;
                    }
                }
            }

            Console.WriteLine();
        }
    }
}
