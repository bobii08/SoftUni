using MusicShopManager.Interfaces;

namespace MusicShop.Models
{
    public class ElectricGuitar : Guitar, IElectricGuitar
    {
        private int numberOfAdapters;
        private int numberOfFrets;

        public ElectricGuitar(string make, string model, decimal price, string color, string bodyWood,
            string fingerboardWood, int numberOfAdapters, int numberOfFrets)
            : base(make, model, price, color, true, bodyWood, fingerboardWood, Constants.AcousticAndElectricGuitarsNumberOfStrings)
        {
            this.NumberOfAdapters = numberOfAdapters;
            this.NumberOfFrets = numberOfFrets;
        }

        public int NumberOfAdapters
        {
            get { return this.numberOfAdapters; }
            private set { this.numberOfAdapters = value; }
        }

        public int NumberOfFrets
        {
            get { return this.numberOfFrets; }
            private set { this.numberOfFrets = value; }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("\nAdapters: {0}\nFrets: {1}", this.NumberOfAdapters, this.NumberOfFrets);
        }
    }
}
