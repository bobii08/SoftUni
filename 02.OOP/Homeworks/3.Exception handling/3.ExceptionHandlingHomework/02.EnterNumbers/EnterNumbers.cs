using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.EnterNumbers
{
    class EnterNumbers
    {
        static void Main()
        {
            List<int> numbersList = new List<int>();
            try
            {
                int numbersEntered = 0;
                int previousNumber = 0;
                while (numbersEntered <= 10)
                {
                    string numberStr = Console.ReadLine();
                    ReadNumber(numberStr, 100);
                    if (int.Parse(numberStr) <= previousNumber)
                    {
                        Console.WriteLine("The number you've entered was not bigger than the previous one. Enter a number again!");
                        continue;
                    }
                    previousNumber = int.Parse(numberStr);
                    numbersList.Add(previousNumber);
                    numbersEntered++;
                }
            }
            catch (FormatException)
            {
                Console.Error.WriteLine("You've entered an invalid number. Enter a number again: ");
                Console.ReadLine();
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.Error.Write("You've entered a number that was not in the specified range. Enter a number again: ");
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("The numbers you've entered: " + string.Join(", ", numbersList));
            }
        }

        static void ReadNumber(string startStr, int end)
        {
            int start;
            if (!int.TryParse(startStr, out start))
            {
                throw new FormatException("the number you've entered was not in a correct format");
            }
            start = int.Parse(startStr);
            if (start <= 1 || start >= end)
            {
                throw new ArgumentOutOfRangeException("start",
                    string.Format("the number you've entered should be in range [{0}...{1}]",
                        start, end));
            }
        }
    }
}
