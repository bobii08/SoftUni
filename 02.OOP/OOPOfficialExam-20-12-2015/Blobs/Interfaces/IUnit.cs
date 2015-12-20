using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blobs.Interfaces
{
    // I added an IUnit interface so that we can add different units, by extending IUnit, if we want, like sprites, etc.
    public interface IUnit : IDestroyable, IAttacker
    {
        string Name { get; }

        int InitialHealth { get; }

        int InitialDamage { get; }

        bool IsDead { get; }
    }
}
