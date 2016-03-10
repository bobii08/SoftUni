namespace BoatRacingSimulator.Core.Factories.BoatFactories
{
    using BoatRacingSimulator.Interfaces;
    using BoatRacingSimulator.Models.Boats;

    // Simple factory
    public static class PowerBoatFactory
    {
        public static IBoat CreateBoat(
            string model, 
            int weight, 
            IBoatEngine firstBoatEngine, 
            IBoatEngine secondBoatEngine)
        {
            return new PowerBoat(model, weight, firstBoatEngine, secondBoatEngine);
        }
    }
}