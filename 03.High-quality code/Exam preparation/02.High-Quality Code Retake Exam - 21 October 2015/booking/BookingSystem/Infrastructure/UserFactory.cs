using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookingSystem.Enums;
using BookingSystem.Models;

namespace BookingSystem.Infrastructure
{
    public static class UserFactory
    {
        public static User CreateUser(string username, string password, Roles role)
        {
            return new User(username, password, role);
        }
    }
}
