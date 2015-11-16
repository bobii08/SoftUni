using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PCCatalog
{
    public class Computer
    {
        private string name;
        private decimal price;

        public Computer(string name, decimal price, Component[] components)
        {
            this.Name = name;
            this.Price = price;
            this.Components = components;
        }

        public Component[] Components { get; set; }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("name should not be null or empty");
                }
                this.name = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("price", "price cannot be non-positive number");
                }
                this.price = value;
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine("Components");
            for (int i = 0; i < Components.Length; i++)
            {
                Console.WriteLine("{0}, price: {1:0.00} лв", this.Components[i].Name, this.Components[i].Price);
            }
            Console.WriteLine("Price: {0:0.00} лв", this.Price);
        }
    }
}
