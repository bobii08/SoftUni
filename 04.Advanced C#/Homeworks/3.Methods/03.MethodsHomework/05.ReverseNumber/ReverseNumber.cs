namespace _05.ReverseNumber
{
    using System;
    using System.Text;

    internal class ReverseNumber
    {
        private static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            double reversed = GetReversedNumber(number);
            Console.WriteLine(reversed);
        }

        private static double GetReversedNumber(double number)
        {
            string str = number.ToString();
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                result.Append(str[str.Length - i - 1]);
            }

            return Convert.ToDouble(result.ToString());
        }
    }
}