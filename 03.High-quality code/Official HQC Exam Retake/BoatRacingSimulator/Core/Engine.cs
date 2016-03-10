namespace BoatRacingSimulator.Core
{
    using System;
    using System.Linq;

    using BoatRacingSimulator.Interfaces;
    using BoatRacingSimulator.IO;

    public class Engine : IRunnable
    {
        public Engine(IReader reader, IWriter writer, ICommandHandler commandHandler)
        {
            this.Reader = reader;
            this.Writer = writer;
            this.CommandHandler = commandHandler;
        }

        public Engine()
            : this(new ConsoleReader(), new ConsoleWriter(), new CommandHandler())
        {
        }

        private ICommandHandler CommandHandler { get; set; }

        private IReader Reader { get; set; }

        private IWriter Writer { get; set; }

        public void Run()
        {
            while (true)
            {
                string line = this.Reader.ReadLine();
                if (string.IsNullOrEmpty(line))
                {
                    break;
                }

                var tokens = line.Split(new[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
                var commandName = tokens[0];
                var parameters = tokens.Skip(1).ToArray();

                try
                {
                    string commandResult = this.CommandHandler.ExecuteCommand(commandName, parameters);
                    this.Writer.WriteLine(commandResult);
                }
                catch (Exception ex)
                {
                    this.Writer.WriteLine(ex.Message);
                }
            }
        }
    }
}