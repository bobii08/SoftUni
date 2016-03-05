namespace _03.BePositive
{
    using System;
    using System.Collections.Generic;

    internal class BePositive
    {
        private static void Main()
        {
            int countSequences = int.Parse(Console.ReadLine());

            for (int i = 0; i < countSequences; i++)
            {
                string[] input = Console.ReadLine().Split(new [] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var numbers = new List<int>();

                for (int j = 0; j < input.Length; j++)
                {
                    if (!input[j].Equals(string.Empty))
                    {
                        int num = int.Parse(input[j]);
                        numbers.Add(num);
                    }
                }

                bool found = false;

                for (int j = 0; j < numbers.Count; j++)
                {
                    int currentNum = numbers[j];

                    if (currentNum >= 0)
                    {
                        if (found)
                        {
                            Console.Write(" ");
                        }

                        Console.Write(currentNum);

                        found = true;
                    }
                    else
                    {
                        j++;
                        if (j == numbers.Count)
                        {
                            break;
                        }

                        currentNum += numbers[j];

                        if (currentNum >= 0)
                        {
                            if (found)
                            {
                                Console.Write(" ");
                            }

                            Console.Write(currentNum);

                            found = true;
                        }
                    }
                }

                if (!found)
                {
                    Console.Write("(empty)");
                }

                if (i < countSequences - 1)
                {
                    Console.WriteLine();                    
                }
            }
        }
    }
}