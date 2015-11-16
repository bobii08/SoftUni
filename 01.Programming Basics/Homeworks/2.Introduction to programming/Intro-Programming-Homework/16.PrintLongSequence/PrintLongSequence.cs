using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.PrintLongSequence
{
    class PrintLongSequence
    {
        static void Main()
        {
            int numberToPrint = 2;
            for (int i = 1; i <= 1000; i++)
            {
                if (numberToPrint % 2 == 0)
                {
                    Console.Write(numberToPrint + ", ");
                }
                else
                {
                    if (i == 1000)
                    {
                        Console.Write("-" + numberToPrint);
                        break;
                    }

                    Console.Write("-" + numberToPrint + ", ");
                }

                numberToPrint++;
            }

            Console.WriteLine();
        }
    }
}
