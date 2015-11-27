using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.GameEngine_TheSlum.Interfaces;
using _03.GameEngine_TheSlum.Items;

namespace _03.GameEngine_TheSlum.Characters
{
    public class Warrior : Character, IAttack
    {
        private const int WarriorDefaultHealthPoints = 200;
        private const int WarriorDefaultDefensePoints = 100;
        private const int WarriorDefaultAttackPoints = 150;
        private const int WarriorDefaultRange = 2;

        public Warrior(string id, int x, int y, Team team)
            : base(id, x, y, WarriorDefaultHealthPoints, WarriorDefaultDefensePoints, team, WarriorDefaultRange)
        {
            this.AttackPoints = WarriorDefaultAttackPoints;
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            var target = targetsList.FirstOrDefault(t => (t.Team != this.Team) && (t.Id != this.Id) && t.IsAlive);
            return target;
        }

        public int AttackPoints { get; set; }

        public new void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
            this.HealthPoints += item.HealthEffect;
            this.DefensePoints += item.DefenseEffect;
            this.AttackPoints += item.AttackEffect;
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
