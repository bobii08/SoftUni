using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estates.Interfaces;

namespace Estates.Data
{
    class RentOffer : Offer, IRentOffer
    {
        private decimal pricePerMonth;

        public RentOffer(OfferType type)
            : base(type)
        {
        }

        public decimal PricePerMonth
        {
            get { return this.pricePerMonth; }
            set { this.pricePerMonth = value; }
        }

        public override string ToString()
        {
            return "Rent" + base.ToString() + this.PricePerMonth;
        }
    }
}
