namespace BoatRacingSimulator.Models.BoatEngines
{
    using BoatRacingSimulator.Interfaces;
    using BoatRacingSimulator.Utility;

    public abstract class BoatEngine : IBoatEngine
    {
        private int displacement;

        private int horsepower;

        private string model;

        protected BoatEngine(string model, int horsepower, int displacement)
        {
            this.Model = model;
            this.Horsepower = horsepower;
            this.Displacement = displacement;
        }

        public abstract int Output { get; }

        public string Model
        {
            get
            {
                return this.model;
            }

            private set
            {
                Validator.ValidateModelLength(value, Constants.MinBoatEngineModelLength);
                this.model = value;
            }
        }

        public int Horsepower
        {
            get
            {
                return this.horsepower;
            }

            private set
            {
                Validator.ValidatePositivePropertyValue(value, "Horsepower");
                this.horsepower = value;
            }
        }

        public int Displacement
        {
            get
            {
                return this.displacement;
            }

            private set
            {
                Validator.ValidatePositivePropertyValue(value, "Displacement");
                this.displacement = value;
            }
        }

        protected bool HasOutputBeenEstimated { get; set; }

        protected int CachedOutput { get; set; }
    }
}