namespace BoatRacingSimulator.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using BoatRacingSimulator.Core.Factories;
    using BoatRacingSimulator.Core.Factories.BoatEngineFactories;
    using BoatRacingSimulator.Core.Factories.BoatFactories;
    using BoatRacingSimulator.Database;
    using BoatRacingSimulator.Enumerations;
    using BoatRacingSimulator.Exceptions;
    using BoatRacingSimulator.Interfaces;
    using BoatRacingSimulator.Models.Boats;
    using BoatRacingSimulator.Utility;

    public class BoatSimulatorController : IBoatSimulatorController
    {
        public BoatSimulatorController(IBoatSimulatorDatabase database, IRace currentRace)
        {
            this.Database = database;
            this.CurrentRace = currentRace;
            this.JetEngineFactory = new JetEngineFactory();
            this.SterndriveEngineFactory = new SterndriveEngineFactory();
        }

        public BoatSimulatorController()
            : this(new BoatSimulatorDatabase(), null)
        {
        }

        public IRace CurrentRace { get; private set; }

        public IBoatSimulatorDatabase Database { get; private set; }

        private JetEngineFactory JetEngineFactory { get; set; }

        private SterndriveEngineFactory SterndriveEngineFactory { get; set; }

        /// <summary>
        /// Creates a boat engine that implements the IBoatEngine interface, through Factory Method implementation. Adds
        ///  the created boat engine in the database that the controller holds
        /// </summary>
        /// <param name="model">The model of the boat engine</param>
        /// <param name="horsepower">The horse power of the boat engine</param>
        /// <param name="displacement">The displacement of the boat engine</param>
        /// <param name="engineType">The engine type to be created</param>
        /// <remarks>Made the method virtual so that it can be extended (can be added more boat engine types if needed)</remarks>
        /// <returns>A success message ("Engine model [model] with [horsepower] HP and displacement [displacement] cm3 created
        /// successfully.") or throws an appropriate exception</returns>
        public virtual string CreateBoatEngine(string model, int horsepower, int displacement, EngineType engineType)
        {
            IBoatEngine boatEngine;
            switch (engineType)
            {
                case EngineType.Jet:
                    boatEngine = this.JetEngineFactory.CreateBoatEngine(model, horsepower, displacement);
                    break;
                case EngineType.Sterndrive:
                    boatEngine = this.SterndriveEngineFactory.CreateBoatEngine(model, horsepower, displacement);
                    break;
                default:
                    throw new ArgumentException("There is no such existing boat engine");
            }

            this.Database.BoatEngines.Add(boatEngine);
            return string.Format(
                "Engine model {0} with {1} HP and displacement {2} cm3 created successfully.", 
                model, 
                horsepower, 
                displacement);
        }

        public string CreateRowBoat(string model, int weight, int oars)
        {
            IBoat boat = RowBoatFactory.CreateBoat(model, weight, oars);
            this.Database.Boats.Add(boat);

            return string.Format("Row boat with model {0} registered successfully.", model);
        }

        public string CreateSailBoat(string model, int weight, int sailEfficiency)
        {
            IBoat boat = SailBoatFactory.CreateBoat(model, weight, sailEfficiency);
            this.Database.Boats.Add(boat);

            return string.Format("Sail boat with model {0} registered successfully.", model);
        }

        public string CreatePowerBoat(
            string model, 
            int weight, 
            string firstBoatEngineModel, 
            string secondBoatEngineModel)
        {
            IBoatEngine firstBoatEngine = this.Database.BoatEngines.GetItem(firstBoatEngineModel);
            IBoatEngine secondBoatEngine = this.Database.BoatEngines.GetItem(secondBoatEngineModel);
            IBoat boat = PowerBoatFactory.CreateBoat(model, weight, firstBoatEngine, secondBoatEngine);
            this.Database.Boats.Add(boat);

            return string.Format("Power boat with model {0} registered successfully.", model);
        }

        public string CreateYacht(string model, int weight, string boatEngineModel, int cargoWeight)
        {
            IBoatEngine boatEngine = this.Database.BoatEngines.GetItem(boatEngineModel);
            IBoat boat = YachtFactory.CreateBoat(model, weight, boatEngine, cargoWeight);
            this.Database.Boats.Add(boat);

            return string.Format("Yacht with model {0} registered successfully.", model);
        }

        public string OpenRace(int distance, int windSpeed, int oceanCurrentSpeed, bool allowsMotorboats)
        {
            IRace race = RaceFactory.CreateRace(distance, windSpeed, oceanCurrentSpeed, allowsMotorboats);
            this.ValidateRaceIsEmpty();
            this.CurrentRace = race;
            return
                string.Format(
                    "A new race with distance {0} meters, wind speed {1} m/s and ocean current speed {2} m/s has been set.", 
                    distance, 
                    windSpeed, 
                    oceanCurrentSpeed);
        }

        /// <summary>
        /// Signs up a boat (a class that implements the IBoat interface), by given model, to the current race. 
        /// </summary>
        /// <param name="model">The model of the boat</param>
        /// <returns>Returns a successful message, or throws an appropriate exception (if the boat we want to add is a
        /// motor boat and the race does NOT allow motor boats to participate in it</returns>
        public string SignUpBoat(string model)
        {
            IBoat boat = this.Database.Boats.GetItem(model);
            this.ValidateRaceIsSet();
            if (!this.CurrentRace.AllowsMotorboats && (boat is IMotorBoat))
            {
                throw new ArgumentException(Constants.IncorrectBoatTypeMessage);
            }

            this.CurrentRace.AddParticipant(boat);

            return string.Format("Boat with model {0} has signed up for the current Race.", model);
        }

        public string StartRace()
        {
            this.ValidateRaceIsSet();
            var participants = this.CurrentRace.GetParticipants();
            if (participants.Count < 3)
            {
                throw new InsufficientContestantsException(Constants.InsufficientContestantsMessage);
            }

            var firstFinishedBoat = this.FindFastest(participants);
            participants.Remove(firstFinishedBoat.Value);
            var secondFinishedBoat = this.FindFastest(participants);
            participants.Remove(secondFinishedBoat.Value);
            var thirdFinishedBoat = this.FindFastest(participants);
            participants.Remove(thirdFinishedBoat.Value);

            var result = new StringBuilder();
            result.AppendLine(this.GetPrintInfo(firstFinishedBoat, "First"));
            result.AppendLine(this.GetPrintInfo(secondFinishedBoat, "Second"));
            result.Append(this.GetPrintInfo(thirdFinishedBoat, "Third"));

            this.CurrentRace = null;

            return result.ToString();
        }

        public string GetStatistic()
        {
            var totalParticipants = this.CurrentRace.GetParticipants().Count;
            var powerBoats = this.CurrentRace.GetParticipants().Where(p => p is PowerBoat).ToList();
            var rowBoats = this.CurrentRace.GetParticipants().Where(p => p is RowBoat).ToList();
            var sailBoats = this.CurrentRace.GetParticipants().Where(p => p is SailBoat).ToList();
            var yachBoats = this.CurrentRace.GetParticipants().Where(p => p is Yacht).ToList();

            var result = new StringBuilder();
            result.AppendLine(string.Format("PowerBoat -> {0:p2}", (double)powerBoats.Count / totalParticipants));
            result.AppendLine(string.Format("RowBoat -> {0:p2}", (double)rowBoats.Count / totalParticipants));
            result.AppendLine(string.Format("SailBoat -> {0:p2}", (double)sailBoats.Count / totalParticipants));
            result.Append(string.Format("Yacht -> {0:p2}", (double)yachBoats.Count / totalParticipants));

            return result.ToString();
        }

        private KeyValuePair<double, IBoat> FindFastest(IList<IBoat> participants)
        {
            // TODO probably bottle neck here
            double bestTime = double.MaxValue;
            IBoat winner = null;
            foreach (var participant in participants)
            {
                var speed = participant.CalculateRaceSpeed(this.CurrentRace);
                var time = this.CurrentRace.Distance / speed;
                if (time < bestTime && time > 0)
                {
                    bestTime = time;
                    winner = participant;
                }
            }

            if (winner == null)
            {
                winner = participants.FirstOrDefault();
                bestTime = 0;
            }

            return new KeyValuePair<double, IBoat>(bestTime, winner);
        }

        private void ValidateRaceIsSet()
        {
            if (this.CurrentRace == null)
            {
                throw new NoSetRaceException(Constants.NoSetRaceMessage);
            }
        }

        private void ValidateRaceIsEmpty()
        {
            if (this.CurrentRace != null)
            {
                throw new RaceAlreadyExistsException(Constants.RaceAlreadyExistsMessage);
            }
        }

        private string GetPrintInfo(KeyValuePair<double, IBoat> boatKeyValuePair, string place)
        {
            return string.Format(
                "{3} place: {0} Model: {1} Time: {2}", 
                boatKeyValuePair.Value.GetType().Name, 
                boatKeyValuePair.Value.Model, 
                (boatKeyValuePair.Key <= 0) ? "Did not finish!" : boatKeyValuePair.Key.ToString("0.00") + " sec", 
                place);
        }
    }
}