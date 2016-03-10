namespace BoatRacingSimulator.Exceptions
{
    using System;

    public class NonExistantModelException : ApplicationException
    {
        public NonExistantModelException(string message)
            : base(message)
        {
        }
    }
}