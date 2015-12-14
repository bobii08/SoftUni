using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AsynchronousTimer
{
    class AsynchronousTimerProgram
    {
        static void Main()
        {
            Action action = () =>
            {
                Console.WriteLine("Method called");
            };

            AsyncTimer asyncTimer = new AsyncTimer(action, 7, 1000);
            asyncTimer.Run();
        }
    }
}
