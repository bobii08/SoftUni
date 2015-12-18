using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estates.Interfaces;

namespace Estates.Data
{
    public class Garage : Estate, IGarage
    {
        private int width;
        private int height;

        public Garage(string name, double area, string location, EstateType type, bool isFurnished, int width, int height)
            : base(name, area, location, type, isFurnished)
        {
            this.Width = width;
            this.Height = height;
        }

        public Garage()
        {
            
        }

        public int Width
        {
            get { return this.width; }
            set
            {
                if (value < 0 || value > 50)
                {
                    throw new ArgumentOutOfRangeException("width", "Width must be in range [0...50]!");
                }
                this.width = value;
            }
        }

        public int Height
        {
            get { return this.height; }
            set
            {
                if (value < 0 || value > 50)
                {
                    throw new ArgumentOutOfRangeException("height", "Height must be in range [0...50]!");
                }
                this.height = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(", Width: {0}, Height: {1}", this.Width, this.Height);
        }
    }
}
