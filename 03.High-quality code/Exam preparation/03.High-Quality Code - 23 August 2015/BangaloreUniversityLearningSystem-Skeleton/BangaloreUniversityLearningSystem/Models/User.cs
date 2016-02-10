namespace BangaloreUniversityLearningSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using BangaloreUniversityLearningSystem.Enums;
    using BangaloreUniversityLearningSystem.Interfaces;
    using BangaloreUniversityLearningSystem.Utilities;

    public class User : IUser
    {
        private const int MinUsernameLength = 5;
        private const int MinPasswordLength = 6;

        private string passwordHash;

        private string username;

        public User(string username, string password, Role role)
        {
            this.Username = username;
            this.PasswordHash = password;
            this.Role = role;
            this.Courses = new List<ICourse>();
        }

        public string Username
        {
            get
            {
                return this.username;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("username", "The username must not be null or empty.");
                }

                if (value.Length < MinUsernameLength)
                {
                    throw new ArgumentException(
                        string.Format("The username must be at least {0} symbols long.", MinUsernameLength));
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
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("password", "The password must not be null or empty.");
                }

                if (value.Length < MinPasswordLength)
                {
                    throw new ArgumentException(
                        string.Format("The username must be at least {0} symbols long.", MinPasswordLength));
                }

                this.passwordHash = HashUtilities.HashPassword(value);
            }
        }

        public Role Role { get; private set; }

        public IList<ICourse> Courses { get; private set; }

        public bool IsInRole(Role role)
        {
            return this.Role == role;
        }
    }
}