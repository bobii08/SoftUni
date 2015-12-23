using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rpg_Game_Team_Doldur.Interfaces;
using Rpg_Game_Team_Doldur.Weapons;

namespace Rpg_Game_Team_Doldur.Weapons
{
    public class Bow : Weapon
    {
        private const int BowHealthBoost = 0;
        private const int BowDamageBoost = 15;

        public Bow()
            :base(BowHealthBoost, BowDamageBoost)
        {
            
        }
    }
}
