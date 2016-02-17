namespace _04.SequencesOfEqualStrings
{
    using System;

    internal class SequencesOfEqualStrings
    {
        private static void Main()
        {
            string[] words = Console.ReadLine().Split(' ');
            bool[] arrCheckedIndexes = new bool[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                if (arrCheckedIndexes[i])
                {
                    continue;
                }

                string currentWord = words[i];
                arrCheckedIndexes[i] = true;
                Console.Write(currentWord);
                int j = i + 1;
                while (j < words.Length)
                {
                    if ((words[j] == currentWord) && (arrCheckedIndexes[j] == false))
                    {
                        Console.Write(" " + currentWord);
                        arrCheckedIndexes[j] = true;
                    }

                    j++;
                }

                Console.WriteLine();
            }
        }
    }
}