namespace _02.LastDigitOfNumber
{
    using System;

    internal class LastDigitOfNumber
    {
        private static void Main()
        {
            Console.Write("Enter an integer: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(GetLastDigitAsWord(number));
        }

        private static string GetLastDigitAsWord(int number)
        {
            int remainder = number % 10;
            if (remainder < 0)
            {
                remainder *= -1;
            }

            switch (remainder)
            {
                case 0:
                    return "zero";
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                default:
                    return "You've entered an invalid number";
            }
        }
    }
}