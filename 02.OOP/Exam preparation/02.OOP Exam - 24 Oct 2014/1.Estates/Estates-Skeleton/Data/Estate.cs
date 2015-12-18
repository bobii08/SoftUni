using System;
using System.Runtime.CompilerServices;
using Estates.Interfaces;

namespace Estates.Data
{
    public class Estate : IEstate
    {
        private string name;
        private double area;
        private string location;

        public Estate(string name, double area, string location, EstateType type, bool isFurnished)
        {
            this.Name = name;
            this.Area = area;
            this.Location = location;
            this.Type = type;
            this.IsFurnished = isFurnished;
        }

        public Estate()
        {
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                this.name = value;
            }
        }

        public EstateType Type { get; set; }

        public double Area
        {
            get { return this.area; }
            set
            {
                if (value < 0 || value > 10000)
                {
                    throw new ArgumentOutOfRangeException("area", "Area shoud be in range [0...10000]");
                }
                this.area = value;
            }
        }

        public string Location
        {
            get { return this.location; }
            set
            {
                this.location = value;
            }
        }

        public bool IsFurnished { get; set; }

        public override string ToString()
        {
            return string.Format("{0}: Name = {1}, Area = {2}, Location = {3}, Furnitured = {4}",
                this.GetType().Name, this.Name, this.Area, this.Location, (this.IsFurnished ? "Yes" : "No"));
        }
    }
}
