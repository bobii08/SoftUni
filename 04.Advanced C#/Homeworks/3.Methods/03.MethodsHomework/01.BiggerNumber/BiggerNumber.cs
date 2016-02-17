namespace _01.BiggerNumber
{
    using System;

    internal class BiggerNumber
    {
        private static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int max = GetMax(firstNumber, secondNumber);
            Console.WriteLine(max);
        }

        private static int GetMax(int firstNum, int secondNum)
        {
            int max = firstNum;
            if (secondNum > max)
            {
                max = secondNum;
            }

            return max;
        }
    }
}