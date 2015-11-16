using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.PrintASequence
{
    class PrintASequence
    {
        static void Main()
        {
            int numberToPrint = 2;
            for (int i = 1; i <= 10; i++)
            {
                if (numberToPrint % 2 == 0)
                {
                    Console.Write(numberToPrint + ", ");
                }
                else
                {
                    if (i == 10)
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
