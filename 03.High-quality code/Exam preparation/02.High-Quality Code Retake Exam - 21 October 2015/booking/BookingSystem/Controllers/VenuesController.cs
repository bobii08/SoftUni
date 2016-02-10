using System;
using BookingSystem.Enums;
using BookingSystem.Interfaces;

namespace BookingSystem.Controllers
{
    using Infrastructure;
    using Models;

    public class VenuesController : Controller
    {
        public VenuesController(IHotelBookingSystemData data, User user)
            : base(data, user)
        {
        }

        public IView All()
        {
            var venues = this.Data.RepositoryWithVenues.GetAll();
            return this.GetView(venues);
        }

        public IView Details(int id)
        {
            Authorize(Roles.User, Roles.VenueAdmin);
            var venue = this.Data.RepositoryWithVenues.Get(id);
            if (venue == null)
            {
                return this.NotFound(string.Format("The venue with ID {0} does not exist.", id));
            }

            return this.GetView(venue);
        }

        public IView Rooms(int id)
        {
            var venue = this.Data.RepositoryWithVenues.Get(id);

            if (venue == null)
            {
                throw new ArgumentException(string.Format("The venue with ID {0} does not exist.", id));
            }

            return this.GetView(venue);
        }

        public IView Add(string name, string address, string description)
        {
            var newVenue = VenueFactory.CreateVenue(name, address, description, this.CurrentUser);
            this.Data.RepositoryWithVenues.Add(newVenue);
            return this.GetView(newVenue);
        }
    }
}