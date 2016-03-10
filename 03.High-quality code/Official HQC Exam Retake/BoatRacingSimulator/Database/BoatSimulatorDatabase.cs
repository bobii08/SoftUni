namespace BoatRacingSimulator.Database
{
    using BoatRacingSimulator.Interfaces;

    public class BoatSimulatorDatabase : IBoatSimulatorDatabase
    {
        public BoatSimulatorDatabase()
        {
            this.Boats = new Repository<IBoat>();
            this.BoatEngines = new Repository<IBoatEngine>();
        }

        public IRepository<IBoat> Boats { get; private set; }

        public IRepository<IBoatEngine> BoatEngines { get; private set; }
    }
}