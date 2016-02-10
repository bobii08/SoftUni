namespace BangaloreUniversityLearningSystem.Views.Users
{
    using System.Text;

    using BangaloreUniversityLearningSystem.Interfaces;
    using BangaloreUniversityLearningSystem.Models;

    public class Register : View
    {
        public Register(IUser user)
            : base(user)
        {
        }

        public override void BuildViewResult(StringBuilder viewResult)
        {
            viewResult.AppendFormat("User {0} registered successfully.", (this.Model as IUser).Username).AppendLine();
        }
    }
}