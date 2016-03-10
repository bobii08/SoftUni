namespace BoatRacingSimulator.Core.Factories.BoatEngineFactories
{
    using BoatRacingSimulator.Interfaces;
    using BoatRacingSimulator.Models.BoatEngines;

    public class JetEngineFactory : BoatEngineFactory
    {
        public override IBoatEngine CreateBoatEngine(string model, int horsepower, int displacement)
        {
            return new JetEngine(model, horsepower, displacement);
        }
    }
}