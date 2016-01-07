using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empires.Models.Interfaces
{
    /// <summary>
    /// Represents some kind of building
    /// </summary>
    public interface IBuilding
    {
        /// <summary>
        /// The turns that have passed since the building has been created
        /// </summary>
        int BuildingTurnsPassed { get; set; }

        /// <summary>
        /// The number of turns needed to pass in order for a resource to be created
        /// </summary>
        int TurnsForResourceCreation { get; }

        /// <summary>
        /// The number of turns needed to pass in order for a unit to be created
        /// </summary>
        int TurnsForUnitCreation { get; }

        /// <summary>
        /// Poduces some kind of resource
        /// </summary>
        /// <returns>Some kind of resource</returns>
        IResource ProduceResource();

        /// <summary>
        /// Produces some kind of unit
        /// </summary>
        /// <returns>Some kind of unit</returns>
        IUnit ProduceUnit();
    }
}
