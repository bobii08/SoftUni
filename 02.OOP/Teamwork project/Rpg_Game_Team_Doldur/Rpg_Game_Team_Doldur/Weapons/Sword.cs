using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rpg_Game_Team_Doldur.Interfaces;

namespace Rpg_Game_Team_Doldur.Weapons
{
    public class Sword : Weapon
    {
        private const int SwordHealthBoost = 0;
        private const int SwordDamageBoost = 20;

        public Sword()
            : base(SwordHealthBoost, SwordDamageBoost)
        {
        }
    }
}
