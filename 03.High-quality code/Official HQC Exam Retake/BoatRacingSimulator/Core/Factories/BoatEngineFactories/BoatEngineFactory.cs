namespace BoatRacingSimulator.Core.Factories.BoatEngineFactories
{
    using BoatRacingSimulator.Interfaces;

    // Factory method design pattern
    public abstract class BoatEngineFactory
    {
        public abstract IBoatEngine CreateBoatEngine(string model, int horsepower, int displacement);
    }
}