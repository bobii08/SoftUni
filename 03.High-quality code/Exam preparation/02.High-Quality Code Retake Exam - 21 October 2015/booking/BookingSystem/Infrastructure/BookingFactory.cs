using BookingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSystem.Infrastructure
{
    public static class BookingFactory
    {
        public static Booking CreateBooking(
            User user, 
            DateTime startDate, 
            DateTime endDate, 
            decimal totalPrice, 
            string comments)
        {
            return new Booking(user, startDate, endDate, totalPrice, comments);
        }
    }
}
