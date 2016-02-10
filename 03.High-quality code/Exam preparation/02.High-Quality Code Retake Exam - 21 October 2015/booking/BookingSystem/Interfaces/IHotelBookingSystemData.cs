using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookingSystem.Models;

namespace BookingSystem.Interfaces
{
    public interface IHotelBookingSystemData
    {
        IUserRepository RepositoryWithUsers { get; }
        IRepository<Venue> RepositoryWithVenues { get; }
        IRepository<Room> RepositoryWithRooms { get; }
        IRepository<Booking> RepositoryWithBookings { get; }
    }
}
