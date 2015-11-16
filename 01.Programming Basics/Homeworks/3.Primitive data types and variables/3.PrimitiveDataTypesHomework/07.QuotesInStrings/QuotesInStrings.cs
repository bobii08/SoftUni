using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.QuotesInStrings
{
    class QuotesInStrings
    {
        static void Main()
        {
            string firstStringVar = "The \"use\" of quotations causes difficulties.";
            Console.WriteLine("First way: " + firstStringVar);
            string secondStringVar = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine("Second way: " + secondStringVar);
        }
    }
}
