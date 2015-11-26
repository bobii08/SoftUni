using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.CompanyHierarchy.Interfaces;

namespace _03.CompanyHierarchy.Persons
{
    class SalesEmployee : Employee, ISalesEmployee
    {
        public SalesEmployee(int id, string firstName, string lastName, decimal salary, Department department, List<ISale> listOfSales)
            : base(id, firstName, lastName, salary, department)
        {
            this.ListOfSales = listOfSales;
        }

        public List<ISale> ListOfSales { get; set; }

        public override string ToString()
        {
            return base.ToString() + "\nSales: " + string.Join(", ", this.ListOfSales);
        }
    }
}
