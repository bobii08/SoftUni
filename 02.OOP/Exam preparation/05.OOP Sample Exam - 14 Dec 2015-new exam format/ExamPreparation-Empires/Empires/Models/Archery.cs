using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Empires.Models.Interfaces;
using Empires;

namespace Empires.Models
{
    public class Archery : Building
    {
        private const int GoldQuantity = 5;
        private const int TurnsForGoldCretion = 2;
        private const int TurnsForArcherCreation = 3;

        public Archery()
        {
        }

        public override IResource ProduceResource()
        {
            return new Resource(ResourceType.Gold, Archery.GoldQuantity);

            //else
            //{
            //    throw new InvalidOperationException(
            //        string.Format("{0} turns have passed, archery cannot produce gold yet - {1} must pass",
            //            (this.BuildingTurnsPassed % TurnsForResourceCreation), TurnsForResourceCreation));
            //}
        }

        public override IUnit ProduceUnit()
        {
            return new Archer();

            //else
            //{
            //    throw new InvalidOperationException(
            //        string.Format("{0} turns have passed, archery cannot produce archery yet - {1} must pass",
            //            (this.BuildingTurnsPassed % TurnsForUnitCreation), TurnsForUnitCreation));
            //}
        }

        public override int TurnsForResourceCreation
        {
            get { return TurnsForGoldCretion; }
        }

        public override int TurnsForUnitCreation
        {
            get { return TurnsForArcherCreation; }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("({0} turns until Archer, {1} turns until Gold)",
                   (this.TurnsForUnitCreation - (this.BuildingTurnsPassed % this.TurnsForUnitCreation)),
                   (this.TurnsForResourceCreation - (this.BuildingTurnsPassed % this.TurnsForResourceCreation)));
        }
    }
}
