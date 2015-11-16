using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _12.FallingRocks
{
    public struct Dwarf
    {
        public int X { get; set; }

        public int Y { get; set; }

        public char Ch { get; set; }

        public ConsoleColor Color { get; set; }
    }

    public struct Rock
    {
        public int X { get; set; }

        public int Y { get; set; }

        public char Ch { get; set; }

        public ConsoleColor Color { get; set; }
    }

    class FallingRocks
    {
        public const int PlayfieldWidth = 5;

        public static void PrintOnPosition(int x, int y, char ch, ConsoleColor color)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(ch);
        }

        public static void PrintStringOnPosition(int x, int y, string str, ConsoleColor color)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = color;
            Console.Write(str);
        }

        static void Main()
        {
            Console.BufferHeight = Console.WindowHeight = 20;
            Console.BufferWidth = Console.WindowWidth = 30;
            int livesCount = 5;
            int score = 0;

            Dwarf dwarf = new Dwarf();
            dwarf.X = 2;
            dwarf.Y = Console.WindowHeight - 1;
            dwarf.Ch = '0';
            dwarf.Color = ConsoleColor.Green;
            PrintOnPosition(dwarf.X, dwarf.Y, dwarf.Ch, dwarf.Color);

            Random rndGenerator = new Random();
            List<Rock> rocks = new List<Rock>();

            List<char> rockSymbols = new List<char>()
            {
                '^',
                '@',
                '*',
                '&',
                '+',
                '%',
                '$',
                '#',
                '!',
                '.',
                ';'
            };

            while (true)
            {
                {
                    Rock rock = new Rock();
                    rock.X = rndGenerator.Next(0, PlayfieldWidth);
                    rock.Y = 0;
                    int rockSymbolPosition = rndGenerator.Next(0, rockSymbols.Count);
                    rock.Ch = rockSymbols[rockSymbolPosition];
                    rock.Color = ConsoleColor.Red;
                    PrintOnPosition(rock.X, rock.Y, rock.Ch, rock.Color);
                    rocks.Add(rock);
                }

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                    if (pressedKey.Key == ConsoleKey.LeftArrow)
                    {
                        if (dwarf.X >= 1)
                        {
                            dwarf.X -= 1;
                        }
                    }
                    else if (pressedKey.Key == ConsoleKey.RightArrow)
                    {
                        if (dwarf.X < PlayfieldWidth - 1)
                        {
                            dwarf.X += 1;
                        }
                    }
                }

                List<Rock> newListOfRocks = new List<Rock>();
                for (int i = 0; i < rocks.Count; i++)
                {
                    Rock oldRock = rocks[i];
                    Rock newRock = new Rock();
                    newRock.X = oldRock.X;
                    newRock.Y = oldRock.Y + 1;
                    newRock.Ch = oldRock.Ch;
                    newRock.Color = oldRock.Color;

                    if (newRock.X == dwarf.X && newRock.Y == dwarf.Y)
                    {
                        livesCount--;
                        PrintOnPosition(dwarf.X, dwarf.Y, 'X', ConsoleColor.Blue);
                        if (livesCount < 1)
                        {
                            PrintStringOnPosition(8, 10, "Game over", ConsoleColor.Red);
                            PrintStringOnPosition(8, 12, "Press [enter] to exit", ConsoleColor.Red);
                            Console.ReadLine();
                            Environment.Exit(0);
                        }
                    }

                    if (newRock.Y < Console.WindowHeight)
                    {
                        newListOfRocks.Add(newRock);
                    }
                }

                rocks = newListOfRocks;

                Console.Clear();

                PrintStringOnPosition(8, 4, "Lives: " + livesCount, ConsoleColor.White);
                PrintStringOnPosition(8, 5, "Score: " + score, ConsoleColor.White);

                PrintOnPosition(dwarf.X, dwarf.Y, dwarf.Ch, dwarf.Color);
                foreach (Rock rock in rocks)
                {
                    PrintOnPosition(rock.X, rock.Y, rock.Ch, rock.Color);
                }

                for (int i = 0; i < Console.WindowHeight; i++)
                {
                    PrintOnPosition(PlayfieldWidth, i, '|', ConsoleColor.White);
                }

                score++;
                Thread.Sleep(150);
            }
        }
    }
}
