using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models
{
    public class Table : Furniture, ITable
    {
        private decimal length;
        private decimal width;
        private decimal area;

        public Table(string model, string material, decimal price, decimal height, decimal length, decimal width, decimal area)
            : base(model, material, price, height)
        {
            this.Length = length;
            this.Width = width;
            this.Area = area;
        }

        public decimal Length
        {
            get { return this.length; }
            private set
            {
                // TODO validation
                this.length = value;
            }
        }

        public decimal Width
        {
            get { return this.width; }
            private set
            {
                // TODO validation
                this.width = value;
            }
        }

        public decimal Area
        {
            get { return this.area; }
            private set
            {
                // TODO validation
                this.area = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(", Length: {0}, Width: {1}, Area: {2}", 
                this.Length, this.Width, this.Area);
        }
    }
}
