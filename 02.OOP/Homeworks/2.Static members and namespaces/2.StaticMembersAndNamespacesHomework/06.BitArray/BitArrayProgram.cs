using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _06.BitArray
{
    class BitArrayProgram
    {
        static void Main()
        {
            BitArray binNumber = new BitArray(8);
            binNumber[7] = 1;
            binNumber[7] = 0;
            binNumber[6] = 1;
            binNumber[2] = 1;
            Console.WriteLine(binNumber);
            Console.WriteLine();

            BitArray anotherBinNumber = new BitArray(10000);
            anotherBinNumber[59] = 1;
            anotherBinNumber[9999] = 1;
            Console.WriteLine(anotherBinNumber);
        }
    }
}
