namespace BoatRacingSimulator.Tests
{
    using BoatRacingSimulator.Controllers;
    using BoatRacingSimulator.Enumerations;
    using BoatRacingSimulator.Exceptions;
    using BoatRacingSimulator.Interfaces;
    using BoatRacingSimulator.Models.Boats;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class StartRaceTests
    {
        private IBoatSimulatorController Controller { get; set; }

        [TestInitialize]
        public void TestInitiliaze()
        {
            this.Controller = new BoatSimulatorController();
        }

        [TestMethod]
        public void TestStartRace_ValidInputData_ShouldReturnCorrectResultMessage()
        {
            this.Controller.CreateBoatEngine("GPH01", 250, 100, EngineType.Jet);
            this.Controller.CreateBoatEngine("GPH02", 150, 150, EngineType.Sterndrive);
            this.Controller.CreateRowBoat("Rower15", 450, 6);
            this.Controller.CreatePowerBoat("PB150", 2200, "GPH01", "GPH02");
            this.Controller.CreateSailBoat("SailBoatPro", 200, 98);
            this.Controller.OpenRace(1000, 10, 5, true);
            this.Controller.SignUpBoat("SailBoatPro");
            this.Controller.SignUpBoat("Rower15");
            this.Controller.SignUpBoat("PB150");

            string actualMessage = this.Controller.StartRace();

            Assert.AreEqual("First place: PowerBoat Model: PB150 Time: 2.85 sec\r\nSecond place: RowBoat Model: Rower15 Time: 6.45 sec\r\nThird place: SailBoat Model: SailBoatPro Time: Did not finish!", actualMessage, "Incorrect result message returned");
        }

        [TestMethod]
        [ExpectedException(typeof(NoSetRaceException))]
        public void TestStartRace_NoCurrentlySetRace_ShouldThrowException()
        {
            this.Controller.CreateBoatEngine("GPH01", 250, 100, EngineType.Jet);
            this.Controller.CreateBoatEngine("GPH02", 150, 150, EngineType.Sterndrive);
            this.Controller.CreateRowBoat("Rower15", 450, 6);
            this.Controller.CreatePowerBoat("PB150", 2200, "GPH01", "GPH02");
            this.Controller.CreateSailBoat("SailBoatPro", 200, 98);

            this.Controller.StartRace();
        }

        [TestMethod]
        public void TestStartRace_AfterTheRaceHasFinishedCurrentRaceShouldBeNull_ShouldThrowException()
        {
            this.Controller.CreateBoatEngine("GPH01", 250, 100, EngineType.Jet);
            this.Controller.CreateBoatEngine("GPH02", 150, 150, EngineType.Sterndrive);
            this.Controller.CreateRowBoat("Rower15", 450, 6);
            this.Controller.CreatePowerBoat("PB150", 2200, "GPH01", "GPH02");
            this.Controller.CreateSailBoat("SailBoatPro", 200, 98);
            this.Controller.OpenRace(1000, 10, 5, true);
            this.Controller.SignUpBoat("SailBoatPro");
            this.Controller.SignUpBoat("Rower15");
            this.Controller.SignUpBoat("PB150");

            this.Controller.StartRace();

            Assert.IsNull(this.Controller.CurrentRace);
        }

        [TestMethod]
        [ExpectedException(typeof(InsufficientContestantsException))]
        public void TestStartRace_NotEnoughContestantsInTheRace_ShouldThrowException()
        {
            this.Controller.CreateBoatEngine("GPH01", 250, 100, EngineType.Jet);
            this.Controller.CreateBoatEngine("GPH02", 150, 150, EngineType.Sterndrive);
            this.Controller.CreateRowBoat("Rower15", 450, 6);
            this.Controller.CreatePowerBoat("PB150", 2200, "GPH01", "GPH02");
            this.Controller.OpenRace(1000, 10, 5, true);
            this.Controller.SignUpBoat("Rower15");
            this.Controller.SignUpBoat("PB150");

            this.Controller.StartRace();
        }
    }
}