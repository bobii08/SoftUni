using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantManager.Interfaces;

namespace RestaurantManager.Models
{
    public class Dessert : Meal, IDessert
    {
        public Dessert(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare,
            bool isVegan, bool withSugar)
            : base(name, price, calories, quantityPerServing, timeToPrepare, isVegan)
        {
            this.WithSugar = withSugar;
        }

        public bool WithSugar { get; private set; }

        public void ToggleSugar()
        {
            this.WithSugar = !this.WithSugar;
        }

        public override string ToString()
        {
            var result = base.ToString();
            if (this.IsVegan)
            {
                result = "[VEGAN] " + result;
            }
            if (!this.WithSugar)
            {
                result = "[NO SUGAR] " + result;
            }

            return result;
        }
    }
}
