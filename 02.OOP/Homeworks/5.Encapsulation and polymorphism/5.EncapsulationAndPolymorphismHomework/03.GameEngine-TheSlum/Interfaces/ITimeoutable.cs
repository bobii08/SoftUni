using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.GameEngine_TheSlum.Interfaces
{
    public interface ITimeoutable
    {
        int Timeout { get; set; }

        int Countdown { get; set; }

        bool HasTimedOut { get; set; }
    }
}
