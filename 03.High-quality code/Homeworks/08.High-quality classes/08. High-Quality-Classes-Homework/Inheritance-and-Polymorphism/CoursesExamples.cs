using System;
using System.Collections.Generic;

namespace InheritanceAndPolymorphism
{
    class CoursesExamples
    {
        static void Main()
        {
            LocalCourse localCourse = new LocalCourse("Databases");
            Console.WriteLine(localCourse);

            localCourse.LabName = "Enterprise";
            Console.WriteLine(localCourse);

            localCourse.TeacherName = "Svetlin Nakov";
            localCourse.AddStudent("Milena");
            localCourse.AddStudent("Todor");
            Console.WriteLine(localCourse);

            OffsiteCourse offsiteCourse = new OffsiteCourse("PHP and WordPress Development", "Mario Peshev");

            offsiteCourse.AddStudent("Thomas");
            offsiteCourse.AddStudent("Ani");
            offsiteCourse.AddStudent("Steve");

            Console.WriteLine(offsiteCourse);
        }
    }
}
