using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.NumbersDividableByGivenNumber
{
    class NumbersDividableByGivenNumber
    {
        static void Main()
        {
            Console.Write("start = ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("end = ");
            int end = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = start; i <= end; i++)
            {
                if (i % 5 == 0)
                {
                    count++;

                    if (end - i > 4)
                    {
                        Console.Write(i + ", ");    
                    }
                    else
                    {
                        Console.Write(i);
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("count = " + count);
        }
    }
}
