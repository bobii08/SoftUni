using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftwareUniversityLearningSystem
{
    abstract class Student : Person
    {
        private int studentNumber;
        private double averageGrade;

        public Student(string firstName, string lastName, int age, int studentNumber, double averageGrade)
            : base(firstName, lastName, age)
        {
            this.StudentNumber = studentNumber;
            this.AverageGrade = averageGrade;
        }

        public int StudentNumber
        {
            get { return this.studentNumber; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("student number", "Student number cannot be negative!");
                }
                this.studentNumber = value;
            }
        }

        public double AverageGrade
        {
            get { return this.averageGrade; }
            set
            {
                if (value < 2)
                {
                    throw new ArgumentOutOfRangeException("average grade", "Average grade must be between 2 and 6!");
                }
                this.averageGrade = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(", Student number: {0}, Average grade: {1}",
                this.StudentNumber, this.AverageGrade);
        }
    }
}
