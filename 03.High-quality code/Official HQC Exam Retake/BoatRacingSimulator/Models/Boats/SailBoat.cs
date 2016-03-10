namespace BoatRacingSimulator.Models.Boats
{
    using System;

    using BoatRacingSimulator.Interfaces;
    using BoatRacingSimulator.Utility;

    public class SailBoat : Boat
    {
        private int sailEfficiency;

        public SailBoat(string model, int weight, int sailEfficiency)
            : base(model, weight)
        {
            this.SailEfficiency = sailEfficiency;
        }

        public int SailEfficiency
        {
            get
            {
                return this.sailEfficiency;
            }

            private set
            {
                if (value < Constants.SailBoatMinEfficiency || value > Constants.SailBoatMaxEfficiency)
                {
                    throw new ArgumentException(Constants.IncorrectSailEfficiencyMessage);
                }

                this.sailEfficiency = value;
            }
        }

        public override double CalculateRaceSpeed(IRace race)
        {
            return (race.WindSpeed * ((double)this.SailEfficiency / 100)) - this.Weight
                   + ((double)race.OceanCurrentSpeed / 2);
        }
    }
}