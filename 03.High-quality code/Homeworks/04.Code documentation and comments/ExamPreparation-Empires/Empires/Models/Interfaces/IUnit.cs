using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empires.Models.Interfaces
{
    /// <summary>
    /// Represents a unit
    /// </summary>
    public interface IUnit
    {
        /// <summary>
        /// The unit's health
        /// </summary>
        int Health { get; set; }

        /// <summary>
        /// The unit's damage
        /// </summary>
        int AttackDamage { get; }
    }
}
