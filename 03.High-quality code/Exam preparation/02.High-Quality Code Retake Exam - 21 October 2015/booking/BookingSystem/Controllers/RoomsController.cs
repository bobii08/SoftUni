using BookingSystem.Enums;
using BookingSystem.Infrastructure;
using BookingSystem.Interfaces;

namespace BookingSystem.Controllers
{
    using System;
    using System.Linq;
    using Models;

    public class RoomsController : Controller
    {
        public RoomsController(IHotelBookingSystemData data, User user)
            : base(data, user)
        {
        }

        public IView Add(int id, int places, decimal pricePerDay)
        {
            this.Authorize(Roles.VenueAdmin);
            var venue = this.Data.RepositoryWithVenues.Get(id);
            if (venue == null)
            {
                return NotFound(string.Format("The venue with ID {0} does not exist.", id));
            }

            var newRoom = RoomFactory.CreateRoom(places, pricePerDay);
            venue.Rooms.Add(newRoom);
            this.Data.RepositoryWithRooms.Add(newRoom);

            return GetView(newRoom);
        }

        public IView AddPeriod(int id, DateTime startDate, DateTime endDate)
        {
            this.Authorize(Roles.VenueAdmin);
            var room = this.Data.RepositoryWithRooms.Get(id);
            if (room == null)
            {
                return NotFound(string.Format("The room with ID {0} does not exist.", id));
            }

            if (endDate < startDate)
            {
                throw new ArgumentException("The date range is invalid.");
            }

            room.AvailableDates.Add(new AvailableDate(startDate, endDate));

            return this.GetView(room);
        }

        public IView ViewBookings(int id)
        {
            this.Authorize(Roles.VenueAdmin);
            var room = this.Data.RepositoryWithRooms.Get(id);
            if (room == null)
            {
                return NotFound(string.Format("The room with ID {0} does not exist.", id));
            }

            return this.GetView(room.Bookings);
        }

        public IView Book(int id, DateTime startDate, DateTime endDate, string comments)
        {
            this.Authorize(Roles.User, Roles.VenueAdmin);
            var room = this.Data.RepositoryWithRooms.Get(id);
            if (room == null)
            {
                return NotFound(string.Format("The room with ID {0} does not exist.", id));
            }

            if (endDate < startDate)
            {
                throw new ArgumentException("The date range is invalid.");
            }

            var availablePeriod = room.AvailableDates.FirstOrDefault(d => d.StartDate <= startDate || endDate <= d.EndDate);
            if (availablePeriod == null)
            {
                throw new ArgumentException(string.Format(
                    "The room is not available to book in the period {0:dd.MM.yyyy} - {1:dd.MM.yyyy}.",
                    startDate, 
                    endDate));
            }

            decimal totalPrice = (endDate - startDate).Days * room.PricePerDay;
            var booking = BookingFactory.CreateBooking(CurrentUser, startDate, endDate, totalPrice, comments);
            room.Bookings.Add(booking);
            this.CurrentUser.Bookings.Add(booking);
            this.UpdateRoomAvailability(startDate, endDate, room, availablePeriod);

            return GetView(booking);
        }

        // This works, don't touch!
        private void UpdateRoomAvailability(DateTime startDate, DateTime endDate, Room room, AvailableDate availablePeriod)
        {
            room.AvailableDates.Remove(availablePeriod);
            var periodBeforeBooking = startDate - availablePeriod.StartDate;
            if (periodBeforeBooking > TimeSpan.Zero)
            {
                room.AvailableDates.Add(new AvailableDate(availablePeriod.StartDate, availablePeriod.StartDate.Add(periodBeforeBooking)));
            }

            var periodAfterBooking = availablePeriod.EndDate - endDate;
            if (periodAfterBooking > TimeSpan.Zero)
            {
                room.AvailableDates.Add(new AvailableDate(
                    availablePeriod.EndDate.Subtract(periodAfterBooking),
                    availablePeriod.EndDate));
            }
        }
    }
}
