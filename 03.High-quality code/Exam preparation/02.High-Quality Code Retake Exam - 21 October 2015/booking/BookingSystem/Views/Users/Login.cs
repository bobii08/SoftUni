using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookingSystem.Models;

namespace BookingSystem.Views.Users
{
    public class Login : View
    {
        public Login(User user)
            : base(user)
        {
        }

        protected override void BuildViewResult(StringBuilder viewResult)
        {
            var user = Model as User;
            viewResult.AppendFormat("The user {0} has logged in.", user.Username).AppendLine();
        }
    }
}
