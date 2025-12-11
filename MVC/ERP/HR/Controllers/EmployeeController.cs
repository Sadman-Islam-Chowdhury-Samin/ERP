//using HR.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;

//namespace HR.Controllers
//{
//    public class EmployeeController : Controller
//    {
//        // GET: Employee
//        public ActionResult Index()
//        {
//            return View();
//        }
//        public ActionResult NewEmployee()
//        {
//            return View();
//        }
//        [HttpPost]
//        public ActionResult NewEmployee(Employee objEmployee)
//        {

//            EmployeeDAL objEmployeeDAL = new EmployeeDAL();
//            objEmployeeDAL.InsertEmployee(objEmployee);
//            return View();
//        }

//        public ActionResult ShowEmployee()
//        {
//            return View();
//        }
//    }
//}

using HR.Models;
using System.Web.Mvc;

namespace HR.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeDAL _dal = new EmployeeDAL();

        // GET: Employee (list)
        public ActionResult Index()
        {
            var list = _dal.GetAll();
            return View(list);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View(new Employee());
        }

        // POST: Employee/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee model)
        {
            if (!ModelState.IsValid) return View(model);

            _dal.InsertEmployee(model);
            return RedirectToAction("Index");
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            var emp = _dal.GetById(id);
            if (emp == null) return HttpNotFound();
            return View(emp);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee model)
        {
            if (!ModelState.IsValid) return View(model);
            _dal.UpdateEmployee(model);
            return RedirectToAction("Index");
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            var emp = _dal.GetById(id);
            if (emp == null) return HttpNotFound();
            return View(emp);
        }

        // POST: Employee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _dal.DeleteEmployee(id);
            return RedirectToAction("Index");
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            var emp = _dal.GetById(id);
            if (emp == null) return HttpNotFound();
            return View(emp);
        }
    }
}
