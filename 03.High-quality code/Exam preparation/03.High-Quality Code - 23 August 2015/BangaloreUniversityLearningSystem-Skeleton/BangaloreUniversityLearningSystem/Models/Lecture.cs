namespace BangaloreUniversityLearningSystem.Models
{
    using System;

    using BangaloreUniversityLearningSystem.Interfaces;

    public class Lecture : ILecture
    {
        private const int MinNameLength = 3;

        private string name;

        public Lecture(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("name", "The lecture name must not be null or empty.");
                }

                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(
                        string.Format("The lecture name must be at least {0} symbols long.", MinNameLength));
                }

                this.name = value;
            }
        }
    }
}