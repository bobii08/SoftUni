using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empires.Models.Interfaces
{
    /// <summary>
    /// Represents a resource
    /// </summary>
    public interface IResource
    {
        /// <summary>
        /// The type of the resource
        /// </summary>
        ResourceType Type { get; }

        /// <summary>
        /// The quantity of the resource
        /// </summary>
        int Quantity { get; }
    }
}
