using Microsoft.AspNet.Identity;
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
        [Authorize]

        public ActionResult EmployeeOverview()
        {
            return View(UserManager.Users.ToList());
        }

        [Authorize]

        public ActionResult EmployeeData(string id)
        {
            return View(UserManager.Users.Where(a => a.Id == id).FirstOrDefault());
        }

        [Authorize]

        public ActionResult ChangeDataEmployee(string id)
        {
            return View(UserManager.Users.Where(a => a.Id == id).FirstOrDefault());
        }

        [Authorize]
        [HttpPost]

        public ActionResult ChangeDataEmployee(string id, ApplicationUser user)
        {
            var item = UserManager.Users.Where(a => a.Id == user.Id).FirstOrDefault();
            item = user;
            return RedirectToAction("EmployeeOverview");
        }

        [Authorize]

        public ActionResult RemoveEmployee(string id)
        {
            return View(UserManager.Users.Where(a => a.Id == id).FirstOrDefault());
        }

        [Authorize]
        [HttpPost]

        public ActionResult RemoveEmployee(string id, ApplicationUser user)
        {
            UserManager.Delete(user);
            return RedirectToAction("EmployeeOverview");
        }
    }
}