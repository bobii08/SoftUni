using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    public abstract class Course
    {
        private string name;
        private string teacherName;
        private readonly IList<string> students;
        
        protected Course(string name)
        {
            this.Name = name;
            this.students = new List<string>();
        }

        protected Course(string name, string teacherName)
            : this(name)
        {
            this.TeacherName = teacherName;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("name", "Name of the course must not be null or whitespace");
                }

                this.name = value;
            }
        }

        public string TeacherName
        {
            get { return this.teacherName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("teacherName", "The name of the teacher must not be null or empty");
                }

                this.teacherName = value;
            }
        }

        public IList<string> Students
        {
            get { return this.students; }
        }

        public void AddStudent(string studentName)
        {
            if (this.students.Contains(studentName))
            {
                throw new ArgumentException(string.Format("The student with name {0} is already involved in the course",
                    studentName), studentName);
            }

            this.students.Add(studentName);
        }

        public void RemoveStudent(string studentName)
        {
            if (!this.students.Contains(studentName))
            {
                throw new ArgumentException("There is no student with the name {0} in this course", studentName);
            }

            this.students.Remove(studentName);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            var courseType = this.GetType().Name;
            result.AppendFormat("{0} {{ Name = ", courseType);
            result.Append(this.Name);
            if (this.TeacherName != null)
            {
                result.Append("; Teacher = ");
                result.Append(this.TeacherName);
            }

            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());
            
            return result.ToString();
        }

        protected string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "No present students in the course";
            }

            return "{ " + string.Join(", ", this.Students) + " }";
        }
    }
}
