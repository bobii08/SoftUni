using Estates.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estates.Data
{
    public class BuildingEstate : Estate, IBuildingEstate
    {
        private int rooms;

        public BuildingEstate(string name, double area, string location, EstateType type, bool isFurnished, int rooms, bool hasElevator)
            : base(name, area, location, type, isFurnished)
        {
            this.Rooms = rooms;
            this.HasElevator = hasElevator;
        }

        public BuildingEstate()
        {
        }

        public int Rooms
        {
            get { return this.rooms; }
            set
            {
                if (value < 0 || value > 20)
                {
                    throw new ArgumentOutOfRangeException("rooms", "Rooms must be in range [0...20]!");
                }
                this.rooms = value;
            }
        }

        public bool HasElevator { get; set; }

        public override string ToString()
        {
            return base.ToString() + string.Format(", Rooms: {0}, Elevator: {1}", this.Rooms, (this.HasElevator ? "Yes" : "No"));
        }
    }
}
