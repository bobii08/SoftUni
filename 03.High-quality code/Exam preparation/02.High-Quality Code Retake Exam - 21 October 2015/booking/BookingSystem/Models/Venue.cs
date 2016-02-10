using System.Collections.Generic;
using System;
using BookingSystem.Interfaces;

namespace BookingSystem.Models
{
    public class Venue : DatabaseEntity
    {
        private const int NameAndAddressMinLength = 3;

        private string name;
        private string address;
        
        public Venue(string name, string address, string description, User owner)
        {
            this.Name = name;
            this.Address = address;
            this.Description = description;
            this.Owner = owner;
            this.Rooms = new List<Room>();
        }
        
        public string Description { get; set; }

        public User Owner { get; set; }

        public ICollection<Room> Rooms { get; set; }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length < NameAndAddressMinLength)
                {
                    throw new ArgumentException(string.Format(
                        "The venue name must be at least {0} symbols long.",
                        NameAndAddressMinLength));
                }

                this.name = value;
            }
        }

        public string Address
        {
            get { return this.address; }
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length < NameAndAddressMinLength)
                {
                    throw new ArgumentException(string.Format(
                        "The venue address must be at least {0} symbols long.",
                        NameAndAddressMinLength));
                }

                this.address = value;
            }
        }
    }
}
