namespace BoatRacingSimulator.Interfaces
{
    public interface IMotorBoat : IBoat
    {
        IBoatEngine FirstBoatEngine { get; }
    }
}