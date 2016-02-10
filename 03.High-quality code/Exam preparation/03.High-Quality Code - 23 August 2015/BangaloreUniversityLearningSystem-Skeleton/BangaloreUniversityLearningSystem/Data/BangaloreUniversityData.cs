namespace BangaloreUniversityLearningSystem.Data
{
    using BangaloreUniversityLearningSystem.Interfaces;
    using BangaloreUniversityLearningSystem.Models;

    public class BangaloreUniversityData : IBangaloreUniversityData
    {
        public BangaloreUniversityData()
        {
            this.Users = new UsersRepository();
            this.Courses = new Repository<ICourse>();
        }

        public IUsersRepository<IUser> Users { get; private set; }

        public IRepository<ICourse> Courses { get; private set; }
    }
}