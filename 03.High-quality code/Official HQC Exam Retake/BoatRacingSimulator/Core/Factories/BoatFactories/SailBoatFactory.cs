namespace BoatRacingSimulator.Core.Factories.BoatFactories
{
    using BoatRacingSimulator.Interfaces;
    using BoatRacingSimulator.Models.Boats;

    // Simple factory
    public static class SailBoatFactory
    {
        public static IBoat CreateBoat(string model, int weight, int sailEfficiency)
        {
            return new SailBoat(model, weight, sailEfficiency);
        }
    }
}