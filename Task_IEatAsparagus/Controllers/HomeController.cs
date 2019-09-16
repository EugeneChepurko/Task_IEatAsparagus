using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Task_IEatAsparagus.Models;

namespace Task_IEatAsparagus.Controllers
{
    public class HomeController : Controller
    {
        private UserContext db = new UserContext();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Index(User user)
        {
            User foundUser = await db.Users.FirstOrDefaultAsync(u => u.Email == user.Email);
            if(foundUser != null)
            {
                foundUser.DateTime = DateTime.Now;
                foundUser.Count++;
                db.Entry(foundUser).State = EntityState.Modified;
                await db.SaveChangesAsync();
            }
            else
            {
                user.DateTime = DateTime.Now;
                user.Count++;
                db.Users.Add(user);
                await db.SaveChangesAsync();
            }

            return Redirect("/Home/ListOfUsers");
        }

        [HttpGet]
        public ActionResult ListOfUsers()
        {
            IEnumerable<User> users = db.Users;
            ViewBag.Users = users;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About this task";
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}