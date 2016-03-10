namespace BoatRacingSimulator
{
    using BoatRacingSimulator.Core;
    using BoatRacingSimulator.Interfaces;
    using BoatRacingSimulator.IO;

    public class Program
    {
        public static void Main()
        {
            IReader consoleReader = new ConsoleReader();
            IWriter consoleWriter = new ConsoleWriter();
            ICommandHandler commandHandler = new CommandHandler();
            var engine = new Engine(consoleReader, consoleWriter, commandHandler);
            engine.Run();
        }
    }
}