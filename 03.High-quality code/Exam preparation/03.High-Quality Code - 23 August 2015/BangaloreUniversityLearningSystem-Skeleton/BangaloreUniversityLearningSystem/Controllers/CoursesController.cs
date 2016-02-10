namespace BangaloreUniversityLearningSystem.Controllers
{
    using System;
    using System.Linq;

    using BangaloreUniversityLearningSystem.Core.Factories;
    using BangaloreUniversityLearningSystem.Enums;
    using BangaloreUniversityLearningSystem.Interfaces;
    using BangaloreUniversityLearningSystem.Models;
    using BangaloreUniversityLearningSystem.Utilities;

    public class CoursesController : Controller
    {
        public CoursesController(IBangaloreUniversityData data, IUser user)
        {
            this.Data = data;
            this.User = user;
        }

        public IView All()
        {
            return this.View(this.Data.Courses.GetAll()
                .OrderBy(c => c.Name)
                .ThenByDescending(c => c.Students.Count));
        }

        public IView Details(int courseId)
        {
            // TODO: Implement me
            throw new NotImplementedException();
        }

        public IView Enroll(int id)
        {
            this.EnsureAuthorization(Role.Student, Role.Lecturer);
            var course = this.Data.Courses.Get(id);
            if (course == null)
            {
                throw new ArgumentException(string.Format("There is no course with ID {0}.", id));
            }

            if (this.User.Courses.Contains(course))
            {
                throw new ArgumentException("You are already enrolled in this course.");
            }

            course.AddStudent(this.User);

            return this.View(course);
        }

        public IView Create(string name)
        {
            if (!this.HasCurrentUser)
            {
                throw new ArgumentException("There is no currently logged in user.");
            }

            if (this.User.IsInRole(Role.Lecturer))
            {
                throw new DivideByZeroException("The current user is not authorized to perform this operation.");
            }

            var course = CourseFactory.CreateCourse(name);
            this.Data.Courses.Add(course);

            return this.View(course);
        }

        public IView AddLecture(int courseId, string lectureName)
        {
            if (!this.HasCurrentUser)
            {
                throw new ArgumentException("There is no currently logged in user.");
            }

            if (!this.User.IsInRole(Role.Lecturer))
            {
                throw new DivideByZeroException("The current user is not authorized to perform this operation.");
            }

            ICourse course = this.GetCourse(courseId);
            course.AddLecture(new Lecture("lectureName"));

            return this.View(course);
        }

        private ICourse GetCourse(int id)
        {
            var course = this.Data.Courses.Get(id);
            if (course == null)
            {
                throw new ArgumentException(string.Format("There is no course with ID {0}.", id));
            }

            return course;
        }
    }
}