namespace BoatRacingSimulator.Models
{
    using System.Collections.Generic;
    using System.Linq;

    using BoatRacingSimulator.Exceptions;
    using BoatRacingSimulator.Interfaces;
    using BoatRacingSimulator.Utility;

    public class Race : IRace
    {
        private int distance;

        public Race(int distance, int windSpeed, int oceanCurrentSpeed, bool allowsMotorboats)
        {
            this.Distance = distance;
            this.WindSpeed = windSpeed;
            this.OceanCurrentSpeed = oceanCurrentSpeed;
            this.AllowsMotorboats = allowsMotorboats;
            this.RegisteredBoatsByModel = new Dictionary<string, IBoat>();
        }

        public IDictionary<string, IBoat> RegisteredBoatsByModel { get; set; }

        public int Distance
        {
            get
            {
                return this.distance;
            }

            private set
            {
                Validator.ValidatePositivePropertyValue(value, "Distance");
                this.distance = value;
            }
        }

        public int WindSpeed { get; private set; }

        public int OceanCurrentSpeed { get; private set; }

        public bool AllowsMotorboats { get; private set; }

        public void AddParticipant(IBoat boat)
        {
            if (this.RegisteredBoatsByModel.ContainsKey(boat.Model))
            {
                throw new DuplicateModelException(Constants.DuplicateModelMessage);
            }

            this.RegisteredBoatsByModel.Add(boat.Model, boat);
        }

        public IList<IBoat> GetParticipants()
        {
            var result = this.RegisteredBoatsByModel.Select(kvp => kvp.Value).ToList();

            return result;
        }
    }
}