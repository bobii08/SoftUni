using System;

namespace Methods
{
    class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DayOfBirth { get; set; }

        public string HomeTown { get; set; }

        public string PersonalInfo { get; set; }

        public bool IsOlderThan(Student otherStudent)
        {
            if (otherStudent == null)
            {
                throw new ArgumentNullException("otherStudent", "The argument other student is null");
            }

            if (this.DayOfBirth.CompareTo(otherStudent.DayOfBirth) < 0)
            {
                return true;
            }
            
            if (this.DayOfBirth.CompareTo(otherStudent.DayOfBirth) > 0)
            {
                return false;
            }
            
            return false;
        }
    }
}
