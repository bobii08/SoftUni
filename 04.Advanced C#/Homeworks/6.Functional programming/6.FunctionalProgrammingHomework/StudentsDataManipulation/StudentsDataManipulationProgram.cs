namespace StudentsDataManipulation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    internal class StudentsDataManipulationProgram
    {
        private static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student(
                    "Martin", 
                    "Kolev", 
                    25, 
                    102914, 
                    "+3592321", 
                    "martin@abv.bg", 
                    new List<int>() { 4, 5, 6, 2 }, 
                    2), 
                new Student(
                    "Sasho", 
                    "Hristov", 
                    21, 
                    872215, 
                    "089213", 
                    "sasho@yahoo.com", 
                    new List<int>() { 6, 2, 2, 3 }, 
                    3), 
                new Student(
                    "Nikolai", 
                    "Pashov", 
                    23, 
                    230014, 
                    "08523213", 
                    "nikolay@softuni.bg", 
                    new List<int>() { 2, 5, 6, 6 }, 
                    1), 
                new Student(
                    "Sara", 
                    "Johnson", 
                    19, 
                    600213, 
                    "0212332", 
                    "sara_johnson@abv.bg", 
                    new List<int>() { 4, 4, 6, 6 }, 
                    2), 
                new Student(
                    "Johny", 
                    "Cash", 
                    25, 
                    988114, 
                    "+359 232321", 
                    "johny@yahoo.com", 
                    new List<int>() { 3, 5, 3 }, 
                    2)
            };

            var studentsByGroup = students.Where(s => s.GroupNumber == 2).OrderBy(s => s.FirstName);

            foreach (var student in studentsByGroup)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
            var studentsByFirstAndLastName = students.Where(s => s.FirstName.CompareTo(s.LastName) < 0);
            foreach (var student in studentsByFirstAndLastName)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
            var studentsByAge =
                students.Where(s => s.Age >= 18 && s.Age <= 24)
                    .Select(s => new { FirstName = s.FirstName, LastName = s.LastName, Age = s.Age });
            foreach (var info in studentsByAge)
            {
                Console.WriteLine("{0} {1}, {2}", info.FirstName, info.LastName, info.Age);
            }

            Console.WriteLine();
            var sortedStudents = students.OrderByDescending(s => s.FirstName).ThenBy(s => s.LastName);
            sortedStudents = from student in students
                             orderby student.FirstName descending, student.LastName descending
                             select student;
            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
            var filteredStudentsByEmailDomain = students.Where(s => s.Email.Contains("@abv.bg"));
            foreach (var student in filteredStudentsByEmailDomain)
            {
                Console.WriteLine(student + " Email: " + student.Email);
            }

            Console.WriteLine();
            string pattern = "^(\\+359 2\\w+|\\+3592\\w+|02\\w+)";
            Regex regex = new Regex(pattern);
            var filteredStudentsByPhone = students.Where(s => regex.IsMatch(s.Phone));
            foreach (var student in filteredStudentsByPhone)
            {
                Console.WriteLine(student + " Phone: " + student.Phone);
            }

            Console.WriteLine();
            var excellentStudents =
                students.Where(s => s.Marks.Contains(6))
                    .Select(s => new { FullName = s.FirstName + " " + s.LastName, Marks = string.Join(", ", s.Marks) });
            foreach (var excellentStudent in excellentStudents)
            {
                Console.WriteLine("{0}, Marks: {1}", excellentStudent.FullName, excellentStudent.Marks);
            }

            Console.WriteLine();
            var weakStudents = students.Where(s => s.Marks.Count(m => m == 2) == 2);
            foreach (var weakStudent in weakStudents)
            {
                Console.WriteLine(weakStudent + " | Marks: " + string.Join(", ", weakStudent.Marks));
            }

            Console.WriteLine();
            var studentsEnrolledIn2014 = students.Where(s => s.FacultyNumber % 100 == 14);
            foreach (var student in studentsEnrolledIn2014)
            {
                Console.WriteLine(student + " Factulty number: " + student.FacultyNumber);
            }
        }
    }
}