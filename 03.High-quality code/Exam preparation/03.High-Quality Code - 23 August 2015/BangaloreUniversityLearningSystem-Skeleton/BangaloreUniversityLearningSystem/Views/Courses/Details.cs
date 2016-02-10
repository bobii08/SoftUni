namespace BangaloreUniversityLearningSystem.Views.Courses
{
    using System;
    using System.Linq;
    using System.Text;

    using BangaloreUniversityLearningSystem.Interfaces;
    using BangaloreUniversityLearningSystem.Models;

    public class Details : View
    {
        public Details(ICourse course)
            : base(course)
        {
        }

        public override void BuildViewResult(StringBuilder viewResult)
        {
            var course = this.Model as ICourse;
            viewResult.AppendLine(course.Name);
            if (!course.Lectures.Any())
            {
                viewResult.AppendLine("No lectures");
            }
            else
            {
                var lectureNames = course.Lectures.Select(l => "- " + l.Name);
                viewResult.AppendLine(string.Join(Environment.NewLine, lectureNames));
            }
        }
    }
}