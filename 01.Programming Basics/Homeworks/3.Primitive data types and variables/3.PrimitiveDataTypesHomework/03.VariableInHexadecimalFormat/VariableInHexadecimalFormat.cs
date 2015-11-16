using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.VariableInHexadecimalFormat
{
    class VariableInHexadecimalFormat
    {
        static void Main()
        {
            string numberInHex = "FE";
            int numberInDec = int.Parse(numberInHex, System.Globalization.NumberStyles.HexNumber);
            Console.WriteLine("FE in decimal format is: " + numberInDec);
        }
    }
}
