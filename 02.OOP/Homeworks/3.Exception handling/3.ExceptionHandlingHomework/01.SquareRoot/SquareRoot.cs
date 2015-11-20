using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SquareRoot
{
    class SquareRoot
    {
        static void Main()
        {
            string numberStr = Console.ReadLine();
            try
            {
                double number = double.Parse(numberStr);
                double sqrRoot = CalculateSquareRoot(number);
                Console.WriteLine("Square root of {0}: {1}", number, sqrRoot);
            }
            catch (FormatException ex)
            {
                Console.Error.WriteLine("Invalid number!");
                Console.Error.WriteLine("Exception thrown: " + ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.Error.WriteLine("Invalid number!");
                Console.Error.WriteLine("Exception thrown: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }

        static double CalculateSquareRoot(double number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("number", "cannot calculate square root of a negative number.");
            }

            return Math.Sqrt(number);
        }
    }
}
