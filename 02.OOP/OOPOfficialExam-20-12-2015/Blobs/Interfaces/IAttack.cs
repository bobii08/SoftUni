using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blobs.Interfaces
{
    public interface IAttack
    {
        void ApplyAttackEffect(IUnit unit);

        int ResultedDamage(IUnit unit);
    }
}
