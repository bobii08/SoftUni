using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            long currentNum = 171;
            long newNum = 0;
            for (int index = 0; index < 32; index += 2)
            {
                long numToBeAdded = currentNum & (1 << index);
                newNum += numToBeAdded;
            }
        }
    }
}
