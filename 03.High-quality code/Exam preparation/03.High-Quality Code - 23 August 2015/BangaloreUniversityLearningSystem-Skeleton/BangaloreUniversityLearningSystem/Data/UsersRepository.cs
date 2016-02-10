namespace BangaloreUniversityLearningSystem.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using BangaloreUniversityLearningSystem.Interfaces;
    using BangaloreUniversityLearningSystem.Models;

    public class UsersRepository : Repository<IUser>, IUsersRepository<IUser>
    {
        public UsersRepository()
        {
            this.UsersByUsername = new Dictionary<string, IUser>();
        }

        public IDictionary<string, IUser> UsersByUsername { get; private set; }

        public IUser GetByUsername(string username)
        {
            return this.Items.FirstOrDefault(u => u.Username == username);
        }

        public override void Add(IUser user)
        {
            this.UsersByUsername.Add(user.Username, user);
            base.Add(user);
        }
    }
}