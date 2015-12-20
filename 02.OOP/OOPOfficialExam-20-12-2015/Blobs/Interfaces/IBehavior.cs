using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blobs.Interfaces
{
    public interface IBehavior
    {
        bool IsActivated { get; }

        void TriggerBehavior(IUnit unit);

        void ApplyBehaviorEffect(IUnit unit);
    }
}
