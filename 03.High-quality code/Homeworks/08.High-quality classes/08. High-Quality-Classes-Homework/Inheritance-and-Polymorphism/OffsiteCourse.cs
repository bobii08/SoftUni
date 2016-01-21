using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public class OffsiteCourse : Course
    {
        private string townName;

        public OffsiteCourse(string name)
            : base(name)
        {
        }

        public OffsiteCourse(string name, string teacherName)
            : base(name, teacherName)
        {
        }

        public OffsiteCourse(string name, string teacherName, string townName)
            : this(name, teacherName)
        {
            this.TownName = townName;
        }

        public string TownName
        {
            get { return this.townName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("townName", "Town name cannot be null or whitespace");
                }

                this.townName = value;
            }
        }
        
        public override string ToString()
        {
            StringBuilder result = new StringBuilder(base.ToString());
            if (this.TownName != null)
            {
                result.Append("; Town = ");
                result.Append(this.TownName);
            }

            result.Append(" }");

            return result.ToString();
        }
    }
}
