using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models
{
    public class ConvertibleChair : Chair, IConvertibleChair
    {
        private decimal initialHeight;

        public ConvertibleChair(string model, string material, decimal price, decimal height, int numberOfLegs, bool isConverted)
            : base(model, material, price, height, numberOfLegs)
        {
            this.IsConverted = isConverted;
            initialHeight = height;
        }

        public bool IsConverted { get; set; }

        public void Convert()
        {
            this.IsConverted = !this.IsConverted;
            if (this.IsConverted)
            {
                this.Height = 0.1m;
            }
            else
            {
                this.Height = initialHeight;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(", State: {0}",
                this.IsConverted ? "Converted" : "Normal");
        }
    }
}
