using System.Collections.Generic;

namespace StudentRegistration.Models
{
    public static class Repository
    {
        public static List<Student> students = new List<Student> { };
        public static void AddStudent(Student student)
        {
            students.Add(student);
        }
    }
}
