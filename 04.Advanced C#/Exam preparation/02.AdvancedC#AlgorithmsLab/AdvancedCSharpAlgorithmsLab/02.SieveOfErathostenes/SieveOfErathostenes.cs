using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SieveOfErathostenes
{
    class SieveOfErathostenes
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            List<int> numbers = Enumerable.Range(2, number - 1).ToList();
            
            int multiplier = 0;
            int divider = 1;
            while (true)
            {
                divider = numbers.FirstOrDefault(n => n > divider);
                if (divider == 0)
                {
                    break;
                }

                multiplier = 2;
                int notPrimeNum = divider * multiplier;
                while (notPrimeNum <= number)
                {
                    if (numbers[notPrimeNum - 2] != -1)
                    {
                        numbers[notPrimeNum - 2] = -1;
                    }

                    multiplier++;
                    notPrimeNum = divider * multiplier;
                }
            }

            IEnumerable<int> answers = numbers.Where(n => n != -1);

            Console.WriteLine(string.Join(", ", answers));
        }
    }
}
