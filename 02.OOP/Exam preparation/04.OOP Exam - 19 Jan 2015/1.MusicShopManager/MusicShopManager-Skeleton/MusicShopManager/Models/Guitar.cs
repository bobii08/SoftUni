using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicShopManager.Interfaces;

namespace MusicShop.Models
{
    public abstract class Guitar : MusicalInstrument, IGuitar
    {
        private string bodyWood;
        private string fingerboardWood;
        private int numberOfStrings;

        protected Guitar(string make, string model, decimal price, string color, bool isElectronic, string bodyWood,
            string fingerboardWood, int numberOfStrings)
            : base(make, model, price, color, isElectronic)
        {
            this.BodyWood = bodyWood;
            this.FingerboardWood = fingerboardWood;
            this.NumberOfStrings = numberOfStrings;
        }

        public string BodyWood
        {
            get { return this.bodyWood; }
            private set { this.bodyWood = value; }
        }

        public string FingerboardWood
        {
            get { return this.fingerboardWood; }
            private set { this.fingerboardWood = value; }
        }

        public int NumberOfStrings
        {
            get { return this.numberOfStrings; }
            private set { this.numberOfStrings = value; }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("\nStrings: {0}\nBody wood: {1}\nFingerboard wood: {2}",
                this.NumberOfStrings, this.BodyWood, this.FingerboardWood);
        }
    }
}
