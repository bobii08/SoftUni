using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantManager.Interfaces;

namespace RestaurantManager.Models
{
    public class Recipe : IRecipe
    {
        public Recipe(string name, decimal price, int calories, int quantityPerServing, MetricUnit unit, int timeToPrepare)
        {
            this.Name = name;
            this.Price = price;
            this.Calories = calories;
            this.QuantityPerServing = quantityPerServing;
            this.Unit = unit;
            this.TimeToPrepare = timeToPrepare;
        }

        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public int Calories { get; private set; }
        public int QuantityPerServing { get; private set; }
        public MetricUnit Unit { get; private set; }
        public int TimeToPrepare { get; private set; }

        public override string ToString()
        {
            string result =
                string.Format(
                    "==  {0} == ${1:0.00}\nPer serving: {2} {3}, {4} kcal\nReady in {5} minutes",
                    this.Name, this.Price, this.QuantityPerServing, (this.Unit == MetricUnit.Grams ? "g" : "ml"), this.Calories, this.TimeToPrepare);

            return result;
        }
    }
}
