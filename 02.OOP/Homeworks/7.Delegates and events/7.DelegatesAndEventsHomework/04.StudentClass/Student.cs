using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.StudentClass
{
    public class Student
    {
        private bool assignedName = false;
        private bool assignedAge = false;

        private string name;
        private int age;

        public event PropertyChangedEventHandler PropertyChanged;

        public Student(string name, int age)
        {
            this.Name = name;
            this.assignedName = true;
            this.Age = age;
            this.assignedAge = true;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (assignedName)
                {
                    var onPropertyChange = this.PropertyChanged;
                    if (onPropertyChange != null)
                    {
                        PropertyChangedEventArgs args = new PropertyChangedEventArgs("Name", this.Name, value);
                        this.PropertyChanged(this, args);
                    }
                }

                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("name", "Name cannot be null or empty.");
                }

                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (assignedAge)
                {
                    var onPropertyChange = this.PropertyChanged;
                    if (onPropertyChange != null)
                    {
                        PropertyChangedEventArgs args = new PropertyChangedEventArgs("Age", this.Age.ToString(), value.ToString());
                        this.PropertyChanged(this, args);
                    }
                }

                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("age", "Age must be non-negative.");
                }

                this.age = value;
            }
        }
    }
}
