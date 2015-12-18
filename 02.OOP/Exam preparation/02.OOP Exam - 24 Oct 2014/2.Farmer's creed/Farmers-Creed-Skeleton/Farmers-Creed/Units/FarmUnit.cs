using FarmersCreed.Interfaces;

namespace FarmersCreed.Units
{
    using System;

    public abstract class FarmUnit : GameObject, IProductProduceable
    {
        private int health;
        private int productionQuantity;
        private Product product;

        protected FarmUnit(string id, int health, int productionQuantity)
            : base(id)
        {
            this.Health = health;
            this.ProductionQuantity = productionQuantity;
            this.IsAlive = true;
        }

        public Product Product
        {
            get { return this.product; }
            protected set { this.product = value; }
        }

        public int Health
        {
            get { return this.health; }
            set { this.health = value; }
        }

        public bool IsAlive { get; private set; }

        public int ProductionQuantity
        {
            get { return this.productionQuantity; }
            set { this.productionQuantity = value; }
        }

        public Product GetProduct()
        {
            return this.product;
        }
    }
}
