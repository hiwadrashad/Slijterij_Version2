using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SlijterijSjonnieLoper_version2.Controllers
{
    public class ReservationController : Controller
    {
        // GET: ReservationAdd
        public ActionResult ReservationOverview()
        {
            return View();
        }

        // GET: ReservationAdd/Details/5
        public ActionResult ReservationData(int id)
        {
            return View();
        }

        // GET: ReservationAdd/Create
        public ActionResult GenerateNewReservation()
        {
            return View();
        }

        // POST: ReservationAdd/Create
        [HttpPost]
        public ActionResult GenerateNewReservation(FormCollection collection)
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

        // GET: ReservationAdd/Edit/5
        public ActionResult ChangeDataReservation(int id)
        {
            return View();
        }

        // POST: ReservationAdd/Edit/5
        [HttpPost]
        public ActionResult ChangeDataReservation(int id, FormCollection collection)
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

        // GET: ReservationAdd/Delete/5
        public ActionResult RemoveReservation(int id)
        {
            return View();
        }

        // POST: ReservationAdd/Delete/5
        [HttpPost]
        public ActionResult RemoveReservation(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
