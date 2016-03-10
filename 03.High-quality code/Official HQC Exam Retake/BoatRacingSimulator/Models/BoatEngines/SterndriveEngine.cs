namespace BoatRacingSimulator.Models.BoatEngines
{
    using BoatRacingSimulator.Utility;

    public class SterndriveEngine : BoatEngine
    {
        public SterndriveEngine(string model, int horsepower, int displacement)
            : base(model, horsepower, displacement)
        {
        }

        public override int Output
        {
            get
            {
                if (!this.HasOutputBeenEstimated)
                {
                    this.HasOutputBeenEstimated = true;
                    this.CachedOutput = (this.Horsepower * Constants.SterndriveEngineMultiplier) + this.Displacement;

                    return this.CachedOutput;
                }

                return this.CachedOutput;
            }
        }
    }
}