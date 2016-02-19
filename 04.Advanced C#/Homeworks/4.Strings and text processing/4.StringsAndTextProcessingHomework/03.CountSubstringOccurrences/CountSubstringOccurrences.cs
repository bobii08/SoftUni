namespace _03.CountSubstringOccurences
{
    using System;

    internal class CountSubstringOccurrences
    {
        private static void Main()
        {
            string textStr = Console.ReadLine();
            string searchStr = Console.ReadLine();
            textStr = textStr.ToLower();
            searchStr = searchStr.ToLower();
            int occurences = 0;
            int index = -1;
            if (textStr.IndexOf(searchStr) != -1)
            {
                while (true)
                {
                    index = textStr.IndexOf(searchStr, index + 1);
                    if (index == -1)
                    {
                        break;
                    }

                    occurences++;
                }

                Console.WriteLine(occurences);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}