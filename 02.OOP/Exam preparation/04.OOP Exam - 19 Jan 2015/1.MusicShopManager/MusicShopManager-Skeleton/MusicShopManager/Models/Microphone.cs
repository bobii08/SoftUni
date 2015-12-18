using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicShopManager.Interfaces;

namespace MusicShop.Models
{
    public class Microphone : Article, IMicrophone
    {
        public Microphone(string make, string model, decimal price, bool hasCable) : base(make, model, price)
        {
            this.HasCable = hasCable;
        }
        
        public bool HasCable { get; private set; }

        public override string ToString()
        {
            return base.ToString() + string.Format("\nCable: {0}", (this.HasCable ? "yes" : "no)"));
        }
    }
}
