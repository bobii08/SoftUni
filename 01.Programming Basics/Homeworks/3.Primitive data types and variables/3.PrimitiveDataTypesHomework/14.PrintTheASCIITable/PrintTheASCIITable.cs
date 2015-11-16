using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.PrintTheASCIITable
{
    class PrintTheASCIITable
    {
        static void Main()
        {
            Console.WriteLine("ASCII tbale: ");
            for (int i = 0; i < 256; i++)
            {
                Console.WriteLine((char)i);
            }
        }
    }
}
