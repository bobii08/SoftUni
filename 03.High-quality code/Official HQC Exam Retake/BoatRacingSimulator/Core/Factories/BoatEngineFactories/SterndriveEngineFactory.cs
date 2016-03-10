namespace BoatRacingSimulator.Core.Factories.BoatEngineFactories
{
    using BoatRacingSimulator.Interfaces;
    using BoatRacingSimulator.Models.BoatEngines;

    public class SterndriveEngineFactory : BoatEngineFactory
    {
        public override IBoatEngine CreateBoatEngine(string model, int horsepower, int displacement)
        {
            return new SterndriveEngine(model, horsepower, displacement);
        }
    }
}