namespace _01.ReverseString
{
    using System;
    using System.Text;

    internal class ReverseString
    {
        private static void Main()
        {
            string str = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                result.Append(str[str.Length - i - 1]);
            }

            Console.WriteLine(result.ToString());
        }
    }
}