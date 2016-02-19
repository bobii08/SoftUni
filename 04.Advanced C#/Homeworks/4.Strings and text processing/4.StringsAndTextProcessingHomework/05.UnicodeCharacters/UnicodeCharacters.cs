namespace _05.UnicodeCharacters
{
    using System;

    internal class UnicodeCharacters
    {
        private static void Main()
        {
            string inputLine = Console.ReadLine();
            for (int i = 0; i < inputLine.Length; i++)
            {
                char currentChar = inputLine[i];
                string hexRepresentation = string.Format("{0:x}", (int)currentChar);
                int zerosToBeAdded = 4 - hexRepresentation.Length;
                Console.Write("\\u" + new string('0', zerosToBeAdded) + hexRepresentation);
            }

            Console.WriteLine();
        }
    }
}