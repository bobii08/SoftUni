using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.CompanyHierarchy.Interfaces;
using _03.CompanyHierarchy.Persons;

namespace _03.CompanyHierarchy
{
    class CompanyHierarchyProgram
    {
        static void Main()
        {
            Manager manager = new Manager(44123, "Georgi", "Toshev", 4213.50m, Department.Marketing,
                new List<IEmployee>()
                {
                    new SalesEmployee(9913, "Pesho", "Kolarov", 412, Department.Marketing, new List<ISale>()
                    {
                        new Sale("Butter", new DateTime(2005, 12, 12), 10),
                        new Sale("Bread", DateTime.Now, 1)
                    }),
                    new Developer(1110, "Martin", "Donchev", 900, Department.Sales, new List<IProject>()
                    {
                        new Project("Operation Alpha", new DateTime(2000,1,1), "This is operation alpha", State.Open),
                        new Project("Operation something", new DateTime(2000,5,5), "This is operation something", State.Closed)
                    })
                });

            SalesEmployee salesEmployee = new SalesEmployee(87423, "Nikolay", "Spasov", 24342, Department.Accounting,
                new List<ISale>()
                {
                    new Sale("Chocolate", DateTime.Today, 7),
                    new Sale("Coca cola", new DateTime(2012, 9, 2), 123)
                });

            Developer developer = new Developer(2312, "Stoyan", "Manov", 4422, Department.Accounting,
                new List<IProject>()
                {
                    new Project("Project Delta", new DateTime(2002, 7,4), "This is project delta", State.Open),
                    new Project("Another project", new DateTime(2005, 8,12),"This is another project", State.Open)
                });

            Person[] persons = new Person[]
            {
                manager, salesEmployee, developer
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person);
                Console.WriteLine();
            }
        }
    }
}
