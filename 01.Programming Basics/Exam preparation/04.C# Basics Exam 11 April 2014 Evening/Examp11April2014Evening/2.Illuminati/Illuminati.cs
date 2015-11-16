using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Illuminati
{
    class Illuminati
    {
        static void Main()
        {
            string message = Console.ReadLine();

            int numberOfVowels = 0;
            int sumOfVowels = 0;

            for (int i = 0; i < message.Length; i++)
            {
                char letter = message[i];
                if (letter == 'a' || letter == 'A')
                {
                    numberOfVowels++;
                    sumOfVowels += 65;
                }
                else if (letter == 'e' || letter == 'E')
                {
                    numberOfVowels++;
                    sumOfVowels += 69;
                }
                else if (letter == 'i' || letter == 'I')
                {
                    numberOfVowels++;
                    sumOfVowels += 73;
                }
                else if (letter == 'o' || letter == 'O')
                {
                    numberOfVowels++;
                    sumOfVowels += 79;
                }
                else if (letter == 'u' || letter == 'U')
                {
                    numberOfVowels++;
                    sumOfVowels += 85;
                }
            }

            Console.WriteLine(numberOfVowels);
            Console.WriteLine(sumOfVowels);
        }
    }
}
