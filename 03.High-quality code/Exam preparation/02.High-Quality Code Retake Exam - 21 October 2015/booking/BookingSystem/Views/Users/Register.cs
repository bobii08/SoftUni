using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookingSystem.Models;

namespace BookingSystem.Views.Users
{
    public class Register : View
    {
        public Register(User user)
            : base(user)
        {
        }

        protected override void BuildViewResult(StringBuilder viewResult)
        {
            var user = Model as User;
            viewResult
                .AppendFormat("The user {0} has been registered and may login.", user.Username)
                .AppendLine();
        }
    }
}
