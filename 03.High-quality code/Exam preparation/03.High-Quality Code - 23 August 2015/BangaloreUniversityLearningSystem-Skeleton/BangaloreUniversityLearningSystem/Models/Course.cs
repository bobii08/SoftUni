namespace BangaloreUniversityLearningSystem.Models
{
    using System;
    using System.Collections.Generic;

    using BangaloreUniversityLearningSystem.Interfaces;

    public class Course : ICourse
    {
        private const int MinNameLength = 5;

        private string name;

        public Course(string name)
        {
            this.Name = name;
            this.Lectures = new List<ILecture>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (value.Length < MinNameLength)
                {
                    throw new ArgumentException(
                        string.Format("The course name must be at least {0} symbols long.", MinNameLength));
                }

                this.name = value;
            }
        }

        public IList<ILecture> Lectures { get; set; }

        public IList<IUser> Students { get; set; }

        public void AddLecture(ILecture lecture)
        {
            this.Lectures.Add(lecture);
        }

        public void AddStudent(IUser student)
        {
            this.Students.Add(student);
            student.Courses.Add(this);
        }
    }
}