using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftwareUniversityLearningSystem
{
    class SULSTest
    {
        static void Main()
        {
            OnsiteStudent onsiteStudent = new OnsiteStudent("Ivan", "Petkanov", 23, 4312, 4.6, "Mathematics", 4);
            OnlineStudent onlineStudent = new OnlineStudent("Nikolay", "Bardarov", 30, 1231, 5.7, "Informatics");
            GraduateStudent graduateStudent = new GraduateStudent("Vlado", "Stanoev", 35, 82321, 4.1);
            DropoutStudent dropoutStudent = new DropoutStudent("Venci", "Topalov", 27, 24213, 3.4, "Too dumb to exist.");
            OnlineStudent anotherOnlineStudent = new OnlineStudent("Mitko", "Vasilev", 19, 24231, 5, "OOP");
            OnsiteStudent anotherOnsiteStudent = new OnsiteStudent("Toshe", "Pavlov", 28, 24341, 4.5, "JavaScript", 19);
            SeniorTrainer seniorTrainer = new SeniorTrainer("Svetlin", "Nakov", 35);
            JuniorTrainer juniorTrainer = new JuniorTrainer("Iordan", "Darakchiev", 24);

            List<Person> listOfPersons = new List<Person>()
            {
                onsiteStudent, 
                onlineStudent, 
                graduateStudent, 
                dropoutStudent, 
                anotherOnlineStudent, 
                anotherOnsiteStudent, 
                seniorTrainer, 
                juniorTrainer
            };

            var sortedCurrentStudents = listOfPersons
                .Where(p => p is CurrentStudent)
                .Cast<CurrentStudent>()
                .OrderBy(cs => cs.AverageGrade);
            foreach (var currentStudent in sortedCurrentStudents)
            {
                Console.WriteLine(currentStudent);
            }
        }
    }
}
