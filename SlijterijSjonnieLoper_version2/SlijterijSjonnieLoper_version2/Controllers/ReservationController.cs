using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SlijterijSjonnieLoper_version2.DAL;
using SlijterijSjonnieLoper_version2.Models;
using SlijterijSjonnieLoper_version2.ViewModels;

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
            ViewModels.GenerateReservationViewModel viewModel = new ViewModels.GenerateReservationViewModel();
            viewModel.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
            viewModel.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
            foreach (var item in MockdataService.GetMockdataService().GetAllCustomers().ToList())
            {
                viewModel.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + item.LastName, Value = item.FirstName + item.LastName });
            }
            foreach (var item in MockdataService.GetMockdataService().GetAllWhiskeys().ToList())
            {
                viewModel.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
            }
            return View(viewModel);
        }

        // POST: ReservationAdd/Create
        [HttpPost]
        public ActionResult GenerateNewReservation(GenerateReservationViewModel bestelling)
        {
            try
            {
                // TODO: Add insert logic here
                bestelling.bestellingModel.WhiskeyAndAmount = new Dictionary<WhiskeyModel, int>() { bestelling.StoreChoiceWhiskeyFromDropDownList, "" };
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
