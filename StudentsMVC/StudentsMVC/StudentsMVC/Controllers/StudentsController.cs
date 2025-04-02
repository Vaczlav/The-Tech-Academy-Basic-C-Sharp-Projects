using System.Collections.Generic;
using System.Web.Mvc;
using StudentsMVC.Models;

namespace StudentsMVC.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult Index()
        {
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, FirstName = "Alice", LastName = "Johnson" },
                new Student { Id = 2, FirstName = "Bob", LastName = "Smith" },
                new Student { Id = 3, FirstName = "Charlie", LastName = "Brown" }
            };

            return View(students);
        }
    }
}
