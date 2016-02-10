using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookingSystem.Models;

namespace BookingSystem.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        User GetByUsername(string username);
    }
}
