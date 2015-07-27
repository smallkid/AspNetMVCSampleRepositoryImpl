using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using darkstar.core;

namespace MVCRepositoryImplSample.Controllers
{
    public class DepartmentController : Controller
    {
        IDepartmentRepository _departmentRepository;

        public DepartmentController()
        {

        }

        public DepartmentController(IDepartmentRepository departmentRepository)
        {
            _departmentRepository=departmentRepository;
        }
        // GET: Department
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddDepartment()
        {
            return View(new Department());
        }

        [HttpPost]
        public ActionResult AddDepartment(Department dep)
        {
            _departmentRepository.Add(dep);
            return RedirectToAction("Index");
        }
    }
}