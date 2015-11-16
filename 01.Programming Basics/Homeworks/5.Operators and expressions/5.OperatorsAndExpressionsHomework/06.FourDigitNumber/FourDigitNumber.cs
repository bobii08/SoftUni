using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string strNumber = number.ToString();
            int sum = 0;
            for (int i = 0; i < strNumber.Length; i++)
            {
                sum += int.Parse(strNumber[i].ToString());
            }

            Console.WriteLine("sum of digits = " + sum);
            Console.Write("reversed string = ");
            for (int i = 0; i < strNumber.Length; i++)
            {
                Console.Write(strNumber[strNumber.Length - i - 1]);
            }

            Console.WriteLine();
            string newStr = strNumber[strNumber.Length - 1] + "" + strNumber[0] + strNumber[1] + strNumber[2];
            Console.WriteLine("last digit in front = " + newStr);
            string anotherStr = strNumber[0] + "" + strNumber[2] + strNumber[1] + strNumber[3];
            Console.WriteLine("second and third digits exchanged = " + anotherStr);
        }
    }
}
