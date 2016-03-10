namespace BoatRacingSimulator.IO
{
    using System;

    using BoatRacingSimulator.Interfaces;

    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}