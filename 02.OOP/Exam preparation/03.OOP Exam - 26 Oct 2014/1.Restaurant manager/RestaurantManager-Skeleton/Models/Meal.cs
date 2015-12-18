using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantManager.Interfaces;

namespace RestaurantManager.Models
{
    public class Meal : Recipe, IMeal
    {
        public Meal(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isVegan)
            : base(name, price, calories, quantityPerServing, MetricUnit.Grams, timeToPrepare)
        {
            this.IsVegan = isVegan;
        }

        public bool IsVegan { get; private set; }

        public void ToggleVegan()
        {
            this.IsVegan = !this.IsVegan;
        }
    }
}
