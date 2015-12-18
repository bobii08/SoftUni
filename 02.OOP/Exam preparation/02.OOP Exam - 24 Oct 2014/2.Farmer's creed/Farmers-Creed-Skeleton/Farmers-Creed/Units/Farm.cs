using System.Linq;

namespace FarmersCreed.Units
{
    using System;
    using System.Collections.Generic;
    using FarmersCreed.Interfaces;

    public class Farm : GameObject, IFarm
    {
        private List<Plant> plants;
        private List<Animal> animals;
        private List<Product> products; 

        public Farm(string id)
            : base(id)
        {
        }

        public List<Plant> Plants
        {
            get { return this.plants; }
        }

        public List<Animal> Animals
        {
            get { return this.animals; }
        }

        public List<Product> Products
        {
            get { return this.products; }
        }

        public void AddAnimal(Animal animal)
        {
            this.Animals.Add(animal);
        }

        public void AddPlant(Plant plant)
        {
            this.Plants.Add(plant);
        }

        public void AddProduct(Product product)
        {
            if (this.Products.Contains(product))
            {
                var currentProduct = this.Products.First(a => a.Id == product.Id);
                currentProduct.Quantity += product.Quantity;
                return;
            }

            this.Products.Add(product);
        }

        public void Exploit(IProductProduceable productProducer)
        {
            throw new NotImplementedException();
        }

        public void Feed(Animal animal, IEdible edibleProduct, int productQuantity)
        {
            throw new NotImplementedException();
        }

        public void Water(Plant plant)
        {
            throw new NotImplementedException();
        }

        public void UpdateFarmState()
        {
            // TODO: Process all animal and plant behavior
            throw new NotImplementedException();
        }
    }
}
