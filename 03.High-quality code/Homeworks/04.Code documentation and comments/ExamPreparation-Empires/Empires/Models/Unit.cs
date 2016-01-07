using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Models.Interfaces;

namespace Empires.Models
{
    public class Unit : IUnit
    {
        private int health;
        private int damage;

        public int Health
        {
            get { return this.health; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("health", "Health must be positive");
                }
                this.health = value;
            }
        }

        public int AttackDamage
        {
            get { return this.damage; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("damage", "Damage must be positive");
                }
                this.damage = value;
            }
        }
    }
}
