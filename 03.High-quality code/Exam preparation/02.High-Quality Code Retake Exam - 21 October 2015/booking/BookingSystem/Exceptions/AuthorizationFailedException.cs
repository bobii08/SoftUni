using BookingSystem.Models;
using System;

namespace BookingSystem.Exceptions
{
    public class AuthorizationFailedException : ArgumentException
    {
        public AuthorizationFailedException(string message, User user)
            : base(message)
        {
            this.User = user;
        }

        public User User { get; set; }
    }
}
