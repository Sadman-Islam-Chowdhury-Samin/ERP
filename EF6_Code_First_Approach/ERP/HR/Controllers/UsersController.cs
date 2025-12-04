using System.Linq;
using System.Web.Mvc;
using HR.Models;

namespace HR.Controllers
{
    public class UsersController : Controller
    {
        private HRContext db = new HRContext();

        // ===== LOGIN (GET) =====
        public ActionResult Login()
        {
            return View();
        }

        // ===== LOGIN (POST) =====
        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            var user = db.Users.FirstOrDefault(x => x.Username == username && x.Password == password);

            if (user == null)
            {
                ViewBag.Error = "Invalid username or password";
                return View();
            }

            // Set session
            Session["UserName"] = user.Username;

            return RedirectToAction("Index", "Home");
        }

        // ===== SIGN UP (GET) =====
        public ActionResult Register()
        {
            return View();
        }

        // ===== SIGN UP (POST) =====
        [HttpPost]
        public ActionResult Register(User user)
        {
            if (db.Users.Any(x => x.Username == user.Username))
            {
                ViewBag.Error = "Username already exists!";
                return View(user);
            }

            db.Users.Add(user);
            db.SaveChanges();

            return RedirectToAction("Login");
        }

        // ===== LOG OUT =====
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
