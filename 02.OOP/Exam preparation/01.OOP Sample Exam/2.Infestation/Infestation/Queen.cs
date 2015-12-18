using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class Queen : Unit
    {
        public Queen(string unitId)
            :base(unitId, UnitClassification.Psionic, 30, 1, 1)
        {
            
        }
    }
}
