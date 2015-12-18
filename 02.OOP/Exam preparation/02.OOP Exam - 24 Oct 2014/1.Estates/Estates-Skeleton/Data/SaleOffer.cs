using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estates.Interfaces;

namespace Estates.Data
{
    public class SaleOffer : Offer, ISaleOffer
    {
        private decimal price;

        public SaleOffer(OfferType type)
            : base(type)
        {
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                this.price = value;
            }
        }

        public override string ToString()
        {
            return "Sale" + base.ToString() + this.Price;
        }
    }
}
