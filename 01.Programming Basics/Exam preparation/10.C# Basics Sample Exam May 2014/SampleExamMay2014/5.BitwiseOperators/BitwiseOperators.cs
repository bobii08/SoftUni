using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.BitwiseOperators
{
    class BitwiseOperators
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                long currentNumber = long.Parse(Console.ReadLine());
                long firstShit = ~currentNumber;
                string binary = Convert.ToString(currentNumber, 2);
                StringBuilder strB = new StringBuilder();
                for (int j = binary.Length - 1; j >= 0; j--)
                {
                    strB.Append(binary[j]);
                }

                long secondShit = Convert.ToInt64(strB.ToString(), 2);
                Console.WriteLine((currentNumber ^ firstShit) & secondShit);
            }
        }
    }
}
