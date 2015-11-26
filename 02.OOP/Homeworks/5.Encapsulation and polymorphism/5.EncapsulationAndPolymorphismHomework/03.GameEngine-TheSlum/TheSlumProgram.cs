using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.GameEngine_TheSlum.GameEngine;

namespace _03.GameEngine_TheSlum
{
    class TheSlumProgram
    {
        static void Main()
        {
            Engine engine = new ExtendedEngine();
            engine.Run();
        }
    }
}
