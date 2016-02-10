namespace BangaloreUniversityLearningSystem.Interfaces
{
    using BangaloreUniversityLearningSystem.Models;

    public interface IBangaloreUniversityData
    {
        IUsersRepository<IUser> Users { get; }

        IRepository<ICourse> Courses { get; }
    }
}