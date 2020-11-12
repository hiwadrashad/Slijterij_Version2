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
                viewModel.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
            }
            foreach (var item in MockdataService.GetMockdataService().GetAllWhiskeys().ToList())
            {
               
                viewModel.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
                viewModel.GenerateDropDownDataFromWhiskeyForJavascript.Add(item.Name);
            } 


            return View(viewModel);
        }

        public ActionResult GenerateNewReservationTwoBottles(GenerateReservationViewModel viewModel)
        {
            GenerateReservationTwoBottlesViewModel viewModel2 = new GenerateReservationTwoBottlesViewModel();
            viewModel2.bestellingModel.City = viewModel.bestellingModel.City;
            viewModel2.bestellingModel.CompletedOrder = viewModel.bestellingModel.CompletedOrder;
            viewModel2.bestellingModel.Customer = viewModel.bestellingModel.Customer;
            viewModel2.bestellingModel.DateOfCompletionOrder = viewModel.bestellingModel.DateOfCompletionOrder;
            viewModel2.bestellingModel.DateOfReservation = viewModel.bestellingModel.DateOfReservation;
            viewModel2.bestellingModel.HouseNumberAddition = viewModel.bestellingModel.HouseNumberAddition;
            viewModel2.bestellingModel.PostalCode = viewModel.bestellingModel.PostalCode;
            viewModel2.bestellingModel.StreetName = viewModel.bestellingModel.StreetName;
            viewModel2.bestellingModel.StreetNumber = viewModel.bestellingModel.StreetNumber;
            viewModel2.bestellingModel.WhiskeyAndAmount = viewModel.bestellingModel.WhiskeyAndAmount;
           
            viewModel2.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
            viewModel2.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
            foreach (var item in MockdataService.GetMockdataService().GetAllCustomers().ToList())
            {
                viewModel2.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
            }
            foreach (var item in MockdataService.GetMockdataService().GetAllWhiskeys().ToList())
            {
                viewModel2.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
            }
            
            return View(viewModel2);
        }


        // POST: ReservationAdd/Create
        [HttpPost]
        public ActionResult GenerateNewReservation(GenerateReservationViewModel bestelling, string command)
        {
            try
            {
                if (command == "Create")
                {
                    bestelling.bestellingModel.WhiskeyAndAmount = new Dictionary<WhiskeyModel, int> { { MockdataService.GetMockdataService().GetWhiskeyTroughName(bestelling.StoreChoiceWhiskeyFromDropDownList), bestelling.StoreChoiceAmountOfBottlesWhiskey } };
             
                    //var fullname = bestelling.StoreChoiceCustomerFromDropDownList;
                    //var firstname = fullname.Split(' ')[0];
                    //var lastname = fullname.Split(' ')[1];
                    bestelling.bestellingModel.Customer = MockdataService.GetMockdataService().GetCustomer(bestelling.StoreChoiceCustomerFromDropDownList);
                    MockdataService.GetMockdataService().AddBestelling(bestelling.bestellingModel);
                    // TODO: Add insert logic here
                    // bestelling.bestellingModel.WhiskeyAndAmount = new Dictionary<WhiskeyModel, int>() { MockdataService.GetMockdataService().GetWhiskeyTroughName(bestelling.StoreChoiceWhiskeyFromDropDownList),Int32.Parse( bestelling.StoreChoiceWhiskeyFromDropDownList )};
                    // MockdataService.GetMockdataService().AddBestelling(bestelling);
                    return RedirectToAction("ReservationOverview");
                }
                else
                {
                    return RedirectToAction("GenerateNewReservationTwoBottles",bestelling);
                }
            }
            catch
            {
                return View(bestelling);
            }
        }

        // GET: ReservationAdd/Edit/5
        public ActionResult ChangeDataReservation(string id)
        {
            ChangeDataReservationViewModel changeDataReservationViewModel = new ChangeDataReservationViewModel();
            changeDataReservationViewModel.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
            changeDataReservationViewModel.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();

            foreach (var item in MockdataService.GetMockdataService().GetAllCustomers())
            {
                changeDataReservationViewModel.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
            }
            foreach (var item in MockdataService.GetMockdataService().GetAllWhiskeys())
            {
                changeDataReservationViewModel.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
            }
            changeDataReservationViewModel.bestellingModel = MockdataService.GetMockdataService().GetBestelling(id);
            return View(changeDataReservationViewModel);

        }

        // POST: ReservationAdd/Edit/5
        [HttpPost]
        public ActionResult ChangeDataReservation(string id, ChangeDataReservationViewModel bestelling)
        {
            try
            {
                // TODO: Add update logic here
                bestelling.bestellingModel.WhiskeyAndAmount = new Dictionary<WhiskeyModel, int> { { MockdataService.GetMockdataService().GetWhiskeyTroughName(bestelling.StoreChoiceWhiskeyFromDropDownList), bestelling.StoreChoiceAmountOfBottlesWhiskey } };
                bestelling.bestellingModel.Customer = MockdataService.GetMockdataService().GetCustomer(bestelling.StoreChoiceCustomerFromDropDownList);
                MockdataService.GetMockdataService().UpdateBestelling(bestelling.bestellingModel);
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
