using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantManager.Interfaces;

namespace RestaurantManager.Models
{
    public class Salad : Meal, ISalad
    {
        public Salad(string name, decimal price, int calories, int quantityPerServing, 
            int timeToPrepare, bool containsPasta)
            : base(name, price, calories, quantityPerServing, timeToPrepare, true)
        {
            this.ContainsPasta = containsPasta;
        }

        public bool ContainsPasta { get; private set; }

        public override string ToString()
        {
            var result = base.ToString() + string.Format("\nContains pasta: {0}", (this.ContainsPasta ? "yes" : "no"));
            if (this.IsVegan)
            {
                result = "[VEGAN] " + result;
            }

            return result;
        }
    }
}
