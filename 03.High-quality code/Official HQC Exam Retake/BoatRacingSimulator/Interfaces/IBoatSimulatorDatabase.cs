namespace BoatRacingSimulator.Interfaces
{
    public interface IBoatSimulatorDatabase
    {
        IRepository<IBoat> Boats { get; }

        IRepository<IBoatEngine> BoatEngines { get; }
    }
}