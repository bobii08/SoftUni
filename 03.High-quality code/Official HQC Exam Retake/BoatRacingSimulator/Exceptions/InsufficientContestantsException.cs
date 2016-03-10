namespace BoatRacingSimulator.Exceptions
{
    using System;

    public class InsufficientContestantsException : ApplicationException
    {
        public InsufficientContestantsException(string message)
            : base(message)
        {
        }
    }
}