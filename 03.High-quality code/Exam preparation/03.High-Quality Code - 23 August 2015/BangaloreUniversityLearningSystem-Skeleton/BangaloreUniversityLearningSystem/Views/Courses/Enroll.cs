namespace BangaloreUniversityLearningSystem.Views.Courses
{
    using System.Text;

    using BangaloreUniversityLearningSystem.Interfaces;
    using BangaloreUniversityLearningSystem.Models;

    public class Enroll : View
    {
        public Enroll(ICourse course)
            : base(course)
        {
        }

        public override void BuildViewResult(StringBuilder viewResult)
        {
            var course = this.Model as ICourse;
            viewResult.AppendFormat("Student successfully enrolled in course {0}.", course.Name).AppendLine();
        }
    }
}