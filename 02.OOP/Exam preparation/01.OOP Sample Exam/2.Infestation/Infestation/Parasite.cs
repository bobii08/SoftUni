﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class Parasite : Unit
    {
        //const int Parasite

        public Parasite(string id)
            : base(id, UnitClassification.Biological, 1, 1, 1)
        {
        }
    }
}
