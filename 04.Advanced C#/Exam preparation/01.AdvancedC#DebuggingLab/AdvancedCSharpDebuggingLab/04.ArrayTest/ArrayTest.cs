namespace _04.ArrayTest
{
    using System;
    using System.Linq;

    internal class ArrayTest
    {
        private const char ArgumentsDelimiter = ' ';

        private static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            long[] array = Console.ReadLine()
                .Split(ArgumentsDelimiter)
                .Select(long.Parse)
                .ToArray();

            string command = Console.ReadLine();

            while (!command.Equals("stop"))
            {
                string commandName = command.Split(ArgumentsDelimiter)[0];
                int[] args = new int[2];

                if (commandName.Equals("add") ||
                    commandName.Equals("subtract") ||
                    commandName.Equals("multiply"))
                {
                    string[] stringParams = command.Split(ArgumentsDelimiter);
                    args[0] = int.Parse(stringParams[1]);
                    args[1] = int.Parse(stringParams[2]);

                    PerformAction(array, commandName, args);
                }
                else if (commandName.Equals("lshift"))
                {
                    ArrayShiftLeft(array);
                }
                else
                {
                    ArrayShiftRight(array);
                }

                PrintArray(array);
                Console.WriteLine();

                command = Console.ReadLine();
            }
        }

        static void PerformAction(long[] arr, string action, int[] args)
        {
            int pos = args[0] - 1;
            if (pos < 0 || pos >= arr.Length)
            {
                return;
            }

            int value = args[1];

            switch (action)
            {
                case "multiply":
                    arr[pos] *= value;
                    break;
                case "add":
                    arr[pos] += value;
                    break;
                case "subtract":
                    arr[pos] -= value;
                    break;
            }
        }

        private static void ArrayShiftRight(long[] array)
        {
            long lastNum = array[array.Length - 1];
            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }

            array[0] = lastNum;
        }

        private static void ArrayShiftLeft(long[] array)
        {
            long firstNum = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }

            array[array.Length - 1] = firstNum;
        }

        private static void PrintArray(long[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}