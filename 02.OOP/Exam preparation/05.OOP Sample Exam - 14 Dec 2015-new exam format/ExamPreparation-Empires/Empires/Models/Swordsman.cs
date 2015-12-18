using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Models.Interfaces;

namespace Empires.Models
{
    public class Swordsman : IUnit
    {
        private const int DefaultHealth = 40;
        private const int DefaultDamage = 13;

        private int health;
        private int damage;

        public Swordsman()
        {
            this.Health = DefaultHealth;
            this.AttackDamage = DefaultDamage;
        }

        public int Health
        {
            get { return this.health; }
            set { this.health = value; }
        }

        public int AttackDamage
        {
            get { return this.damage; }
            private set { this.damage = value; }
        }
    }
}
