namespace _05.ValidUsernames
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    internal class ValidUsernames
    {
        private static void Main()
        {
            string input = Console.ReadLine();
            string[] usernames = input.Split(new char[] { ' ', '\\', '/', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

            var validUsernames = new List<string>();
            var pattern = "\\b[a-zA-Z]\\w{2,24}\\b";
            var regex = new Regex(pattern);

            for (int i = 0; i < usernames.Length; i++)
            {
                var currentUsername = usernames[i];
                if (regex.IsMatch(currentUsername))
                {
                    validUsernames.Add(currentUsername);
                }
            }

            int maxLength = 0;
            int index = -1;
            for (int i = 0; i < validUsernames.Count - 1; i++)
            {
                var firstUsername = validUsernames[i];
                var nextsUsername = validUsernames[i + 1];
                if (firstUsername.Length + nextsUsername.Length > maxLength)
                {
                    index = i;
                    maxLength = firstUsername.Length + nextsUsername.Length;
                }
            }

            if (index != -1)
            {
                Console.WriteLine(validUsernames[index]);
                Console.WriteLine(validUsernames[index + 1]);
            }
        }
    }
}