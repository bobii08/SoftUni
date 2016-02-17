namespace _09.TerroristsWin
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal class TerroristsWin
    {
        private static void Main()
        {
            string input = Console.ReadLine();

            var indexes = new List<int>();
            int indexToStartFrom = 0;
            while (true)
            {
                int bombsBeginning = input.IndexOf('|', indexToStartFrom);
                int bombsEnding = input.IndexOf('|', bombsBeginning + 1);

                string bombCore = input.Substring(bombsBeginning + 1, bombsEnding - bombsBeginning - 1);

                int weight = 0;
                for (int i = 0; i < bombCore.Length; i++)
                {
                    weight += bombCore[i];
                }

                int bombPower = weight % 10;
                for (int i = bombsBeginning - bombPower; i <= bombsEnding + bombPower; i++)
                {
                    indexes.Add(i);
                }

                indexToStartFrom = bombsEnding + 1;
                if (input.IndexOf('|', indexToStartFrom) == -1)
                {
                    break;
                }
            }

            var strB = new StringBuilder(input);
            for (int i = 0; i < indexes.Count; i++)
            {
                if (indexes[i] >= 0 && indexes[i] < input.Length)
                {
                    strB[indexes[i]] = '.';
                }
            }

            Console.WriteLine(strB.ToString());
        }
    }
}