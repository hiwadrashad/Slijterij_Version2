using SlijterijSjonnieLoper_version2.DAL;
using SlijterijSjonnieLoper_version2.Models;
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
            return View(MockdataService.GetMockdataService().GetAllWhiskeys());
        }

        // GET: Whiskey/Details/5
        public ActionResult WhiskeyData(string id)
        {
            return View(MockdataService.GetMockdataService().GetWhiskey(id));
        }

        // GET: Whiskey/Create
        public ActionResult AddNewWhiskey()
        {
            return View();
        }

        // POST: Whiskey/Create
        [HttpPost]
        public ActionResult AddNewWhiskey(WhiskeyModel whiskey)
        {
            try
            {
                // TODO: Add insert logic here
                MockdataService.GetMockdataService().AddWhiskey(whiskey);
                return RedirectToAction("WhiskeyOverView");
            }
            catch
            {
                return View();
            }
        }

        // GET: Whiskey/Edit/5
        public ActionResult ChangeWhiskeyData(string id)
        {
            return View(MockdataService.GetMockdataService().GetWhiskey(id));
        }

        // POST: Whiskey/Edit/5
        [HttpPost]
        public ActionResult ChangeWhiskeyData(string id, WhiskeyModel whiskey)
        {
            try
            {
                // TODO: Add update logic here
                MockdataService.GetMockdataService().UpdateWhiskey(whiskey);
                return RedirectToAction("WhiskeyOverView");
            }
            catch
            {
                return View();
            }
        }
    }
}
