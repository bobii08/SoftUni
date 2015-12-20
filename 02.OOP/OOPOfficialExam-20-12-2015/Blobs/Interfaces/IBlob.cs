using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blobs.Models.EventHandlers;

namespace Blobs.Interfaces
{
    public interface IBlob : IUnit, IUpdateable
    {
        IBehavior Behavior { get; }

        IAttack AttackType { get; }

        event ToggledBehaviorEventHandler OnToggledBehavior;

        event BlobKilledEventHandler OnBlobKilled;
    }
}
