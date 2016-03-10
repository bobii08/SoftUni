namespace BoatRacingSimulator.IO
{
    using System;

    using BoatRacingSimulator.Interfaces;

    public class ConsoleWriter : IWriter
    {
        public void WriteLine(string outputLine)
        {
            Console.WriteLine(outputLine);
        }
    }
}