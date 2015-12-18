using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class Tank : Unit
    {
        // private const int BasePowerOfTank = 25;

        public Tank(string id)
            : base (id, UnitClassification.Mechanical, 20, 25, 25)
        {
        }
    }
}
