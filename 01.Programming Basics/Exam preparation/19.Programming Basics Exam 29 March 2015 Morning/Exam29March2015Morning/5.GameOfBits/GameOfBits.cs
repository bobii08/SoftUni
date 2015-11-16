using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.GameOfBits
{
    class GameOfBits
    {
        static void Main()
        {
            long currentNum = long.Parse(Console.ReadLine());
            int currentNumberOfCommands = 0;
            string command = Console.ReadLine();
            currentNumberOfCommands++;
            if (command == "Game Over!")
            {
                int countOfBits = 0;
                string numBin = Convert.ToString(currentNum, 2);
                for (int i = 0; i < numBin.Length; i++)
                {
                    if (numBin[i] == '1')
                    {
                        countOfBits++;
                    }
                }
                Console.WriteLine(currentNum + " -> " + countOfBits);
            }

            if (currentNum == 0)
            {
                Console.WriteLine(0 + " -> " + 0);
                return;
            }
            while (true)
            {
                StringBuilder newNum = new StringBuilder();
                if (command == "Odd")
                {
                    string currentNumBin = Convert.ToString(currentNum, 2).PadLeft(32, '0');
                    for (int index = 1; index < 32; index += 2)
                    {
                        char bitToBeExtracted = currentNumBin[index];
                        newNum.Append(bitToBeExtracted);
                    }
                }
                else if (command == "Even")
                {
                    string currentNumBin = Convert.ToString(currentNum, 2).PadLeft(32, '0');
                    for (int index = 0; index < 32; index += 2)
                    {
                        char bitToBeExtracted = currentNumBin[index];
                        newNum.Append(bitToBeExtracted);
                    }
                }

                currentNum = Convert.ToInt64(newNum.ToString(), 2);
                command = Console.ReadLine();
                currentNumberOfCommands++;
                if (currentNumberOfCommands > 30)
                {
                    break;
                }
                if (command == "Game Over!")
                {
                    int countOfBits = 0;
                    string numBin = Convert.ToString(currentNum, 2);
                    for (int i = 0; i < numBin.Length; i++)
                    {
                        if (numBin[i] == '1')
                        {
                            countOfBits++;
                        }
                    }
                    Console.WriteLine(currentNum + " -> " + countOfBits);
                    break;
                }
            }
        }
    }
}
