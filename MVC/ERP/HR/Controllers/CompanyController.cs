using HR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HR.Controllers
{
    public class CompanyController : Controller
    {
        CompanyDAL dal = new CompanyDAL();

        // ✔ SHOW ALL
        public ActionResult ShowAll()
        {
            var list = dal.GetAllCompanies();
            return View(list);
        }

        // ✔ CREATE (GET)
        public ActionResult Create()
        {
            return View();
        }

        // ✔ CREATE (POST)
        [HttpPost]
        public ActionResult Create(Company c)
        {
            if (ModelState.IsValid)
            {
                dal.AddCompany(c);
                return RedirectToAction("ShowAll");
            }
            return View(c);
        }

        // ✔ EDIT (GET)
        public ActionResult Edit(int id)
        {
            var c = dal.GetCompanyById(id);
            return View(c);
        }

        // ✔ EDIT (POST)
        [HttpPost]
        public ActionResult Edit(Company c)
        {
            if (ModelState.IsValid)
            {
                dal.UpdateCompany(c);
                return RedirectToAction("ShowAll");
            }
            return View(c);
        }

        // ✔ DELETE (GET)
        public ActionResult Delete(int id)
        {
            var c = dal.GetCompanyById(id);
            return View(c);
        }

        // ✔ DELETE (POST)
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            dal.DeleteCompany(id);
            return RedirectToAction("ShowAll");
        }
    }
}