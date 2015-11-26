using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.GameEngine_TheSlum.Items
{
    public class Pill : Bonus
    {
        private const int PillHealthEffect = 0;
        private const int PillDefenseEffect = 0;
        private const int PillAttackEffect = 100;
        private const int PillTimeout = 1;

        public Pill(string id)
            : base(id, PillHealthEffect, PillDefenseEffect, PillAttackEffect, PillTimeout)
        {
        }
    }
}
