using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.CompanyHierarchy.Interfaces;

namespace _03.CompanyHierarchy.Persons
{
    public class Manager : Employee, IManager
    {
        public Manager(int id, string firstName, string lastName, decimal salary, Department department, List<IEmployee> listOfEmployees)
            : base(id, firstName, lastName, salary, department)
        {
            this.ListOfEmployees = listOfEmployees;
        }

        public List<IEmployee> ListOfEmployees { get; set; }

        public override string ToString()
        {
            return base.ToString() + "\nEmployees: " + string.Join(", ", this.ListOfEmployees);
        }
    }
}
