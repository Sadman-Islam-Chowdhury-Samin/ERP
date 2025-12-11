using HR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HR.Controllers
{
    public class DepartmentController : Controller
    {
        DepartmentDAL deptDAL = new DepartmentDAL();

        // -----------------------------
        // SHOW ALL
        // -----------------------------
        public ActionResult Index()
        {
            var departments = deptDAL.GetAllDepartments();
            return View(departments); // View: /Views/Department/Index.cshtml
        }

        // -----------------------------
        // CREATE - GET
        // -----------------------------
        public ActionResult Create()
        {
            return View();
        }

        // -----------------------------
        // CREATE - POST
        // -----------------------------
        [HttpPost]
        public ActionResult Create(Department dept)
        {
            deptDAL.InsertDepartment(dept);
            return RedirectToAction("Index");
        }

        // -----------------------------
        // EDIT - GET
        // -----------------------------
        public ActionResult Edit(int id)
        {
            var department = deptDAL.GetDepartmentByID(id);
            return View(department);
        }

        // -----------------------------
        // EDIT - POST
        // -----------------------------
        [HttpPost]
        public ActionResult Edit(Department dept)
        {
            deptDAL.UpdateDepartment(dept);
            return RedirectToAction("Index");
        }

        // -----------------------------
        // DELETE
        // -----------------------------
        public ActionResult Delete(int id)
        {
            deptDAL.DeleteDepartment(id);
            return RedirectToAction("Index");
        }
    }
}
