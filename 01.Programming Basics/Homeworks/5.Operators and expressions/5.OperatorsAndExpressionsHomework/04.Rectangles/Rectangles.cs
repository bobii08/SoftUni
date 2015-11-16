using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Rectangles
{
    class Rectangles
    {
        static void Main()
        {
            Console.Write("width = ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("height = ");
            double height = double.Parse(Console.ReadLine());
            double perimeter = 2 * (width + height);
            double area = width * height;
            Console.WriteLine("perimeter = " + perimeter);
            Console.WriteLine("area = " + area);
        }
    }
}
