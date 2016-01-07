using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Core.Interfaces;

namespace Empires.Core
{
    public class GameEngine : IEngine
    {
        private const string EndingCommand = "armistice";

        private IRenderer renderer;
        private IReader reader;
        private IExecute commandExecuter;

        public GameEngine(IRenderer renderer, IReader reader, IDatabase database)
        {
            this.renderer = renderer;
            this.reader = reader;
            commandExecuter = new CommandExecuter(database);
        }

        public void Run()
        {
            string command = this.reader.ReadLine();
            while (command != GameEngine.EndingCommand)
            {
                string commandResult = string.Empty;
                string[] commandArgs = command.Split();
                commandResult = commandExecuter.ExecuteCommand(commandArgs);
                if (commandResult != string.Empty)
                {
                    this.renderer.Write(commandResult);                    
                }

                command = reader.ReadLine();
            }
        }
    }
}
