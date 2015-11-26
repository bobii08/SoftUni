using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.GameEngine_TheSlum.Interfaces;
using _03.GameEngine_TheSlum.Items;

namespace _03.GameEngine_TheSlum.Characters
{
    public class Healer : Character, IHeal
    {
        private const int HealerDefaultHealthPoints = 75;
        private const int HealerDefaultDefensePoints = 50;
        private const int HealerHealingPoints = 60;
        private const int HealerDefaultRange = 6;

        public Healer(string id, int x, int y, Team team)
            : base(id, x, y, HealerDefaultHealthPoints, HealerDefaultDefensePoints, team, HealerDefaultRange)
        {
            this.HealingPoints = HealerHealingPoints;
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            var target = targetsList
                .Where(t => (t.Id != this.Id) && (t.Team == this.Team) && t.IsAlive)
                .OrderBy(t => t.HealthPoints)
                .First();
            return target;
        }

        public int HealingPoints { get; set; }

        public new void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
            this.HealthPoints += item.HealthEffect;
            this.DefensePoints += item.DefenseEffect;
        }

        protected override void ApplyItemEffects(Item item)
        {
            this.HealthPoints += item.HealthEffect;
            this.DefensePoints += item.DefenseEffect;
        }

        public override string ToString()
        {
            return base.ToString() + ", Healing: " + this.HealingPoints;
        }
    }
}
