using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.CompanyHierarchy.Interfaces;

namespace _03.CompanyHierarchy
{
    class Project : IProject
    {
        private string projectName;
        private string details;

        public Project(string projectName, DateTime startDate, string details, State state)
        {
            this.projectName = projectName;
            this.StartDate = startDate;
            this.details = details;
            this.State = state;
        }

        public string ProjectName
        {
            get { return this.projectName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("project name", "Project name cannot be null or empty!");
                }
                this.projectName = value;
            }
        }

        public DateTime StartDate { get; set; }

        public string Details
        {
            get { return this.details; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("details", "Details cannot be null or empty!");
                }
                this.details = value;
            }
        }

        public State State { get; set; }

        public void CloseProject()
        {
            this.State = State.Closed;
        }

        public override string ToString()
        {
            return string.Format("Project name: {0}, Start date: {1}, Details: {2}, State: {3}",
                this.ProjectName, this.StartDate, this.Details, this.State);
        }
    }
}
