using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.CompanyHierarchy.Interfaces;

namespace _03.CompanyHierarchy.Persons
{
    class Developer : Employee, IDeveloper
    {
        public Developer(int id, string firstName, string lastName, decimal salary, Department department, List<IProject> listOfProjects)
            : base(id, firstName, lastName, salary, department)
        {
            this.ListOfProjects = listOfProjects;
        }

        public List<IProject> ListOfProjects { get; set; }

        public override string ToString()
        {
            return base.ToString() + "\nProjects: " + string.Join(", ", this.ListOfProjects);
        }
    }
}
