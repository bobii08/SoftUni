namespace _01.ArrayManipulator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class ArrayManipulator
    {
        private static void Main()
        {
            List<long> list =
                Console.ReadLine()
                    .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(long.Parse)
                    .ToList();
            string command = Console.ReadLine();
            string commandName = string.Empty;
            while (command != "end")
            {
                commandName = command.Split()[0];
                if (commandName == "exchange")
                {
                    long index = long.Parse(command.Split()[1]);
                    if (!IsIndexValid(list, index))
                    {
                        Console.WriteLine("Invalid index");
                        command = Console.ReadLine();
                        continue;
                    }

                    ExchangeCommand(ref list, (int)index);
                }
                else if (commandName == "max")
                {
                    string type = command.Split()[1];
                    if (type == "even")
                    {
                        MaxEvenElementIndex(list);
                    }
                    else
                    {
                        MaxOddElementIndex(list);
                    }
                }
                else if (commandName == "min")
                {
                    string type = command.Split()[1];
                    if (type == "even")
                    {
                        MinEvenElementIndex(list);
                    }
                    else
                    {
                        MinOddElementIndex(list);
                    }
                }
                else if (commandName == "first")
                {
                    long count = long.Parse(command.Split()[1]);
                    string type = command.Split()[2];
                    if (count > list.Count)
                    {
                        Console.WriteLine("Invalid count");
                        command = Console.ReadLine();
                        continue;
                    }

                    if (type == "even")
                    {
                        FirstEvenElements(list, (int)count);
                    }
                    else
                    {
                        FirstOddElements(list, (int)count);
                    }
                }
                else if (commandName == "last")
                {
                    long count = long.Parse(command.Split()[1]);
                    string type = command.Split()[2];
                    if (count > list.Count)
                    {
                        Console.WriteLine("Invalid count");
                        command = Console.ReadLine();
                        continue;
                    }

                    if (type == "even")
                    {
                        LastEvenElements(list, (int)count);
                    }
                    else
                    {
                        LastOddElements(list, (int)count);
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("[" + string.Join(", ", list) + "]");
        }

        private static void LastOddElements(List<long> list, int count)
        {
            var oddElements = list.Where(n => n % 2 != 0).ToArray();
            if (oddElements.Count() == 0)
            {
                Console.WriteLine("[]");
                return;
            }

            if (count <= oddElements.Count())
            {
                List<long> resultElements = new List<long>();
                for (int i = 0; i < count; i++)
                {
                    resultElements.Add(oddElements[oddElements.Length - i - 1]);
                }

                resultElements.Reverse();
                Console.WriteLine("[" + string.Join(", ", resultElements) + "]");
                return;
            }
            else
            {
                Console.WriteLine("[" + string.Join(", ", oddElements) + "]");
            }
        }

        private static void LastEvenElements(List<long> list, int count)
        {
            var evenElements = list.Where(n => n % 2 == 0).ToArray();
            if (evenElements.Count() == 0)
            {
                Console.WriteLine("[]");
                return;
            }

            if (count <= evenElements.Count())
            {
                List<long> resultElements = new List<long>();
                for (int i = 0; i < count; i++)
                {
                    resultElements.Add(evenElements[evenElements.Length - i - 1]);
                }

                resultElements.Reverse();
                Console.WriteLine("[" + string.Join(", ", resultElements) + "]");
                return;
            }
            else
            {
                Console.WriteLine("[" + string.Join(", ", evenElements) + "]");
            }
        }

        private static void FirstOddElements(List<long> list, int count)
        {
            var oddElements = list.Where(n => n % 2 != 0).ToArray();
            if (oddElements.Length == 0)
            {
                Console.WriteLine("[]");
                return;
            }

            if (count <= oddElements.Count())
            {
                List<long> resultElements = new List<long>();
                for (int i = 0; i < count; i++)
                {
                    resultElements.Add(oddElements[i]);
                }

                Console.WriteLine("[" + string.Join(", ", resultElements) + "]");
                return;
            }
            else
            {
                Console.WriteLine("[" + string.Join(", ", oddElements) + "]");
            }
        }
        
        private static void FirstEvenElements(List<long> list, int count)
        {
            var evenElements = list.Where(n => n % 2 == 0).ToArray();
            if (evenElements.Length == 0)
            {
                Console.WriteLine("[]");
                return;
            }

            if (count <= evenElements.Length)
            {
                List<long> resultElements = new List<long>();
                for (int i = 0; i < count; i++)
                {
                    resultElements.Add(evenElements[i]);
                }

                Console.WriteLine("[" + string.Join(", ", resultElements) + "]");
                return;
            }
            else
            {
                Console.WriteLine("[" + string.Join(", ", evenElements) + "]");
            }
        }

        private static void MinEvenElementIndex(List<long> list)
        {
            var evenElements = list.Where(n => n % 2 == 0);
            if (evenElements.Any())
            {
                var mindEvenEl = evenElements.Min();
                long lastIndex = list.LastIndexOf(mindEvenEl);
                Console.WriteLine(lastIndex);
                return;
            }

            Console.WriteLine("No matches");
        }

        private static void MinOddElementIndex(List<long> list)
        {
            var oddElements = list.Where(n => n % 2 != 0);
            if (oddElements.Any())
            {
                var mindOddEl = oddElements.Min();
                long lastIndex = list.LastIndexOf(mindOddEl);
                Console.WriteLine(lastIndex);
                return;
            }

            Console.WriteLine("No matches");
        }

        private static void MaxOddElementIndex(List<long> list)
        {
            var oddElements = list.Where(n => n % 2 != 0);
            if (oddElements.Any())
            {
                var maxOddEl = oddElements.Max();
                long lastIndex = list.LastIndexOf(maxOddEl);
                Console.WriteLine(lastIndex);
                return;
            }

            Console.WriteLine("No matches");
        }

        private static void MaxEvenElementIndex(List<long> list)
        {
            var evenElements = list.Where(n => n % 2 == 0);
            if (evenElements.Any())
            {
                var maxEvenEl = evenElements.Max();
                long lastIndex = list.LastIndexOf(maxEvenEl);
                Console.WriteLine(lastIndex);
                return;
            }

            Console.WriteLine("No matches");
        }

        private static bool IsIndexValid(List<long> list, long index)
        {
            if (index < 0 || index >= list.Count)
            {
                return false;
            }

            return true;
        }

        private static void ExchangeCommand(ref List<long> list, int index)
        {
            List<long> resultList = new List<long>();
            for (int i = index + 1; i < list.Count; i++)
            {
                resultList.Add(list[i]);
            }

            for (int i = 0; i <= index; i++)
            {
                resultList.Add(list[i]);
            }

            list = resultList;
        }
    }
}