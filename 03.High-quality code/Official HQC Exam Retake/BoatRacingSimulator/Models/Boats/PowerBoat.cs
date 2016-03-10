namespace BoatRacingSimulator.Models.Boats
{
    using BoatRacingSimulator.Interfaces;

    public class PowerBoat : MotorBoat
    {
        public PowerBoat(string model, int weight, IBoatEngine firstBoatEngine, IBoatEngine secondBoatEngine)
            : base(model, weight, firstBoatEngine)
        {
            this.SecondBoatEngine = secondBoatEngine;
        }

        public IBoatEngine SecondBoatEngine { get; private set; }

        public override double CalculateRaceSpeed(IRace race)
        {
            return (this.FirstBoatEngine.Output + this.SecondBoatEngine.Output) - this.Weight
                   + ((double)race.OceanCurrentSpeed / 5);
        }
    }
}