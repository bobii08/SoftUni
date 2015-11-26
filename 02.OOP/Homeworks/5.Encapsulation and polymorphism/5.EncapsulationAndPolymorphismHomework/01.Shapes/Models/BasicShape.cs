using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Shapes.Interfaces;

namespace _01.Shapes.Models
{
    public abstract class BasicShape : IShape
    {
        private double width;
        private double height;

        protected BasicShape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get { return this.width; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("widht", "Width cannot be a non-positive number!");
                }
                this.width = value;
            }
        }

        public double Height
        {
            get { return this.width; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("height", "Height cannot be a non-positive number!");
                } 
                this.width = value;
            }
        }

        public abstract double CalculateArea();

        public abstract double CalucaltePerimeter();
    }
}
