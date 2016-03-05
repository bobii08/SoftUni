namespace _02.InstructionSet
{
    using System;

    internal class InstructionSet
    {
        private static void Main()
        {
            string instruction = Console.ReadLine();

            while (instruction != "END")
            {
                string[] arguments = instruction.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                long result = 0;
                switch (arguments[0])
                {
                    case "INC":
                        {
                            long operandOne = long.Parse(arguments[1]);
                            result = ++operandOne;
                            break;
                        }
                    case "DEC":
                        {
                            long operandOne = long.Parse(arguments[1]);
                            result = --operandOne;
                            break;
                        }
                    case "ADD":
                        {
                            long operandOne = long.Parse(arguments[1]);
                            long operandTwo = long.Parse(arguments[2]);
                            result = operandOne + operandTwo;
                            break;
                        }
                    case "MLA":
                        {
                            long operandOne = long.Parse(arguments[1]);
                            long operandTwo = long.Parse(arguments[2]);
                            result = operandOne * operandTwo;
                            break;
                        }
                }

                Console.WriteLine(result);
                instruction = Console.ReadLine();
            }
        }
    }
}