using Employee_page.Models;
using Microsoft.AspNetCore.Mvc;

namespace Employee_page.Controllers
{
    public class EmployeeController : Controller
    {
        static List<EmployeeModel> employees = [
            new EmployeeModel { EmployeeId = 1, FirstName = "Majed", LastName = "Shuwaiee", Department = "IT", Email = "majed@gmail.com" },
            new EmployeeModel { EmployeeId = 2, FirstName = "Seleh", LastName = "Shaddad", Department = "IT", Email = "feras@gmail.com" },
            new EmployeeModel { EmployeeId = 3, FirstName = "othman", LastName = "alkous",Department = "IT", Email = "@gmail" }

            ];
        public IActionResult Index()
        {
            return View(employees);
        }




        public IActionResult Details(int id)
        {
            // Dummy data for demonstration
            var employee = new EmployeeModel { EmployeeId = 1, FirstName = "Majed", LastName = "Shuwaiee", Department = "IT", Email = "majed@gmail.com" };

            return View(employee);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(AddEmployeeForm form)
        {
            if (ModelState.IsValid)
            {
                var firstName = form.FirstName;
                var lastName = form.LastName;
                var email = form.Email;
                var department = form.Department;
                employees.Add(new EmployeeModel { FirstName = firstName, LastName = lastName, Email = email, Department = department });
            }

            return RedirectToAction("Index");
        }
    }
}
