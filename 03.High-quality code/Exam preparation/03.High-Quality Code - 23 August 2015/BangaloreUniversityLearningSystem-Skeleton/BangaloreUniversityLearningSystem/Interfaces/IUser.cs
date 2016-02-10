namespace BangaloreUniversityLearningSystem.Interfaces
{
    using System.Collections.Generic;

    using BangaloreUniversityLearningSystem.Enums;
    using BangaloreUniversityLearningSystem.Models;

    public interface IUser
    {
        string Username { get; }

        string PasswordHash { get; }

        Role Role { get; }

        IList<ICourse> Courses { get; }

        bool IsInRole(Role role);
    }
}