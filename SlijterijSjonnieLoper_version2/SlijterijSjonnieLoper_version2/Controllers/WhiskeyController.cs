using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SlijterijSjonnieLoper_version2.Controllers
{
    public class WhiskeyController : Controller
    {
        // GET: Whiskey
        public ActionResult WhiskeyOverView()
        {
            return View();
        }

        // GET: Whiskey/Details/5
        public ActionResult WhiskeyData(int id)
        {
            return View();
        }

        // GET: Whiskey/Create
        public ActionResult AddNewWhiskey()
        {
            return View();
        }

        // POST: Whiskey/Create
        [HttpPost]
        public ActionResult AddNewWhiskey(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Whiskey/Edit/5
        public ActionResult ChangeWhiskeyData(int id)
        {
            return View();
        }

        // POST: Whiskey/Edit/5
        [HttpPost]
        public ActionResult ChangeWhiskeyData(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
