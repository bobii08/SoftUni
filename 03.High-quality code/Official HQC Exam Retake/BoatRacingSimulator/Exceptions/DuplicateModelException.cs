namespace BoatRacingSimulator.Exceptions
{
    using System;

    public class DuplicateModelException : ApplicationException
    {
        public DuplicateModelException(string message)
            : base(message)
        {
        }
    }
}