using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.BitsInverter
{
    class BitsInverter
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            char[] arrOfBits = new char[n * 8];
            int numbersAlreadyAdded = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int decNumber = arr[i];
                string strNumber = Convert.ToString(decNumber, 2).PadLeft(8, '0');
                for (int j = 0; j < strNumber.Length; j++)
                {
                    arrOfBits[numbersAlreadyAdded] += strNumber[j];
                    numbersAlreadyAdded++;
                }
            }

            for (int i = 0; i < arrOfBits.Length; i += step)
            {
                char currentBit = arrOfBits[i];
                if (currentBit == '0')
                {
                    arrOfBits[i] = '1';
                }
                else
                {
                    arrOfBits[i] = '0';
                }
                if (i + step >= arrOfBits.Length)
                {
                    break;
                }
            }

            List<int> answers = new List<int>();
            
            for (int i = 0; i < arrOfBits.Length; i += 8)
            {
                StringBuilder strBuilder = new StringBuilder();
                for (int j = i; j < i + 8; j++)
                {
                    strBuilder.Append(arrOfBits[j]);
                }

                int currentNumber = Convert.ToInt32(strBuilder.ToString(), 2);
                answers.Add(currentNumber);
            }

            foreach (var number in answers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
