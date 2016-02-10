using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookingSystem.Models;

namespace BookingSystem.Infrastructure
{
    public static class RoomFactory
    {
        public static Room CreateRoom(int places, decimal pricePerDay)
        {
            return new Room(places, pricePerDay);
        }
    }
}
