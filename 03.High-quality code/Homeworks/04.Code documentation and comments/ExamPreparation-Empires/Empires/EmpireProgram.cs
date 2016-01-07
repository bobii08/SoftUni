using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Core;
using Empires.Core.Interfaces;

namespace Empires
{
    class EmpireProgram
    {
        static void Main()
        {
            IRenderer consoleRenderer = new ConsoleRenderer();
            IReader consoleReader = new ConsoleReader();
            IDatabase database = new Database();
            IEngine engine = new GameEngine(consoleRenderer, consoleReader, database);
            engine.Run();
        }
    }
}
