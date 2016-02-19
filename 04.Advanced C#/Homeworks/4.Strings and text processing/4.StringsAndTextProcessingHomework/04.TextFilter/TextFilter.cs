namespace _04.TextFilter
{
    using System;

    internal class TextFilter
    {
        private static void Main()
        {
            string[] bannedWords = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            for (int i = 0; i < bannedWords.Length; i++)
            {
                string currentWord = bannedWords[i];
                text = text.Replace(currentWord, new string('*', currentWord.Length));
            }

            Console.WriteLine();
            Console.WriteLine(text);
        }
    }
}