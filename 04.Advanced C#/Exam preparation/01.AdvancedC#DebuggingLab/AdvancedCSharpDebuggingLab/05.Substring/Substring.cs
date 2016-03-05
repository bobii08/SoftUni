namespace _05.Substring
{
    using System;

    internal class Substring
    {
        private static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int jump = int.Parse(Console.ReadLine());

            const char Search = 'p';
            bool hasMatch = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == Search)
                {
                    hasMatch = true;

                    int currentJump = jump + 1;
                    if (i + currentJump >= text.Length)
                    {
                        currentJump -= (i + currentJump) - text.Length;
                    }

                    string matchedString = text.Substring(i, currentJump);
                    Console.WriteLine(matchedString);
                    i += currentJump - 1;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}