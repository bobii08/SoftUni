using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public class LocalCourse : Course
    {
        private string labName;

        public LocalCourse(string name)
            : base(name)
        {
        }

        public LocalCourse(string name, string teacherName)
            : base(name, teacherName)
        {
        }

        public LocalCourse(string name, string teacherName, string labName)
            : this(name, teacherName)
        {
            this.LabName = labName;
        }

        public string LabName
        {
            get { return this.labName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("labName", "Lab name cannot be null or empty");
                }

                this.labName = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder(base.ToString());

            if (this.LabName != null)
            {
                result.Append("; Lab = ");
                result.Append(this.LabName);
            }

            result.Append(" }");

            return result.ToString();
        }
    }
}
