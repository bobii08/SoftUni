namespace FarmersCreed.Units
{
    using System;
    using FarmersCreed.Interfaces;

    public abstract class Animal : FarmUnit
    {
        protected Animal(string id, int health, int productionQuantity)
            : base(id, health, productionQuantity)
        {
        }

        public void Eat(IEdible food, int quantity)
        {
            food.Quantity -= quantity;
            this.Health += quantity;
        }

        public void Starve()
        {
            this.Health -= 1;
        }
    }
}
