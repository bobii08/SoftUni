using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Core.Interfaces;
using Empires.Models.Interfaces;

namespace Empires.Core
{
    public class Database : IDatabase
    {
        private IList<IBuilding> buildings;
        private IDictionary<string, int> resources;
        private IDictionary<string, int> units;

        public Database()
        {
            this.buildings = new List<IBuilding>();
            this.resources = new Dictionary<string, int>();
            this.units = new Dictionary<string, int>();
        }

        public IEnumerable<IBuilding> Buildings
        {
            get { return this.buildings; }
        }

        public IDictionary<string, int> Resources
        {
            get { return this.resources; }
        }

        public IDictionary<string, int> Units
        {
            get { return this.units; }
        }

        public void AddBuilding(IBuilding building)
        {
            this.buildings.Add(building);
        }

        public void AddResource(string resourceType, int quantity)
        {
            if (!this.resources.ContainsKey(resourceType))
            {
                this.resources[resourceType] = quantity;
                return;
            }

            this.resources[resourceType] += quantity;
        }

        public void AddUnit(string unitType)
        {
            if (!this.units.ContainsKey(unitType))
            {
                this.units[unitType] = 1;
                return;
            }

            this.units[unitType] += 1;
        }
    }
}
