using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Models.Interfaces;

namespace Empires.Core.Interfaces
{
    /// <summary>
    /// Represents a database
    /// </summary>
    public interface IDatabase
    {
        /// <summary>
        /// A set of buildings
        /// </summary>
        IEnumerable<IBuilding> Buildings { get; }

        /// <summary>
        /// A set of resources
        /// </summary>
        IDictionary<string, int> Resources { get; }

        /// <summary>
        /// A set of units
        /// </summary>
        IDictionary<string, int> Units { get; }

        /// <summary>
        /// Adds a building to the database
        /// </summary>
        /// <param name="building">the building to be added</param>
        void AddBuilding(IBuilding building);

        /// <summary>
        /// Adds a certain quantity of some kind of a resource to the database
        /// </summary>
        /// <param name="resourceType">the resource type to be added to the database</param>
        /// <param name="quantity">the quantity of the resource to be added</param>
        void AddResource(string resourceType, int quantity);

        /// <summary>
        /// Adds one unit of a certain type, represented as a string, to the database
        /// </summary>
        /// <param name="unitType">the unit type, represented as a string, to be added</param>
        void AddUnit(string unitType);
    }
}
