using FarmersCreed.Interfaces;

namespace FarmersCreed.Units
{
    using System;

    public abstract class Plant : FarmUnit, IProductProduceable
    {
        private int growTime;

        protected Plant(string id, int health, int productionQuantity, int growTime)
            : base(id, health, productionQuantity)
        {
            this.GrowTime = growTime;
        }

        public bool HasGrown { get; protected set; }

        public int GrowTime
        {
            get { return this.growTime; }
            set { this.growTime = value; }
        }

        public void Water()
        {
            this.Health += 2;
        }

        public void Wither()
        {
            this.Health -= 1;
        }

        public void Grow()
        {
            this.GrowTime -= 1;
        }
    }
}
