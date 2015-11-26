using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.GameEngine_TheSlum.Interfaces;

namespace _03.GameEngine_TheSlum.Items
{
    public abstract class Bonus : Item, ITimeoutable
    {
        protected Bonus(string id, int healthEffect, int defenseEffect, int attackEffect, int timeOut)
            : base(id, healthEffect, defenseEffect, attackEffect)
        {
            this.Timeout = timeOut;
            this.Countdown = timeOut;
        }

        public int Timeout { get; set; }

        public int Countdown { get; set; }

        public bool HasTimedOut { get; set; }
    }
}
