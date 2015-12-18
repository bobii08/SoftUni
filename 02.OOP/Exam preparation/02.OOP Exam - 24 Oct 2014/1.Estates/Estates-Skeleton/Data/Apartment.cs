using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estates.Interfaces;

namespace Estates.Data
{
    public class Apartment : BuildingEstate, IApartment
    {
        public Apartment()
        {
        }

        public Apartment(string name, double area, string location, EstateType type, bool isFurnished, int rooms, bool hasElevator)
            : base(name, area, location, type, isFurnished, rooms, hasElevator)
        {
        }
    }
}
