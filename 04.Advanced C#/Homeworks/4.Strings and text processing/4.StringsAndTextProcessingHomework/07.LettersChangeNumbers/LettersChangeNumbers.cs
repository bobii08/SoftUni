namespace _07.LettersChangeNumbers
{
    using System;
    using System.Text;

    internal class LettersChangeNumbers
    {
        private const int NumToSubtractToGetPosInAlphabetUppercase = 64;

        private const int NumToSubtractToGetPosInAlphabetLowerCase = 96;
        
        private static void Main()
        {
            string lineOfStrings = Console.ReadLine();
            string[] strings = lineOfStrings.Split(
                new[] { ' ', '\t', '\n' }, 
                StringSplitOptions.RemoveEmptyEntries);
            decimal totalSum = 0;
            for (int i = 0; i < strings.Length; i++)
            {
                string currentString = strings[i];
                decimal currentSum = CalculateCurrentSum(currentString);
                totalSum += currentSum;
            }

            Console.WriteLine("{0:0.00}", totalSum);
        }

        private static decimal CalculateCurrentSum(string str)
        {
            char firstLetter = str[0];
            string strNumber = str.Substring(1, str.Length - 2);

            decimal number = decimal.Parse(strNumber);
            char secondLetter = str[str.Length - 1];

            if (firstLetter >= 'A' && firstLetter <= 'Z')
            {
                number /= firstLetter - NumToSubtractToGetPosInAlphabetUppercase;
            }
            else if (firstLetter >= 'a' && firstLetter <= 'z')
            {
                number *= firstLetter - NumToSubtractToGetPosInAlphabetLowerCase;
            }

            if (secondLetter >= 'A' && secondLetter <= 'Z')
            {
                number -= secondLetter - NumToSubtractToGetPosInAlphabetUppercase;
            }
            else if (secondLetter >= 'a' && secondLetter <= 'z')
            {
                number += secondLetter - NumToSubtractToGetPosInAlphabetLowerCase;
            }

            return number;
        }
    }
}