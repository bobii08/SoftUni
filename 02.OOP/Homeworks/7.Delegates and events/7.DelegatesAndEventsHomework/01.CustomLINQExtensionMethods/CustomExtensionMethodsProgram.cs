using System;
using System.Collections.Generic;

namespace _01.CustomLINQExtensionMethods
{
    class CustomExtensionMethodsProgram
    {
        static void Main()
        {
            List<int> nums = new List<int>() { 1, 2, 3, 14, 5, 6, 7, 8, 9, 10 };
            var filteredCollection = nums.WhereNot(x => x % 2 == 0);
            Console.Write("Filtered elements: ");
            Console.WriteLine(string.Join(", ", filteredCollection));

            var students = new List<Student>()
            {
                new Student("Pesho", 3),
                new Student("Gosho", 2),
                new Student("Mariika", 7),
                new Student("Stamat", 5)
            };

            Console.WriteLine("Biggest age of the students: " + students.Max(student => student.Grade));
        }

        private class Student
        {
            public Student(string name, int grade)
            {
                this.Name = name;
                this.Grade = grade;
            }

            public string Name { get; set; }
            public int Grade { get; set; }
        }
    }
}
