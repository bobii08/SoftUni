using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blobs.Interfaces
{
    public interface IBlobFactory
    {
        IBlob CreateBlob(string name, int health, int damage, IBehavior behaviorType, IAttack attackType);
    }
}
