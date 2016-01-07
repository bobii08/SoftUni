using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Models.Interfaces;

namespace Empires.Models
{
    public class Barracks : Building
    {
        private const int SteelQuantity = 10;
        private const int TurnsForSteelCreation = 3;
        private const int TurnsForSwordsmanCreation = 4;

        public Barracks()
        {
        }

        public override IResource ProduceResource()
        {
            return new Resource(ResourceType.Steel, SteelQuantity);

            //else
            //{
            //    throw new InvalidOperationException(
            //        string.Format("{0} turns have passed, barracks cannot produce steel yet - {1} must pass",
            //            (this.BuildingTurnsPassed % TurnsForResourceCreation), TurnsForResourceCreation));
            //}
        }

        public override IUnit ProduceUnit()
        {
            return new Swordsman();

            //else
            //{
            //    throw new InvalidOperationException(
            //        string.Format("{0} turns have passed, barracks cannot produce swordsman yet - {1} must pass",
            //            (this.BuildingTurnsPassed % TurnsForUnitCreation), TurnsForUnitCreation));
            //}
        }

        public override int TurnsForResourceCreation
        {
            get { return TurnsForSteelCreation; }
        }

        public override int TurnsForUnitCreation
        {
            get { return TurnsForSwordsmanCreation; }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("({0} turns until Swordsman, {1} turns until Steel)",
                (this.TurnsForUnitCreation - (this.BuildingTurnsPassed % this.TurnsForUnitCreation)),
                (this.TurnsForResourceCreation - (this.BuildingTurnsPassed % this.TurnsForResourceCreation)));
        }
    }
}
