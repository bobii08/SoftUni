using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HumanStudentAndWorker
{
    public class Worker : Human
    {
        public Worker(string firstName, string lastName, decimal weekSalary, int workHours)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHours = workHours;
        }

        public decimal WeekSalary { get; set; }

        public int WorkHours { get; set; }

        public decimal MoneyPerHour()
        {
            return (this.WeekSalary / 5) / this.WorkHours;
        }
    }
}
