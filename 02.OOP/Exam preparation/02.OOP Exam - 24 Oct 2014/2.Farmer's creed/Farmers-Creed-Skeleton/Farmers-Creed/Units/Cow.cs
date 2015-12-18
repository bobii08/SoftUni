using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmersCreed.Units
{
    public class Cow : Animal
    {
        private const int BaseHealth = 15;

        public Cow(string id, int productionQuantity)
            : base(id, BaseHealth, productionQuantity)
        {
            //this.Product = new Product
        }
    }
}
