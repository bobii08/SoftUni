using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicShopManager.Interfaces;

namespace MusicShop.Models
{
    public abstract class MusicalInstrument : Article, IInstrument
    {
        private string color;

        protected MusicalInstrument(string make, string model, decimal price, string color, bool isElectronic) : base(make, model, price)
        {
            this.Color = color;
            this.IsElectronic = isElectronic;
        }

        public string Color
        {
            get { return this.color; }
            private set { this.color = value; }
        }

        public bool IsElectronic { get; private set; }

        public override string ToString()
        {
            return base.ToString() + string.Format("\nColor: {0}\nElectronic: {1}", this.Color, (this.IsElectronic ? "yes" : "no"));
        }
    }
}
