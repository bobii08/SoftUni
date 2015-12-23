using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Game_Team_Doldur.Weapons
{
    public class Wand : Weapon
    {
        private const int WandHealthBoost = 10;
        private const int WandDamageBoost = 5;

        public Wand()
            :base (WandHealthBoost, WandDamageBoost)
        {
        }
    }
}
