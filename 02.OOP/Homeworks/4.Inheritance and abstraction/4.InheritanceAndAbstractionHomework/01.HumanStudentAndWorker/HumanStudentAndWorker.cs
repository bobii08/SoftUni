using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HumanStudentAndWorker
{
    class HumanStudentAndWorker
    {
        static void Main()
        {
            List<Student> arrayOfStudents = new List<Student>()
            {
                new Student("Pesho", "Ivanov", "24js821"),
                new Student("Ivan", "Georgiev", "f212412"),
                new Student("Sasho", "Kynev", "s32rdsfg1"),
                new Student("Boiko", "Karaveliov", "ds2fhja"),
                new Student("Nikolay", "Kochov", "jf918s"), 
                new Student("Milka", "Tancheva", "214fsa2"), 
                new Student("Irina", "Ognqnova", "2ajfJd"), 
                new Student("Katrina", "Lubenova", "8fadf21g"), 
                new Student("Rita", "Manova", "8ndakd"), 
                new Student("Iliqn", "Zonev", "j99hak")
            };

            var sortedStudents = arrayOfStudents.OrderBy(st => st.FacultyNumber).ToList();
            
            List<Worker> arrayOfWorkers = new List<Worker>()
            {
                new Worker("Pesho", "Ivanov", 150, 8),
                new Worker("Ivan", "Georgiev", 200, 8),
                new Worker("Sasho", "Kynev", 180, 7),
                new Worker("Boiko", "Karaveliov", 300, 8),
                new Worker("Nikolay", "Kochov", 270, 7), 
                new Worker("Milka", "Tancheva", 250, 6), 
                new Worker("Irina", "Ognqnova", 110, 4), 
                new Worker("Katrina", "Lubenova", 170, 7), 
                new Worker("Rita", "Manova", 200, 8), 
                new Worker("Iliqn", "Zonev", 220, 7)
            };

            var sortedWorkersDesc = arrayOfWorkers.OrderByDescending(w => w.MoneyPerHour()).ToList();

            List<Human> mergedList = new List<Human>(sortedStudents);
            mergedList.AddRange(sortedWorkersDesc);

            var sortedHumans = mergedList.OrderBy(h => h.FirstName).ThenBy(h => h.LastName).ToList();
        }
    }
}
