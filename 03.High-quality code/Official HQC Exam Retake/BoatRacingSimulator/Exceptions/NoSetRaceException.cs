namespace BoatRacingSimulator.Exceptions
{
    using System;

    public class NoSetRaceException : ApplicationException
    {
        public NoSetRaceException(string message)
            : base(message)
        {
        }
    }
}