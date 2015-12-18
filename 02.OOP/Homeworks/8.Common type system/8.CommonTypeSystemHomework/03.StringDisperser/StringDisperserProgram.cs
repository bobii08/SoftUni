using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.StringDisperser
{
    class StringDisperserProgram
    {
        static void Main()
        {
            StringDisperser stringDisperser = new StringDisperser("gosho", "pesho", "tanio");
            foreach (var ch in stringDisperser.ToString())
            {
                Console.Write(ch + " ");
            }

            Console.WriteLine();
        }
    }
}
