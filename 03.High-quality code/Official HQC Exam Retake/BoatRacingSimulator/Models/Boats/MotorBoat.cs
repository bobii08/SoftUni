namespace BoatRacingSimulator.Models.Boats
{
    using BoatRacingSimulator.Interfaces;

    public abstract class MotorBoat : Boat, IMotorBoat
    {
        protected MotorBoat(string model, int weight, IBoatEngine boatEngine)
            : base(model, weight)
        {
            this.FirstBoatEngine = boatEngine;
        }

        public IBoatEngine FirstBoatEngine { get; private set; }
    }
}