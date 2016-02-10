namespace BangaloreUniversityLearningSystem.Views.Users
{
    using System.Text;

    using BangaloreUniversityLearningSystem.Interfaces;
    using BangaloreUniversityLearningSystem.Models;

    public class Logout : View
    {
        public Logout(IUser user)
            : base(user)
        {
        }

        public override void BuildViewResult(StringBuilder viewResult)
        {
            // TODO: Implement me
        }
    }
}