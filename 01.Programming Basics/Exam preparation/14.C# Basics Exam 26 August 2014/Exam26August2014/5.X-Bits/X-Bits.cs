using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.X_Bits
{
    class XBits
    {
        static void Main()
        {
            int[] arr = new int[8];
            for (int i = 0; i < 8; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int size = Convert.ToString(arr.Max(), 2).Length;
            int countOfXBits = 0;
            for (int row = 0; row < 6; row++)
            {
                for (int col = 0; col < size - 2; col++)
                {
                    int firstNumber = arr[row];
                    int secondNumber = arr[row + 1];
                    int thirdNumber = arr[row + 2];

                    int firstNumberMask = 7 << col;
                    int secondNumberMask = 7 << col;
                    int thirdNumberMask = 7 << col;

                    int firstNumberAndMask = firstNumber & firstNumberMask;
                    int secondNumberAndMask = secondNumber & secondNumberMask;
                    int thirdNumberAndMask = thirdNumber & thirdNumberMask;

                    if ((firstNumberAndMask >> col) == 5 && (secondNumberAndMask >> col) == 2 && (thirdNumberAndMask >> col) == 5)
                    {
                        countOfXBits++;
                    }
                }
            }

            Console.WriteLine(countOfXBits);
        }
    }
}
