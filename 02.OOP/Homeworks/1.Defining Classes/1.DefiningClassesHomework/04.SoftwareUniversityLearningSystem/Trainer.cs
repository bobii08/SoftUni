using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftwareUniversityLearningSystem
{
    class Trainer : Person
    {
        public Trainer(string firstName, string lastName, int age)
            :base(firstName, lastName, age)
        {
        }

        public void CreateCourse(string courseName)
        {
            Console.WriteLine("{0} has been created!", courseName);
        }
    }
}
