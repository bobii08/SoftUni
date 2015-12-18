using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicShopManager.Interfaces;

namespace MusicShop.Models
{
    public class Drums : MusicalInstrument, IDrums
    {
        private int width;
        private int height;

        public Drums(string make, string model, decimal price, string color, int width, int height)
            : base(make, model, price, color, false)
        {
            this.Width = width;
            this.Height = height;
        }

        public int Width
        {
            get { return this.width; }
            private set { this.width = value; }
        }

        public int Height
        {
            get { return this.height; }
            private set { this.height = value; }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("\nSize: {0}cm x {1}cm", this.Width, this.Height);
        }
    }
}
