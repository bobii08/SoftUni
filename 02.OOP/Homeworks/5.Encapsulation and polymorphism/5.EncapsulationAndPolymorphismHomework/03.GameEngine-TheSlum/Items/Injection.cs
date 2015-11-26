using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.GameEngine_TheSlum.Items
{
    public class Injection : Bonus
    {
        private const int InjectionHealthEffect = 200;
        private const int InjectionDefenseEffect = 0;
        private const int InjectionAttackEffect = 0;
        private const int InjectionTimeout = 3;

        public Injection(string id)
            :base(id, InjectionHealthEffect, InjectionDefenseEffect, InjectionAttackEffect, InjectionTimeout)
        {
        }
    }
}
