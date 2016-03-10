namespace BoatRacingSimulator.Tests
{
    using System;

    using BoatRacingSimulator.Controllers;
    using BoatRacingSimulator.Exceptions;
    using BoatRacingSimulator.Interfaces;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class OpenRaceActionTests
    {
        private IBoatSimulatorController Controller { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            this.Controller = new BoatSimulatorController();
        }

        [TestMethod]
        public void TestOpenRace_ValidInput_ShouldReturnCorrectSuccessfulResultMessage()
        {
            string actualMessage = this.Controller.OpenRace(1000, 10, 5, true);

            Assert.AreEqual(
                "A new race with distance 1000 meters, wind speed 10 m/s and ocean current speed 5 m/s has been set.", 
                actualMessage, 
                "Incorrect message was returned");
        }

        [TestMethod]
        public void TestOpenRace_ValidInput_SuccessfulCreation()
        {
            this.Controller.OpenRace(1000, 10, 5, true);

            Assert.AreEqual(
                1000, 
                this.Controller.CurrentRace.Distance, 
                "The distance is not the same as the passed one");
            Assert.AreEqual(
                10, 
                this.Controller.CurrentRace.WindSpeed, 
                "The wind speed is not the same as the passed one");
            Assert.AreEqual(
                5, 
                this.Controller.CurrentRace.OceanCurrentSpeed, 
                "The ocean is not the same as the passed one");
            Assert.AreEqual(
                true, 
                this.Controller.CurrentRace.AllowsMotorboats, 
                "The allows motorboad value is not the same as the passed one");
        }

        [TestMethod]
        public void TestOpenRace_ValidInput_SuccessfulSetsTheCurrentRaceToTheCreatedOne()
        {
            this.Controller.OpenRace(1000, 10, 5, true);

            Assert.IsNotNull(this.Controller.CurrentRace, "The current race must not be null");
        }

        [TestMethod]
        [ExpectedException(typeof(RaceAlreadyExistsException))]
        public void TestOpenRace_AlreadyOpenedRace_ShouldThrowException()
        {
            this.Controller.OpenRace(1000, 10, 5, true);
            this.Controller.OpenRace(1001, 11, 6, true);
        }

        [TestMethod]
        public void TestOpenRace_AlreadyOpenedRace_ShouldThrowCorrectExceptionMessage()
        {
            this.Controller.OpenRace(1000, 10, 5, true);

            try
            {
                this.Controller.OpenRace(1001, 11, 6, true);
            }
            catch (RaceAlreadyExistsException ex)
            {
                Assert.AreEqual(
                    "The current race has already been set.", 
                    ex.Message, 
                    "The error message is not correct");
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestOpenRace_InvalidDistanceValueZero_ShouldThrowException()
        {
            this.Controller.OpenRace(0, 10, 5, true);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestOpenRace_InvalidDistanceValueNegative_ShouldThrowException()
        {
            this.Controller.OpenRace(-100, 10, 5, true);
        }

        [TestMethod]
        public void TestOpenRace_InvalidDistanceValueZero_ShouldThrowCorrectExceptionMessage()
        {
            try
            {
                this.Controller.OpenRace(0, 10, 5, true);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Distance must be a positive integer.", ex.Message, "Incorrect error message thrown");
            }
        }
    }
}