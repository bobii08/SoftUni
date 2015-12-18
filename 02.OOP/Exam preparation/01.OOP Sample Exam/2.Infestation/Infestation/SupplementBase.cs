using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public abstract class SupplementBase : ISupplement
    {
        public void ReactTo(ISupplement otherSupplement)
        {
            throw new NotImplementedException();
        }

        public int PowerEffect { get; private set; }

        public int HealthEffect { get; private set; }

        public int AggressionEffect { get; private set; }
    }
}
