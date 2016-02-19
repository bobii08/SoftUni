namespace _02.StringLength
{
    using System;
    using System.Text;

    internal class StringLength
    {
        private static void Main()
        {
            string str = Console.ReadLine();
            StringBuilder stringBuilder = new StringBuilder(str);
            if (str.Length < 20)
            {
                stringBuilder.Append(new string('*', 20 - str.Length));
            }
            else if (str.Length > 20)
            {
                stringBuilder.Remove(20, str.Length - 20);
            }

            Console.WriteLine(stringBuilder.ToString());
        }
    }
}