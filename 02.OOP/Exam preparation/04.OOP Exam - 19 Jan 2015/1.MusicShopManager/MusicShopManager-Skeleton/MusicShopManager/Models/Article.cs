using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicShopManager.Interfaces;

namespace MusicShop.Models
{
    public abstract class Article : IArticle
    {
        private string make;
        private string model;
        private decimal price;

        protected Article(string make, string model, decimal price)
        {
            this.Make = make;
            this.Model = model;
            this.Price = price;
        }

        public string Make
        {
            get { return this.make; }
            private set { this.make = value; }
        }

        public string Model
        {
            get { return this.model; }
            private set { this.model = value; }
        }

        public decimal Price
        {
            get { return this.price; }
            private set { this.price = value; }
        }

        public override string ToString()
        {
            return string.Format("= {0} {1} =\nPrice: ${2:0.00}", this.Make, this.Model, this.Price);
        }
    }
}
