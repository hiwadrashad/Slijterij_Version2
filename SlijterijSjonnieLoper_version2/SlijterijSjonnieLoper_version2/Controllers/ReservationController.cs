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
            viewModel.GenerateDropDownDataFromWhiskeyForJavascript = new List<string>();
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

        public ActionResult GenerateNewReservationTwoBottles()
        {
            GenerateReservationTwoBottlesViewModel viewModel2 = new GenerateReservationTwoBottlesViewModel();          
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


        public ActionResult GenerateNewReservationThreeBottles()
        {
            GeneraterReservationThreeBottlesViewModel viewModel3 = new GeneraterReservationThreeBottlesViewModel();
            viewModel3.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
            viewModel3.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
            foreach (var item in MockdataService.GetMockdataService().GetAllCustomers().ToList())
            {
                viewModel3.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
            }
            foreach (var item in MockdataService.GetMockdataService().GetAllWhiskeys().ToList())
            {
                viewModel3.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
            }

            return View(viewModel3);
        }


        // POST: ReservationAdd/Create
        [HttpPost]
        // extra parameters for if typescript is being implemented for adding new requests
        public ActionResult GenerateNewReservation(GenerateReservationViewModel bestelling, string command,string amountofbottles1, string amountofbottles2,
            string amountofbottles3, string amountofbottles4, string amountofbottles5, string whiskey1, string whiskey2, string whiskey3, string whiskey4, string whiskey5)
        {
            try
            {
                if (command == "Create")
                {
                    //Dictionary<WhiskeyModel, int> DictionaryTostore = new Dictionary<WhiskeyModel, int>();
                    //DictionaryTostore = new Dictionary<WhiskeyModel, int> { { MockdataService.GetMockdataService().GetWhiskeyTroughName(bestelling.StoreChoiceWhiskeyFromDropDownList), bestelling.StoreChoiceAmountOfBottlesWhiskey } };

                    //int temp;
                    //if (amountofbottles1 != null && whiskey1 != null)
                    //{
                    //    if (Int32.TryParse(amountofbottles1, out temp))
                    //    {
                    //        DictionaryTostore.Add(MockdataService.GetMockdataService().GetWhiskeyTroughName(whiskey1),Int32.Parse(amountofbottles1));
                    //    } 

                    //}
                    //if (amountofbottles2 != null && whiskey2 != null)
                    //{
                    //    if (Int32.TryParse(amountofbottles1, out temp))
                    //    {
                    //        DictionaryTostore.Add(MockdataService.GetMockdataService().GetWhiskeyTroughName(whiskey1), Int32.Parse(amountofbottles1));
                    //    }

                    //}
                    //if (amountofbottles3 != null && whiskey3 != null)
                    //{
                    //    if (Int32.TryParse(amountofbottles1, out temp))
                    //    {
                    //        DictionaryTostore.Add(MockdataService.GetMockdataService().GetWhiskeyTroughName(whiskey1), Int32.Parse(amountofbottles1));
                    //    }

                    //}
                    //if (amountofbottles4 != null && whiskey4 != null)
                    //{
                    //    if (Int32.TryParse(amountofbottles1, out temp))
                    //    {
                    //        DictionaryTostore.Add(MockdataService.GetMockdataService().GetWhiskeyTroughName(whiskey1), Int32.Parse(amountofbottles1));
                    //    }

                    //}
                    //if (amountofbottles5 != null && whiskey5 != null)
                    //{
                    //    if (Int32.TryParse(amountofbottles1, out temp))
                    //    {
                    //        DictionaryTostore.Add(MockdataService.GetMockdataService().GetWhiskeyTroughName(whiskey1), Int32.Parse(amountofbottles1));
                    //    }

                    //}

                    //bestelling.bestellingModel.WhiskeyAndAmount = DictionaryTostore;
                    //var fullname = bestelling.StoreChoiceCustomerFromDropDownList;
                    //var firstname = fullname.Split(' ')[0];
                    //var lastname = fullname.Split(' ')[1];
                    bestelling.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
                    bestelling.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
                    foreach (var item in MockdataService.GetMockdataService().GetAllCustomers().ToList())
                    {
                        bestelling.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
                    }
                    foreach (var item in MockdataService.GetMockdataService().GetAllWhiskeys().ToList())
                    {
                        bestelling.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
                    }

                    bestelling.bestellingModel.WhiskeyAndAmount = new Dictionary<WhiskeyModel, int> { { MockdataService.GetMockdataService().GetWhiskeyTroughName(bestelling.StoreChoiceWhiskeyFromDropDownList), bestelling.StoreChoiceAmountOfBottlesWhiskey } };
                    bestelling.bestellingModel.Customer = MockdataService.GetMockdataService().GetCustomer(bestelling.StoreChoiceCustomerFromDropDownList);
                    MockdataService.GetMockdataService().AddBestelling(bestelling.bestellingModel);
                    // TODO: Add insert logic here
                    // bestelling.bestellingModel.WhiskeyAndAmount = new Dictionary<WhiskeyModel, int>() { MockdataService.GetMockdataService().GetWhiskeyTroughName(bestelling.StoreChoiceWhiskeyFromDropDownList),Int32.Parse( bestelling.StoreChoiceWhiskeyFromDropDownList )};
                    // MockdataService.GetMockdataService().AddBestelling(bestelling);
                    return RedirectToAction("ReservationOverview");
                }
                else if (command == "Create another one")
                {
                    bestelling.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
                    bestelling.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
                    foreach (var item in MockdataService.GetMockdataService().GetAllCustomers().ToList())
                    {
                        bestelling.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
                    }
                    foreach (var item in MockdataService.GetMockdataService().GetAllWhiskeys().ToList())
                    {
                        bestelling.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
                    }
                    return RedirectToAction("GenerateNewReservationTwoBottles");
                }
                else
                {
                    bestelling.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
                    bestelling.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
                    foreach (var item in MockdataService.GetMockdataService().GetAllCustomers().ToList())
                    {
                        bestelling.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
                    }
                    foreach (var item in MockdataService.GetMockdataService().GetAllWhiskeys().ToList())
                    {
                        bestelling.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
                    }
                    return View();
                }
            }
            catch
            {
                bestelling.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
                bestelling.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
                foreach (var item in MockdataService.GetMockdataService().GetAllCustomers().ToList())
                {
                    bestelling.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
                }
                foreach (var item in MockdataService.GetMockdataService().GetAllWhiskeys().ToList())
                {
                    bestelling.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
                }
                return View();
            }
        }


        [HttpPost]
        public ActionResult GenerateNewReservationTwoBottles(GenerateReservationTwoBottlesViewModel bestelling, string command)
        {
            try
            {
                if (command == "Create")
                {
                    bestelling.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
                    bestelling.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
                    foreach (var item in MockdataService.GetMockdataService().GetAllCustomers().ToList())
                    {
                        bestelling.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
                    }
                    foreach (var item in MockdataService.GetMockdataService().GetAllWhiskeys().ToList())
                    {
                        bestelling.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
                    }
                    bestelling.bestellingModel.WhiskeyAndAmount = new Dictionary<WhiskeyModel, int> { { MockdataService.GetMockdataService().GetWhiskeyTroughName(bestelling.StoreChoiceWhiskeyFromDropDownList), bestelling.StoreChoiceAmountOfBottlesWhiskey }, { MockdataService.GetMockdataService().GetWhiskeyTroughName(bestelling.StoreChoiceWhiskeyFromDropDownList2), bestelling.StoreChoiceAmountOfBottlesWhiskey2 } };

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
                else if (command == "Create another one")
                {
                    bestelling.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
                    bestelling.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
                    foreach (var item in MockdataService.GetMockdataService().GetAllCustomers().ToList())
                    {
                        bestelling.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
                    }
                    foreach (var item in MockdataService.GetMockdataService().GetAllWhiskeys().ToList())
                    {
                        bestelling.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
                    }
                    return RedirectToAction("GenerateNewReservationThreeBottles");
                }
                else
                {
                    bestelling.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
                    bestelling.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
                    foreach (var item in MockdataService.GetMockdataService().GetAllCustomers().ToList())
                    {
                        bestelling.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
                    }
                    foreach (var item in MockdataService.GetMockdataService().GetAllWhiskeys().ToList())
                    {
                        bestelling.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
                    }
                    return View();
                }
            }
            catch
            {
                bestelling.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
                bestelling.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
                foreach (var item in MockdataService.GetMockdataService().GetAllCustomers().ToList())
                {
                    bestelling.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
                }
                foreach (var item in MockdataService.GetMockdataService().GetAllWhiskeys().ToList())
                {
                    bestelling.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
                }
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
