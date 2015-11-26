using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shapes.Models
{
    public class Rhombus : BasicShape
    {
        public Rhombus(double width, double height)
            : base(width, height)
        {
        }

        public override double CalculateArea()
        {
            return this.Width * this.Height;
        }

        public override double CalucaltePerimeter()
        {
            return 2 * this.Width + 2 * this.Height;
        }
    }
}
