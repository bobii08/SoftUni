using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empires.Models.Interfaces
{
    public interface IBuilding
    {
        int BuildingTurnsPassed { get; set; }
        int TurnsForResourceCreation { get; }
        int TurnsForUnitCreation { get; }
        IResource ProduceResource();
        IUnit ProduceUnit();
    }
}
