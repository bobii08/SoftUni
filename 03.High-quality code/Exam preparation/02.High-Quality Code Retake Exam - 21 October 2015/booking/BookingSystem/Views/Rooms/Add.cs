using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookingSystem.Models;

namespace BookingSystem.Views.Rooms
{
    public class Add : View
    {
        public Add(Room room)
            : base(room)
        {
        }

        protected override void BuildViewResult(StringBuilder viewResult)
        {
            var room = this.Model as Room;
            viewResult.AppendFormat("The room with ID {0} has been created successfully.", room.Id).AppendLine();
        }
    }
}
