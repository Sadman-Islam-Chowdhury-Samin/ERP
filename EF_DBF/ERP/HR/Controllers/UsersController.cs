using System;
using System.Linq;
using System.Web.Mvc;
using HR.Models;
using HR.ViewModels;

namespace HR.Controllers
{
    public class UsersController : Controller
    {
        private dberpbatch2Entities db = new dberpbatch2Entities();

        // ===========================
        // LOGIN (GET)
        // ===========================
        public ActionResult Login()
        {
            return View(new LoginViewModel());
        }

        // ===========================
        // LOGIN (POST)
        // ===========================
        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var user = db.Users.FirstOrDefault(u => u.Username == model.Name && u.Password == model.Password);

            if (user == null)
            {
                ViewBag.Error = "Invalid name or password";
                return View(model);
            }

            // Create session
            Session["UserName"] = user.Username;

            return RedirectToAction("Index", "Home");
        }

        // ===========================
        // LOGOUT
        // ===========================
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login");
        }

        // ===========================
        // REGISTER (GET)
        // ===========================
        public ActionResult Register()
        {
            return View(new User());
        }

        // ===========================
        // REGISTER (POST)
        // ===========================
        [HttpPost]
        public ActionResult Register(User user)
        {
            if (!ModelState.IsValid)
                return View(user);

            // Check duplicate usernames
            if (db.Users.Any(x => x.Username == user.Username))
            {
                ModelState.AddModelError("", "This username already exists.");
                return View(user);
            }

            db.Users.Add(user);
            db.SaveChanges();

            // Redirect to login page after successful registration
            return RedirectToAction("Login");
        }
    }
}
