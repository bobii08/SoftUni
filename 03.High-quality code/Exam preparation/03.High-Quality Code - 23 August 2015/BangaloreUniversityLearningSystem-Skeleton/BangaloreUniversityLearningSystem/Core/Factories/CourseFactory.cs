namespace BangaloreUniversityLearningSystem.Core.Factories
{
    using BangaloreUniversityLearningSystem.Interfaces;
    using BangaloreUniversityLearningSystem.Models;

    public static class CourseFactory
    {
        public static ICourse CreateCourse(string name)
        {
            return new Course(name);
        }
    }
}
