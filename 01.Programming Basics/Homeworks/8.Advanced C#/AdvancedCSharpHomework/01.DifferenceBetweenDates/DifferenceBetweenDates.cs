using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DifferenceBetweenDates
{
    class DifferenceBetweenDates
    {
        static void Main()
        {
            string firstInput = Console.ReadLine();
            string secondInput = Console.ReadLine();
            string[] firstArr = firstInput.Split(new char[] {'.'}, StringSplitOptions.RemoveEmptyEntries);
            string[] secondArr = secondInput.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            
            DateTime firstDate = new DateTime(int.Parse(firstArr[2]), int.Parse(firstArr[1]), int.Parse(firstArr[0]));
            DateTime secondDate = new DateTime(int.Parse(secondArr[2]), int.Parse(secondArr[1]), int.Parse(secondArr[0]));

            Console.WriteLine((secondDate-firstDate).Days);
        }
    }
}
