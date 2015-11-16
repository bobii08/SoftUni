using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.NumberAsWords
{
    class NumberAsWords
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 0:
                    Console.WriteLine("Zero");
                    return;
                case 1:
                    Console.WriteLine("One");
                    return;
                case 2:
                    Console.WriteLine("Two");
                    return;
                case 3:
                    Console.WriteLine("Three");
                    return;
                case 4:
                    Console.WriteLine("Four");
                    return;
                case 5:
                    Console.WriteLine("Five");
                    return;
                case 6:
                    Console.WriteLine("Six");
                    return;
                case 7:
                    Console.WriteLine("Seven");
                    return;
                case 8:
                    Console.WriteLine("Eight");
                    return;
                case 9:
                    Console.WriteLine("Nine");
                    return;
                case 10:
                    Console.WriteLine("Ten");
                    return;
                case 11:
                    Console.WriteLine("Eleven");
                    return;
                case 12:
                    Console.WriteLine("Twelve");
                    return;
                case 13:
                    Console.WriteLine("Thirtheen");
                    return;
                case 14:
                    Console.WriteLine("Fourteen");
                    return;
                case 15:
                    Console.WriteLine("Fifteen");
                    return;
                case 16:
                    Console.WriteLine("Sixteen");
                    return;
                case 17:
                    Console.WriteLine("Seventeen");
                    return;
                case 18:
                    Console.WriteLine("Eighteen");
                    return;
                case 19:
                    Console.WriteLine("Nineteen");
                    return;
            }

            if (number >= 20 && number <= 99)
            {
                int firstDigit = number / 10;
                int secondDigit = number % 10;
                switch (firstDigit)
                {
                    case 2:
                        Console.Write("Twenty ");
                        break;
                    case 3:
                        Console.Write("Thirty ");
                        break;
                    case 4:
                        Console.Write("Fourty ");
                        break;
                    case 5:
                        Console.Write("Fifty ");
                        break;
                    case 6:
                        Console.Write("Sixty ");
                        break;
                    case 7:
                        Console.Write("Seventy ");
                        break;
                    case 8:
                        Console.Write("Eighty ");
                        break;
                    case 9:
                        Console.Write("Ninety ");
                        break;
                }

                switch (secondDigit)
                {
                    case 0:
                        Console.WriteLine();
                        break;
                    case 1:
                        Console.WriteLine("one");
                        break;
                    case 2:
                        Console.WriteLine("two");
                        break;
                    case 3:
                        Console.WriteLine("three");
                        break;
                    case 4:
                        Console.WriteLine("four");
                        break;
                    case 5:
                        Console.WriteLine("five");
                        break;
                    case 6:
                        Console.WriteLine("six");
                        break;
                    case 7:
                        Console.WriteLine("seven");
                        break;
                    case 8:
                        Console.WriteLine("eight");
                        break;
                    case 9:
                        Console.WriteLine("nine");
                        break;
                }
            }
            else if (number >= 100 && number <= 999)
            {
                int firstDigit = number / 100;
                int secondDigit = (number / 10) % 10;
                int thirdDigit = number % 10;
                switch (firstDigit)
                {
                    case 1:
                        Console.Write("One ");
                        break;
                    case 2:
                        Console.Write("Two ");
                        break;
                    case 3:
                        Console.Write("Three ");
                        break;
                    case 4:
                        Console.Write("Four ");
                        break;
                    case 5:
                        Console.Write("Five ");
                        break;
                    case 6:
                        Console.Write("Six ");
                        break;
                    case 7:
                        Console.Write("Seven ");
                        break;
                    case 8:
                        Console.Write("Eight ");
                        break;
                    case 9:
                        Console.Write("Nine ");
                        break;
                }

                Console.Write("hundred and ");
                switch (secondDigit)
                {
                    case 1:
                        switch (thirdDigit)
                        {
                            case 1:
                                Console.Write("eleven");
                                return;
                            case 2:
                                Console.WriteLine("twelve");
                                return;
                            case 3:
                                Console.WriteLine("thirtheen");
                                return;
                            case 4:
                                Console.WriteLine("fourteen");
                                return;
                            case 5:
                                Console.WriteLine("fifteen");
                                return;
                            case 6:
                                Console.WriteLine("sixteen");
                                return;
                            case 7:
                                Console.WriteLine("seventeen");
                                return;
                            case 8:
                                Console.WriteLine("eighteen");
                                return;
                            case 9:
                                Console.WriteLine("nineteen");
                                return;
                        }
                        break;
                    case 2:
                        Console.Write("twenty ");
                        break;
                    case 3:
                        Console.Write("thirty ");
                        break;
                    case 4:
                        Console.Write("fourty ");
                        break;
                    case 5:
                        Console.Write("fifty ");
                        break;
                    case 6:
                        Console.Write("sixty ");
                        break;
                    case 7:
                        Console.Write("seventy ");
                        break;
                    case 8:
                        Console.Write("eighty ");
                        break;
                    case 9:
                        Console.Write("ninety ");
                        break;
                }

                switch (thirdDigit)
                {
                    case 0:
                        Console.WriteLine();
                        break;
                    case 1:
                        Console.WriteLine("one");
                        break;
                    case 2:
                        Console.WriteLine("two");
                        break;
                    case 3:
                        Console.WriteLine("three");
                        break;
                    case 4:
                        Console.WriteLine("four");
                        break;
                    case 5:
                        Console.WriteLine("five");
                        break;
                    case 6:
                        Console.WriteLine("six");
                        break;
                    case 7:
                        Console.WriteLine("seven");
                        break;
                    case 8:
                        Console.WriteLine("eight");
                        break;
                    case 9:
                        Console.WriteLine("nine");
                        break;
                }
            }
        }
    }
}
