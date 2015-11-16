using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.PlayWithIntDoubleAndString
{
    class PlayWithIntDoubleAndString
    {
        static void Main()
        {
            Console.WriteLine("Please choos a type:");
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");

            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.Write("Please enter an integer: ");
                int integerInput = int.Parse(Console.ReadLine());
                Console.WriteLine(++integerInput);
            }
            else if (choice == 2)
            {
                Console.Write("Please enter a double: ");
                double doubleInput = double.Parse(Console.ReadLine());
                Console.WriteLine(++doubleInput);
            }
            else
            {
                Console.Write("Please enter a string: ");
                string stringInput = Console.ReadLine();
                Console.WriteLine(stringInput + "*");
            }
        }
    }
}
