using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rpg_Game_Team_Doldur.Interfaces;

namespace Rpg_Game_Team_Doldur.Weapons
{
    public abstract class Weapon : IWeapon
    {
        private int healthBoost;
        private int damageBoost;

        protected Weapon(int healthBoost, int damageBoost)
        {
            this.healthBoost = healthBoost;
            this.damageBoost = damageBoost;
        }

        public int ResultedHealth(IPlayer player)
        {
            return player.Health + this.healthBoost;
        }

        public int ResultedDamage(IPlayer player)
        {
            return player.Damage + this.damageBoost;
        }
    }
}
