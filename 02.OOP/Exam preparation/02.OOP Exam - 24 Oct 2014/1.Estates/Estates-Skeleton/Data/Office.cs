using Estates.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estates.Data
{
    public class Office : BuildingEstate, IOffice
    {
        public Office()
        {
            
        }

        public Office(string name, double area, string location, EstateType type, bool isFurnished, int rooms, bool hasElevator)
            : base(name, area, location, type, isFurnished, rooms, hasElevator)
        {
        }
    }
}
