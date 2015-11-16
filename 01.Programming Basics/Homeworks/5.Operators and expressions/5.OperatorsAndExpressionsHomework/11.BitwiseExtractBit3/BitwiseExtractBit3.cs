using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.BitwiseExtractBit3
{
    class BitwiseExtractBit3
    {
        static void Main()
        {
            uint number = uint.Parse(Console.ReadLine());
            Console.WriteLine((number >> 3) & 1);
        }
    }
}
