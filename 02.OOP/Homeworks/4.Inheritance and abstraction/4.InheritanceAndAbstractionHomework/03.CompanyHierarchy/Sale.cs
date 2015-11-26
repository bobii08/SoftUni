using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.CompanyHierarchy.Interfaces;

namespace _03.CompanyHierarchy
{
    class Sale : ISale
    {
        private string productName;
        private decimal price;

        public Sale(string productName, DateTime date, decimal price)
        {
            this.ProductName = productName;
            this.Date = date;
            this.Price = price;
        }

        public string ProductName
        {
            get { return this.productName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("product name", "Product name cannot be null or empty!");
                }
                this.productName = value;
            }
        }

        public DateTime Date { get; set; }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("price", "Price cannot be less than zero!");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Product name: {0}, Date: {1}, Price: {2}", this.ProductName, this.Date, this.Price);
        }
    }
}
