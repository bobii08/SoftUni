namespace _02.ArraySlider
{
    using System;
    using System.Linq;
    using System.Numerics;

    internal class ArraySlider
    {
        private static void Main()
        {
            string input = Console.ReadLine();
            BigInteger[] array =
                input
                    .Split(new string[] { " ", "\t", "\r\n" }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(BigInteger.Parse)
                    .ToArray();
            string command = Console.ReadLine();
            BigInteger previousIndex = 0;
            while (command != "stop")
            {
                string[] args = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                BigInteger currIndex = BigInteger.Parse(args[0]);
                char operation = args[1][0];
                BigInteger operand = BigInteger.Parse(args[2]);
                BigInteger currPos = previousIndex + currIndex;
                if (currPos < 0)
                {
                    currPos *= -1;
                    //currPos = (array.Length - 1) - (array.Length % currPos);
                    //currPos = currPos + (array.Length % currPos);
                    currPos = array.Length - (currPos % array.Length);
                }
                else if (currPos >= array.Length)
                {
                    currPos = currPos % array.Length;
                }

                if (currPos >= array.Length)
                {
                    currPos = currPos % array.Length;
                }

                switch (operation)
                {
                    case '&':
                        array[(int)currPos] &= operand;
                        break;
                    case '|':
                        array[(int)currPos] |= operand;
                        break;
                    case '^':
                        array[(int)currPos] ^= operand;
                        break;
                    case '+':
                        array[(int)currPos] += operand;
                        break;
                    case '-':
                        array[(int)currPos] -= operand;
                        break;
                    case '*':
                        array[(int)currPos] *= operand;
                        break;
                    case '/':
                        array[(int)currPos] /= operand;
                        break;
                }

                if (array[(int)currPos] < 0)
                {
                    array[(int)currPos] = 0;
                }

                previousIndex = currPos;
                command = Console.ReadLine();
            }

            Console.WriteLine("[{0}]", string.Join(", ", array));
        }
    }
}