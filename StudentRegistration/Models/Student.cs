using System;

namespace StudentRegistration.Models
{
    public class Student
    {
        public string StudentNumber{ get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Course { get; set; }
        public string Semester { get; set; }
        public DateTime RegistrationTime { get; set; }

        public string FullName()
        {
            return LastName + ", " + FirstName;
        }
    }
}
