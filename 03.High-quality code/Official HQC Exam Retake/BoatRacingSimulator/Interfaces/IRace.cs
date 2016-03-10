namespace BoatRacingSimulator.Interfaces
{
    using System;
    using System.Collections.Generic;

    using BoatRacingSimulator.Exceptions;

    /// <summary>
    /// The interface that defines the public properties and methods of a race
    /// </summary>
    public interface IRace
    {
        /// <summary>
        /// The distance in the race
        /// </summary>
        /// <exception cref="ArgumentException">If distance is non-negative (less or equal to 0) throws an exception with 
        /// the message: "Distance must be a positive integer."</exception>
        int Distance { get; }

        /// <summary>
        /// The windspeed during the race
        /// </summary>
        int WindSpeed { get; }

        /// <summary>
        /// The current speed of the ocean during the race
        /// </summary>
        int OceanCurrentSpeed { get; }

        /// <summary>
        /// Models (boats) that have implemented the IBoat interface, that have been registered for the race
        /// </summary>
        IDictionary<string, IBoat> RegisteredBoatsByModel { get; }

        /// <summary>
        /// A property that shows if the race allows for motor boats to participate in it
        /// </summary>
        bool AllowsMotorboats { get; }

        /// <summary>
        /// A method that adds a participant boat in the race
        /// </summary>
        /// <param name="boat">The boat to be added in the race</param>
        /// <exception cref="DuplicateModelException">Throws an exception with 
        /// the message "An entry for the given model already exists."</exception>
        void AddParticipant(IBoat boat);

        /// <summary>
        /// Gets the registered participants (boats implementing the IBoat interface) in the race
        /// </summary>
        /// <returns>A data structure that implements the IList interface holding the registered 
        /// participants (boats, implementing the IBoat interface), or an empty data structure if no 
        /// boats have been registered</returns>
        IList<IBoat> GetParticipants();
    }
}