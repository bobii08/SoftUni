namespace _06.CountSymbols
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class CountSymbols
    {
        private static void Main()
        {
            string input = Console.ReadLine();
            var setOfChars = new SortedSet<char>();
            for (int i = 0; i < input.Length; i++)
            {
                setOfChars.Add(input[i]);
            }

            for (int i = 0; i < setOfChars.Count; i++)
            {
                char currentSymbol = setOfChars.ElementAt(i);
                DefineCountOfSymbolsInString(currentSymbol, input);
            }
        }

        private static void DefineCountOfSymbolsInString(char symbol, string str)
        {
            int result = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == symbol)
                {
                    result++;
                }
            }

            Console.WriteLine(symbol + ": " + result + " time/s");
        }
    }
}