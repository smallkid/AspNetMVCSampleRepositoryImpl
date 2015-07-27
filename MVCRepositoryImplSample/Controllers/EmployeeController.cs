using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using darkstar.core;

namespace MVCRepositoryImplSample.Controllers
{
    public class EmployeeController : Controller
    {

        IEmployeeRepository _employeeRepo;

        public EmployeeController()
        {
        }

        public EmployeeController(IEmployeeRepository employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        public ActionResult AddEmployee() {
            //var employee = new Employee();
            return View(new Employee());
        }

        [HttpPost]
        public ActionResult AddEmployee(Employee emp)
        {
            _employeeRepo.Add(emp);
            return RedirectToAction("Index");
        }

        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
    }
}