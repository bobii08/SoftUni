using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookingSystem.Interfaces;

namespace BookingSystem.Models
{
    public abstract class DatabaseEntity : IDbEntity
    {
        public int Id { get; set; }
    }
}
