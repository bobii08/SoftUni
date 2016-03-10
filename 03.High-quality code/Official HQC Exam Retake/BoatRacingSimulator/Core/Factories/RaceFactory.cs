namespace BoatRacingSimulator.Core.Factories
{
    using BoatRacingSimulator.Interfaces;
    using BoatRacingSimulator.Models;

    public static class RaceFactory
    {
        public static IRace CreateRace(int distance, int windSpeed, int oceanCurrentSpeed, bool allowsMotorboats)
        {
            return new Race(distance, windSpeed, oceanCurrentSpeed, allowsMotorboats);
        }
    }
}