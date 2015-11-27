using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.GameEngine_TheSlum.Interfaces;
using _03.GameEngine_TheSlum.Items;

namespace _03.GameEngine_TheSlum.Characters
{
    public class Mage : Character, IAttack
    {
        private const int MageDefaultHealthPoints = 150;
        private const int MageDefaultDefensePoints = 50;
        private const int MageDefaultAttackPoints = 300;
        private const int MageDefaultRange = 5;

        public Mage(string id, int x, int y, Team team)
            : base(id, x, y, MageDefaultHealthPoints, MageDefaultDefensePoints, team, MageDefaultRange)
        {
            this.AttackPoints = MageDefaultAttackPoints;
        }

        public int AttackPoints { get; set; }

        public new void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
            this.HealthPoints += item.HealthEffect;
            this.DefensePoints += item.DefenseEffect;
            this.AttackPoints += item.AttackEffect;
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            var target = targetsList.LastOrDefault(t => (t.Team != this.Team) && (t.Id != this.Id) && t.IsAlive);
            return target;
        }

        protected override void ApplyItemEffects(Item item)
        {
            this.HealthPoints += item.HealthEffect;
            this.DefensePoints += item.DefenseEffect;
            this.AttackPoints += item.AttackEffect;
        }

        protected override void RemoveItemEffects(Item item)
        {
            this.HealthPoints -= item.HealthEffect;
            this.DefensePoints -= item.DefenseEffect;
            if (this.HealthPoints < 0)
            {
                this.HealthPoints = 1;
            }
            this.AttackPoints -= item.AttackEffect;
        }

        public override string ToString()
        {
            return base.ToString() + ", Attack: " + this.AttackPoints;
        }
    }
}
