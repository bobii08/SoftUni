namespace _01.CommandInterpreter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class CommandInterpreter
    {
        private static void Main()
        {
            string inputLineArray = Console.ReadLine();
            string[] array = inputLineArray.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            string command = Console.ReadLine();
            
            while (command != "end")
            {
                string[] args = command.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                string commandName = args[0];
                if (commandName == "reverse")
                {
                    long index = long.Parse(args[2]);
                    long count = long.Parse(args[4]);
                    if (!ReverseAndSortCommandCheck(array, index, count))
                    {
                        Console.WriteLine("Invalid input parameters.");
                        command = Console.ReadLine();
                        continue;
                    }

                    Reverse(array, index, count);
                }
                else if (commandName == "sort")
                {
                    long index = long.Parse(args[2]);
                    long count = long.Parse(args[4]);
                    if (!ReverseAndSortCommandCheck(array, index, count))
                    {
                        Console.WriteLine("Invalid input parameters.");
                        command = Console.ReadLine();
                        continue;
                    }

                    Sort(ref array, index, count);
                }
                else if (commandName == "rollLeft")
                {
                    long count = long.Parse(args[1]);
                    if (count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        command = Console.ReadLine();
                        continue;
                    }

                    if (count >= array.Length)
                    {
                        count = count % array.Length;
                    }

                    for (int i = 0; i < count; i++)
                    {
                        RollLeft(array);
                    }
                }
                else if(commandName == "rollRight")
                {
                    long count = long.Parse(args[1]);
                    if (count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        command = Console.ReadLine();
                        continue;
                    }
                    if (count >= array.Length)
                    {
                        count = count % array.Length;
                    }

                    for (int i = 0; i < count; i++)
                    {
                        RollRight(array);
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("[" + string.Join(", ", array) + "]");
        }

        static void RollLeft(string[] arr)
        {
            string firstElement = arr[0];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }

            arr[arr.Length - 1] = firstElement;
        }

        static void RollRight(string[] arr)
        {
            string lastElement = arr[arr.Length - 1];
            for (int i = arr.Length - 1; i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }

            arr[0] = lastElement;
        }

        static void Sort(ref string[] arr, long index, long count)
        {
            //if (arr.Length == 1)
            //{
            //    return;
            //}

            List<string> tempList = new List<string>();
            for (long i = index; i < index + count; i++)
            {
                tempList.Add(arr[i]);
            }

            tempList.Sort();
            int counter = 0;
            for (long i = index; i < index + count; i++)
            {
                arr[i] = tempList[counter++];
            }
        }

        static bool ReverseAndSortCommandCheck(string[] arr, long index, long count)
        {
            if (index < 0 || index >= arr.Length || count < 0 || index + count > arr.Length)
            {
                return false;
            }

            return true;
        }

        static void Reverse(string[] arr, long index, long count)
        {
            //if (arr.Length == 1)
            //{
            //    return;
            //}

            if (count == 0)
            {
                return;
            }

            int decrease = 0;
            //int maxIndex = (index + count) / 2
            for (long i = index; i <= index + (count / 2) - 1; i++)
            {
                Swap(ref arr[i], ref arr[index + count - 1 - decrease++]);
            }
        }

        static void Swap(ref string val1, ref string val2)
        {
            string oldValue = val1;
            val1 = val2;
            val2 = oldValue;
        }
    }
}