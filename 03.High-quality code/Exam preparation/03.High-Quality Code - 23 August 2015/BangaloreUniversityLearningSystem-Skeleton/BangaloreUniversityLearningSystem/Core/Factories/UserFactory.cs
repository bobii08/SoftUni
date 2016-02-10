using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangaloreUniversityLearningSystem.Core.Factories
{
    using BangaloreUniversityLearningSystem.Enums;
    using BangaloreUniversityLearningSystem.Interfaces;
    using BangaloreUniversityLearningSystem.Models;

    public static class UserFactory
    {
        public static IUser CreateUser(string username, string password, Role role)
        {
            return new User(username, password, role);
        }
    }
}
