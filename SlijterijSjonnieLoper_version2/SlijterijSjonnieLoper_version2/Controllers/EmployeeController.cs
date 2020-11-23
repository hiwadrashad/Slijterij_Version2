using SlijterijSjonnieLoper_version2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SlijterijSjonnieLoper_version2.Controllers
{
    public class EmployeeController : AccountController
    {
        // GET: Employee
        public ActionResult EmployeeOverview()
        {
            return View(UserManager.Users.ToList());
        }

        public ActionResult EmployeeData(string id)
        {
            return View(UserManager.Users.Where(a => a.Id == id).FirstOrDefault());
        }

        public ActionResult ChangeDataEmployee(string id)
        {
            return View(UserManager.Users.Where(a => a.Id == id).FirstOrDefault());
        }

        [HttpPost]

        public ActionResult ChangeDataEmployee(string id, ApplicationUser user)
        {
            var item = UserManager.Users.Where(a => a.Id == user.Id).FirstOrDefault();
            item = user;
            return RedirectToAction("EmployeeOverview");
        }
    }
}