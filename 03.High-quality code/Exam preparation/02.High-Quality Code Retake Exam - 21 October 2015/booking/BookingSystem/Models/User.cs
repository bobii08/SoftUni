using System.Collections.Generic;
using System;
using BookingSystem.Enums;
using BookingSystem.Interfaces;
using BookingSystem.Utilities;

namespace BookingSystem.Models
{
    public class User : DatabaseEntity
    {
        private const int UsernameMinLength = 5;
        private const int PasswordMinLength = 6;

        private string username;
        private string passwordHash;

        public User(string username, string password, Roles role)
        {
            this.Username = username;
            this.PasswordHash = password;
            this.Role = role;
            this.Bookings = new List<Booking>();
        }

        public Roles Role { get; private set; }

        public ICollection<Booking> Bookings { get; private set; }
        
        public string Username
        {
            get
            {
                return this.username;
            }
            
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length < UsernameMinLength)
                {
                    throw new ArgumentException(string.Format("The username must be at least {0} symbols long.", UsernameMinLength));
                }

                this.username = value;
            }
        }

        public string PasswordHash
        {
            get
            {
                return this.passwordHash;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length < PasswordMinLength)
                {
                    throw new ArgumentException(string.Format("The password must be at least {0} symbols long.", PasswordMinLength));
                }
                
                this.passwordHash = HashUtilities.GetSha256Hash(value);
            }
        }

        public bool IsInRole(Roles role)
        {
            return this.Role == role;
        }
    }
}
