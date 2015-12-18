using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Models.Interfaces;

namespace Empires.Models
{
    public abstract class Building : IBuilding
    {
        protected Building()
        {
            this.BuildingTurnsPassed = 0;
        }

        public int BuildingTurnsPassed { get; set; }

        public abstract IResource ProduceResource();

        public abstract IUnit ProduceUnit();

        public abstract int TurnsForResourceCreation { get; }

        public abstract int TurnsForUnitCreation { get; }

        public override string ToString()
        {
            return string.Format("--{0}: {1} turns ", this.GetType().Name, this.BuildingTurnsPassed);
        }
    }
}
