using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empires.Models.Interfaces
{
    public interface IResource
    {
        ResourceType Type { get; }
        int Quantity { get; }
    }
}
