using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Shapes.Interfaces;
using _01.Shapes.Models;

namespace _01.Shapes
{
    class ShapesProgram
    {
        static void Main()
        {
            Rectangle firstRectangle = new Rectangle(4.5, 7.3);
            Circle firstCircle = new Circle(4);
            Rhombus firstRhombus = new Rhombus(5.2, 3.75);
            BasicShape secondRectangle = new Rectangle(12, 3.1);
            BasicShape secondRhombus = new Rhombus(8, 3.1);
            Circle seocndCircle = new Circle(3.5);
            IShape[] shapes =
            {
                firstRectangle,
                firstCircle,
                firstRhombus,
                secondRectangle,
                secondRhombus,
                seocndCircle
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine("Figure: " + shape.GetType().Name + " Area= " + shape.CalculateArea() + " Perimeter= " + shape.CalucaltePerimeter());
            }
        }
    }
}
