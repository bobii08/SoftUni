using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estates.Interfaces;

namespace Estates.Data
{
    public class Offer : IOffer
    {
        public Offer(OfferType type)
        {
            this.Type = type;
        }

        public OfferType Type { get; set; }

        public IEstate Estate { get; set; }

        public override string ToString()
        {
            return string.Format(": Estate = {0}, Location = {1}, Price = ",
                this.Estate.Name, this.Estate.Location);
        }
    }
}
