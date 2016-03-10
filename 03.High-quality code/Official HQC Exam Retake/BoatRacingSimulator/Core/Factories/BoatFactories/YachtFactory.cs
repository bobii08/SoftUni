namespace BoatRacingSimulator.Core.Factories.BoatFactories
{
    using BoatRacingSimulator.Interfaces;
    using BoatRacingSimulator.Models.Boats;

    // Simple factory
    public static class YachtFactory
    {
        public static IBoat CreateBoat(string model, int weight, IBoatEngine boatEngine, int cargoWeight)
        {
            return new Yacht(model, weight, boatEngine, cargoWeight);
        }
    }
}