using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookingSystem.Models;

namespace BookingSystem.Views.Venues
{
    public class Add : View
    {
        public Add(Venue venue)
            : base(venue)
        {
        }

        protected override void BuildViewResult(StringBuilder viewResult)
        {
            var venue = Model as Venue;
            viewResult
                .AppendFormat("The venue {0} with ID {1} has been created successfully.", venue.Name, venue.Id)
                .AppendLine();
        }
    }
}
