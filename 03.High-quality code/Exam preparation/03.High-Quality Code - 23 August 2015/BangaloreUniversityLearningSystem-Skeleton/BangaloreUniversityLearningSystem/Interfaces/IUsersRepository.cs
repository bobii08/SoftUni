namespace BangaloreUniversityLearningSystem.Interfaces
{
    using System.Collections.Generic;

    public interface IUsersRepository<T> : IRepository<T>
    {
        IDictionary<string, IUser> UsersByUsername { get; }

        IUser GetByUsername(string username);
    }
}