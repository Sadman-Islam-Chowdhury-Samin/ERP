using HR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HR.Controllers
{
    public class AttendanceController : Controller
    {
        // SHOW ALL
        public ActionResult Index()
        {
            AttendanceDAL dal = new AttendanceDAL();
            var list = dal.GetAllAttendance();
            return View(list);
        }

        // CREATE (GET)
        public ActionResult Create()
        {
            return View();
        }

        // CREATE (POST)
        [HttpPost]
        public ActionResult Create(Attendance obj)
        {
            if (ModelState.IsValid)
            {
                AttendanceDAL dal = new AttendanceDAL();
                dal.InsertAttendance(obj);
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        // EDIT (GET)
        public ActionResult Edit(int id)
        {
            AttendanceDAL dal = new AttendanceDAL();
            var attendance = dal.GetAttendanceById(id);
            return View(attendance);
        }

        // EDIT (POST)
        [HttpPost]
        public ActionResult Edit(Attendance obj)
        {
            if (ModelState.IsValid)
            {
                AttendanceDAL dal = new AttendanceDAL();
                dal.UpdateAttendance(obj);
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        // DELETE (GET)
        public ActionResult Delete(int id)
        {
            AttendanceDAL dal = new AttendanceDAL();
            var attendance = dal.GetAttendanceById(id);
            return View(attendance);
        }

        // DELETE (POST)
        [HttpPost]
        public ActionResult DeleteConfirmed(int id)
        {
            AttendanceDAL dal = new AttendanceDAL();
            dal.DeleteAttendance(id);
            return RedirectToAction("Index");
        }
    }
}