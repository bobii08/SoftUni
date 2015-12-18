using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models
{
    public abstract class Furniture : IFurniture
    {
        private string model;
        private string material;
        private decimal price;
        private decimal height;

        protected Furniture(string model, string material, decimal price, decimal height)
        {
            this.Model = model;
            this.Material = material;
            this.Price = price;
            this.Height = height;
        }

        public string Model
        {
            get { return this.model; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
                {
                    throw new ArgumentException("model", "Model cannot be null, empty or less than 3 symbols long!");
                }
                this.model = value;
            }
        }

        public string Material
        {
            get { return this.material; }
            private set
            {
                this.material = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("price", "Price cannot be less or equal to $0.00!");
                }
                this.price = value;
            }
        }

        public decimal Height
        {
            get { return this.height; }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("height", "Height cannot be less or equal to 0.00m!");
                }
                this.height = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Type: {0}, Model: {1}, Material: {2}, Price: {3:0.00}, Height: {4:0.00}",
                this.GetType().Name, this.Model, this.Material, this.Price, this.Height);
        }
    }
}
