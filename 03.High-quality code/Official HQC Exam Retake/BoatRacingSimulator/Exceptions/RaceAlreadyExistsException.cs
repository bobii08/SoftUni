namespace BoatRacingSimulator.Exceptions
{
    using System;

    public class RaceAlreadyExistsException : ApplicationException
    {
        public RaceAlreadyExistsException(string message)
            : base(message)
        {
        }
    }
}