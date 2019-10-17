using System;
using Microsoft.AspNetCore.Mvc;
using StudentRegistration.Models;

namespace StudentRegistration.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
        public ViewResult RegistrationForm()
        {
            return View();
        }
        public ViewResult ReceiveUserInput(Student student)
        {
            student.RegistrationTime = DateTime.Now;
            Repository.students.Add(student);
            return View("Thanks", student);
        }
        public ViewResult ListOfRegistredStudents()
        {
            return View(Repository.students);
        }
    }
}