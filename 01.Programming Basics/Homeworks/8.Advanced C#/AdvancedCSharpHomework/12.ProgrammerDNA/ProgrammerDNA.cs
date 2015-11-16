using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _12.ProgrammerDNA
{
    class ProgrammerDNA
    {
        static char PrintSth(int n, char startingLetter)
        {
            int dots = 3;
            int numberOfLettersOnRow = 1;
            for (int i = 0; i < 7; i++)
            {
                if (i <= 3)
                {
                    Console.Write(new string('.', dots));
                    for (int j = 0; j < numberOfLettersOnRow; j++)
                    {
                        Console.Write(startingLetter);
                        startingLetter++;
                        if (startingLetter == 'H')
                        {
                            startingLetter = 'A';
                        }
                    }
                    numberOfLettersOnRow += 2;
                    Console.WriteLine(new string('.', dots));
                    dots--;
                    if (i == 3)
                    {
                        dots = 1;
                        numberOfLettersOnRow = 5;
                    }
                }
                else
                {
                    Console.Write(new string('.', dots));
                    for (int j = 0; j < numberOfLettersOnRow; j++)
                    {
                        Console.Write(startingLetter);
                        startingLetter++;
                        if (startingLetter == 'H')
                        {
                            startingLetter = 'A';
                        }
                    }
                    numberOfLettersOnRow -= 2;
                    Console.WriteLine(new string('.', dots));
                    dots++;
                }
            }

            char result = startingLetter++;
            if (result == 'H')
            {
                result = 'A';
            }

            return result;
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char startingLetter = char.Parse(Console.ReadLine());

            int numberDNABlocks = n / 7;
            int remainder = n % 7;
            for (int k = 0; k < numberDNABlocks; k++)
            {
                startingLetter = PrintSth(n, startingLetter);
            }

            int dots = 3;
            int numberOfLettersOnRow = 1;
            for (int i = 0; i < remainder; i++)
            {
                if (i <= 3)
                {
                    Console.Write(new string('.', dots));
                    for (int j = 0; j < numberOfLettersOnRow; j++)
                    {
                        Console.Write(startingLetter);
                        startingLetter++;
                        if (startingLetter == 'H')
                        {
                            startingLetter = 'A';
                        }
                    }
                    numberOfLettersOnRow += 2;
                    Console.WriteLine(new string('.', dots));
                    dots--;
                    if (i == 3)
                    {
                        dots = 1;
                        numberOfLettersOnRow = 5;
                    }
                }
                else
                {
                    Console.Write(new string('.', dots));
                    for (int j = 0; j < numberOfLettersOnRow; j++)
                    {
                        Console.Write(startingLetter);
                        startingLetter++;
                        if (startingLetter == 'H')
                        {
                            startingLetter = 'A';
                        }
                    }
                    numberOfLettersOnRow -= 2;
                    Console.WriteLine(new string('.', dots));
                    dots++;
                }
            }
        }
    }
}
