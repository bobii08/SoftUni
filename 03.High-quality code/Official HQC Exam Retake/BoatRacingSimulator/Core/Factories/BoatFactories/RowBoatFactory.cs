namespace BoatRacingSimulator.Core.Factories.BoatFactories
{
    using BoatRacingSimulator.Interfaces;
    using BoatRacingSimulator.Models.Boats;

    // Simple factory
    public static class RowBoatFactory
    {
        public static IBoat CreateBoat(string model, int weight, int oars)
        {
            return new RowBoat(model, weight, oars);
        }
    }
}