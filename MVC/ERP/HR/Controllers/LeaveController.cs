using HR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HR.Controllers
{
    public class LeaveController : Controller
    {
        LeaveDAL dal = new LeaveDAL();

        // -------- Show All --------
        public ActionResult Index()
        {
            var data = dal.GetAllLeave();
            return View(data);
        }

        // -------- Create GET --------
        public ActionResult Create()
        {
            return View();
        }

        // -------- Create POST --------
        [HttpPost]
        public ActionResult Create(Leave model)
        {
            if (ModelState.IsValid)
            {
                bool saved = dal.InsertLeave(model);
                if (saved)
                    return RedirectToAction("Index");
            }
            return View(model);
        }

        // -------- Edit GET --------
        public ActionResult Edit(int id)
        {
            var obj = dal.GetLeaveById(id);
            return View(obj);
        }

        // -------- Edit POST --------
        [HttpPost]
        public ActionResult Edit(Leave model)
        {
            if (ModelState.IsValid)
            {
                bool updated = dal.UpdateLeave(model);
                if (updated)
                    return RedirectToAction("Index");
            }
            return View(model);
        }

        // -------- Delete --------
        public ActionResult Delete(int id)
        {
            dal.DeleteLeave(id);
            return RedirectToAction("Index");
        }
    }
}