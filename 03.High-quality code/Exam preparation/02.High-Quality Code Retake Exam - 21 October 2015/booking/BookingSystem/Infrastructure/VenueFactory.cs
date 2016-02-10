using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookingSystem.Models;

namespace BookingSystem.Infrastructure
{
    public static class VenueFactory
    {
        public static Venue CreateVenue(string name, string address, string description, User currentUser)
        {
            return new Venue(name, address, description, currentUser);
        }
    }
}
