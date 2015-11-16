using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LaptopShop
{
    class LaptopProgram
    {
        static void Main()
        {
            Laptop firstLaptop = new Laptop("Lenovo Yoga 2 Pro", 899.99m);
            Console.WriteLine(firstLaptop);
            Console.WriteLine();

            Laptop secondLaptop = new Laptop("ASUS 1234", 500.50m, "ASUS", "Intel Core i5-4210U", "8GB", "Intel HD Graphics 4400",
                "128 GB SSD", @"13.3"" (33.78 cm) – 3200 x 1800 (QHD+)", new Battery("Li-Ion", 4, 4.5));
            Console.WriteLine(secondLaptop);
        }
    }
}
