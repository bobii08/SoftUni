using System;
using Estates.Interfaces;

namespace Estates.Data
{
    public class House : Estate, IHouse
    {
        private int floors;

        public House()
        {
            
        }

        public House(string name, double area, string location, EstateType type, bool isFurnished, int floors)
            : base(name, area, location, type, isFurnished)
        {
            this.Floors = floors;
        }

        public int Floors
        {
            get { return this.floors; }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentOutOfRangeException("floors", "Floors must be in range [0...10]!");
                }
                this.floors = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(", Floors: {0}", this.Floors);
        }
    }
}
