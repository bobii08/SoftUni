using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FootballLeague.Models
{
    public class Player
    {
        private const int MinimumAllowedYear = 1980;

        private string firstName;
        private string lastName;
        private decimal salary;
        private DateTime dateOfBirth;
        private Team team;

        public Player(string firstName, string lastName, decimal salary, DateTime dateOfBirth, Team team)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
            this.DateOfBirth = dateOfBirth;
            this.Team = team;
        }

        public string FirstName
        {
            get { return this.firstName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("first name", "First name cannot be null or empty!");
                }
                if (value.Length < 3)
                {
                    throw new ArgumentOutOfRangeException("first name", "First name must be at least 3 characters long!");
                }
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("last name", "Last name cannot be null or empty!");
                }
                if (value.Length < 3)
                {
                    throw new ArgumentOutOfRangeException("last name", "Last name must be at least 3 characters long!");
                }
                this.lastName = value;
            }
        }

        public decimal Salary
        {
            get { return this.salary; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("salary", "Salary cannot be a negative number!");
                }
                this.salary = value;
            }
        }

        public DateTime DateOfBirth
        {
            get { return this.dateOfBirth; }
            private set
            {
                if (value.Year < MinimumAllowedYear)
                {
                    throw new ArgumentOutOfRangeException("date of birth's year", "Date of birth's year cannot be less than " + MinimumAllowedYear);
                }
                this.dateOfBirth = value;
            }
        }

        public Team Team
        {
            get { return this.team; }
            private set { this.team = value; }
        }

        public override string ToString()
        {
            return string.Format("First name: {0}, last name: {1}, salary: {2}, date of birth: {3}, team: {4}",
                this.FirstName, this.LastName, this.Salary, this.DateOfBirth, this.Team);
        }
    }
}
