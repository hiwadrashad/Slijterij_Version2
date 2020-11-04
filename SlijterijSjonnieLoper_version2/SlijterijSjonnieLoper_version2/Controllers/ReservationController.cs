using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SlijterijSjonnieLoper_version2.DAL;
using SlijterijSjonnieLoper_version2.Models;

namespace SlijterijSjonnieLoper_version2.Controllers
{
    public class ReservationController : Controller
    {
        // GET: ReservationAdd
        public ActionResult ReservationOverview()
        {
            return View(MockdataService.GetMockdataService().GetAllBestellingen().ToList());

        }

        // GET: ReservationAdd/Details/5
        public ActionResult ReservationData(string id)
        {
            return View(MockdataService.GetMockdataService().GetBestelling(id));
        }

        // GET: ReservationAdd/Create
        public ActionResult GenerateNewReservation()
        {
            return View();
        }

        // POST: ReservationAdd/Create
        [HttpPost]
        public ActionResult GenerateNewReservation(BestellingModel bestelling)
        {
            try
            {
                // TODO: Add insert logic here
                MockdataService.GetMockdataService().AddBestelling(bestelling);
                return RedirectToAction("ReservationOverview");
            }
            catch
            {
                return View();
            }
        }

        // GET: ReservationAdd/Edit/5
        public ActionResult ChangeDataReservation(string id)
        {
            return View(MockdataService.GetMockdataService().GetBestelling(id));

        }

        // POST: ReservationAdd/Edit/5
        [HttpPost]
        public ActionResult ChangeDataReservation(string id, BestellingModel bestelling)
        {
            try
            {
                // TODO: Add update logic here
                MockdataService.GetMockdataService().UpdateBestelling(bestelling);
                return RedirectToAction("ReservationOverview");
            }
            catch
            {
                return View();
            }
        }

        // GET: ReservationAdd/Delete/5
        public ActionResult RemoveReservation(string id)
        {
            return View(MockdataService.GetMockdataService().GetBestelling(id));
        }

        // POST: ReservationAdd/Delete/5
        [HttpPost]
        public ActionResult RemoveReservation(string id, BestellingModel bestelling)
        {
            try
            {
                // TODO: Add delete logic here
                MockdataService.GetMockdataService().DeleteBestelling(bestelling.id);
                return RedirectToAction("ReservationOverview");
            }
            catch
            {
                return View();
            }
        }
    }
}
