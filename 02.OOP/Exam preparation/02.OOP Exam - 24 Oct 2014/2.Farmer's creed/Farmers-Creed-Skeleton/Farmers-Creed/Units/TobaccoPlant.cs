using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmersCreed.Units
{
    public class TobaccoPlant : Plant
    {
        private const int BaseHealth = 12;
        private const int GrowTime = 4;
        private const int ProductionQuantity = 10;
        private const ProductType TobaccoProductType = ProductType.Tobacco;

        public TobaccoPlant(string id, int productionQuantity)
            : base(id, BaseHealth, productionQuantity, GrowTime)
        {
        }


    }
}
