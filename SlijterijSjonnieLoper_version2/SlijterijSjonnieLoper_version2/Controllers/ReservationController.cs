using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using SlijterijSjonnieLoper_version2.DAL;
using SlijterijSjonnieLoper_version2.Extensions;
using SlijterijSjonnieLoper_version2.Models;
using SlijterijSjonnieLoper_version2.ViewModels;

namespace SlijterijSjonnieLoper_version2.Controllers
{
    public class ReservationController : Controller
    {
        // GET: ReservationAdd


        private IDataService _dataService = MockdataService.GetMockdataService();
        //private IDataService _dataService = ApplicationDataService.GetService();

        [Authorize]

        public ActionResult ReservationOverview()
        {
            return View(_dataService.GetAllBestellingen().ToList());

        }

        [Authorize]

        // GET: ReservationAdd/Details/5
        public ActionResult ReservationData(string id)
        {
            return View(_dataService.GetBestelling(id));
        }

        // GET: ReservationAdd/Create
        [Authorize]

        public ActionResult GenerateNewReservation()
        {
            ViewModels.GenerateReservationViewModel viewModel = new ViewModels.GenerateReservationViewModel();
            viewModel.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
            viewModel.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
            viewModel.GenerateDropDownDataFromWhiskeyForJavascript = new List<string>();
            foreach (var item in _dataService.GetAllCustomers().ToList())
            {
                viewModel.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
            }
            foreach (var item in _dataService.GetAllWhiskeys().ToList())
            {
               
                viewModel.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
                viewModel.GenerateDropDownDataFromWhiskeyForJavascript.Add(item.Name);
            } 


            return View(viewModel);
        }

        [Authorize]

        public ActionResult GenerateNewReservationTwoBottles()
        {
            GenerateReservationTwoBottlesViewModel viewModel2 = new GenerateReservationTwoBottlesViewModel();          
            viewModel2.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
            viewModel2.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
            foreach (var item in _dataService.GetAllCustomers().ToList())
            {
                viewModel2.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
            }
            foreach (var item in _dataService.GetAllWhiskeys().ToList())
            {
                viewModel2.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
            }
            
            return View(viewModel2);
        }

        [Authorize]

        public ActionResult GenerateNewReservationThreeBottles()
        {
            GeneraterReservationThreeBottlesViewModel viewModel3 = new GeneraterReservationThreeBottlesViewModel();
            viewModel3.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
            viewModel3.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
            foreach (var item in _dataService.GetAllCustomers().ToList())
            {
                viewModel3.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
            }
            foreach (var item in _dataService.GetAllWhiskeys().ToList())
            {
                viewModel3.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
            }

            return View(viewModel3);
        }

        [Authorize]

        public ActionResult GenerateNewReservationFourBottles()
        {
            GenerateReservationFourBottlesViewModel viewModel4 = new GenerateReservationFourBottlesViewModel();
            viewModel4.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
            viewModel4.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
            foreach (var item in _dataService.GetAllCustomers().ToList())
            {
                viewModel4.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
            }
            foreach (var item in _dataService.GetAllWhiskeys().ToList())
            {
                viewModel4.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
            }

            return View(viewModel4);
        }

        [Authorize]

        public ActionResult GenerateNewReservationFiveBottles()
        {
            GenerateReservationFiveBottlesViewModel viewModel5 = new  GenerateReservationFiveBottlesViewModel();
            viewModel5.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
            viewModel5.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
            foreach (var item in _dataService.GetAllCustomers().ToList())
            {
                viewModel5.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
            }
            foreach (var item in _dataService.GetAllWhiskeys().ToList())
            {
                viewModel5.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
            }

            return View(viewModel5);
        }

        // POST: ReservationAdd/Create
        [Authorize]
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
                    //DictionaryTostore = new Dictionary<WhiskeyModel, int> { { _dataService.GetWhiskeyTroughName(bestelling.StoreChoiceWhiskeyFromDropDownList), bestelling.StoreChoiceAmountOfBottlesWhiskey } };

                    //int temp;
                    //if (amountofbottles1 != null && whiskey1 != null)
                    //{
                    //    if (Int32.TryParse(amountofbottles1, out temp))
                    //    {
                    //        DictionaryTostore.Add(_dataService.GetWhiskeyTroughName(whiskey1),Int32.Parse(amountofbottles1));
                    //    } 

                    //}
                    //if (amountofbottles2 != null && whiskey2 != null)
                    //{
                    //    if (Int32.TryParse(amountofbottles1, out temp))
                    //    {
                    //        DictionaryTostore.Add(_dataService.GetWhiskeyTroughName(whiskey1), Int32.Parse(amountofbottles1));
                    //    }

                    //}
                    //if (amountofbottles3 != null && whiskey3 != null)
                    //{
                    //    if (Int32.TryParse(amountofbottles1, out temp))
                    //    {
                    //        DictionaryTostore.Add(_dataService.GetWhiskeyTroughName(whiskey1), Int32.Parse(amountofbottles1));
                    //    }

                    //}
                    //if (amountofbottles4 != null && whiskey4 != null)
                    //{
                    //    if (Int32.TryParse(amountofbottles1, out temp))
                    //    {
                    //        DictionaryTostore.Add(_dataService.GetWhiskeyTroughName(whiskey1), Int32.Parse(amountofbottles1));
                    //    }

                    //}
                    //if (amountofbottles5 != null && whiskey5 != null)
                    //{
                    //    if (Int32.TryParse(amountofbottles1, out temp))
                    //    {
                    //        DictionaryTostore.Add(_dataService.GetWhiskeyTroughName(whiskey1), Int32.Parse(amountofbottles1));
                    //    }

                    //}

                    //bestelling.bestellingModel.WhiskeyAndAmount = DictionaryTostore;
                    //var fullname = bestelling.StoreChoiceCustomerFromDropDownList;
                    //var firstname = fullname.Split(' ')[0];
                    //var lastname = fullname.Split(' ')[1];
                    bestelling.bestellingModel.DateOfReservation = DateTime.Now;
                    bestelling.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
                    bestelling.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
                    foreach (var item in _dataService.GetAllCustomers().ToList())
                    {
                        bestelling.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
                    }
                    foreach (var item in _dataService.GetAllWhiskeys().ToList())
                    {
                        bestelling.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
                    }
                    bestelling.bestellingModel.id = Guid.NewGuid().ToString();
                    bestelling.bestellingModel.WhiskeyAndAmount = new Dictionary<WhiskeyModel, int> { { _dataService.GetWhiskeyTroughName(bestelling.StoreChoiceWhiskeyFromDropDownList), bestelling.StoreChoiceAmountOfBottlesWhiskey } };
                    bestelling.bestellingModel.Customer = _dataService.GetCustomer(bestelling.StoreChoiceCustomerFromDropDownList);
                    _dataService.AddBestelling(bestelling.bestellingModel);
                    // TODO: Add insert logic here
                    // bestelling.bestellingModel.WhiskeyAndAmount = new Dictionary<WhiskeyModel, int>() { _dataService.GetWhiskeyTroughName(bestelling.StoreChoiceWhiskeyFromDropDownList),Int32.Parse( bestelling.StoreChoiceWhiskeyFromDropDownList )};
                    // _dataService.AddBestelling(bestelling);
                    return RedirectToAction("ReservationOverview");
                }
                else
                {
                    bestelling.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
                    bestelling.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
                    foreach (var item in _dataService.GetAllCustomers().ToList())
                    {
                        bestelling.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
                    }
                    foreach (var item in _dataService.GetAllWhiskeys().ToList())
                    {
                        bestelling.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
                    }
                    return RedirectToAction("GenerateNewReservationTwoBottles");
                }

            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (NullReferenceException ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                bestelling.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
                bestelling.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
                foreach (var item in _dataService.GetAllCustomers().ToList())
                {
                    bestelling.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
                }
                foreach (var item in _dataService.GetAllWhiskeys().ToList())
                {
                    bestelling.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
                }
                this.AddNotification("All values should be filled in", NotificationType.ERROR);
                return View(bestelling);
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (ArgumentNullException ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                bestelling.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
                bestelling.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
                foreach (var item in _dataService.GetAllCustomers().ToList())
                {
                    bestelling.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
                }
                foreach (var item in _dataService.GetAllWhiskeys().ToList())
                {
                    bestelling.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
                }
                this.AddNotification("All values should be filled in", NotificationType.ERROR);
                return View(bestelling);
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                bestelling.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
                bestelling.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
                foreach (var item in _dataService.GetAllCustomers().ToList())
                {
                    bestelling.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
                }
                foreach (var item in _dataService.GetAllWhiskeys().ToList())
                {
                    bestelling.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
                }
                this.AddNotification("An error occured", NotificationType.ERROR);
                return View(bestelling);
            }
        }

        [Authorize]
        [HttpPost]
        public ActionResult GenerateNewReservationTwoBottles(GenerateReservationTwoBottlesViewModel bestelling, string command)
        {
            if (command == "Create")
            {
                try
                {
                    bestelling.bestellingModel.DateOfReservation = DateTime.Now;
                    bestelling.bestellingModel.id = Guid.NewGuid().ToString();
                    bestelling.bestellingModel.WhiskeyAndAmount = new Dictionary<WhiskeyModel, int> { { _dataService.GetWhiskeyTroughName(bestelling.StoreChoiceWhiskeyFromDropDownList), bestelling.StoreChoiceAmountOfBottlesWhiskey }, { _dataService.GetWhiskeyTroughName(bestelling.StoreChoiceWhiskeyFromDropDownList2), bestelling.StoreChoiceAmountOfBottlesWhiskey2 } };
                    bestelling.bestellingModel.Customer = _dataService.GetCustomer(bestelling.StoreChoiceCustomerFromDropDownList);
                    _dataService.AddBestelling(bestelling.bestellingModel);
                    return RedirectToAction("ReservationOverview");
                }
#pragma warning disable CS0168 // Variable is declared but never used
                catch (ArgumentException ex)
#pragma warning restore CS0168 // Variable is declared but never used
                {
                    bestelling.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
                    bestelling.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
                    foreach (var item in _dataService.GetAllCustomers().ToList())
                    {
                        bestelling.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
                    }
                    foreach (var item in _dataService.GetAllWhiskeys().ToList())
                    {
                        bestelling.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
                    }
                    this.AddNotification("You can't add duplicate whiskey's", NotificationType.ERROR);
                    return View(bestelling);
                }
#pragma warning disable CS0168 // Variable is declared but never used
                catch (NullReferenceException ex)
#pragma warning restore CS0168 // Variable is declared but never used
                {
                    bestelling.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
                    bestelling.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
                    foreach (var item in _dataService.GetAllCustomers().ToList())
                    {
                        bestelling.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
                    }
                    foreach (var item in _dataService.GetAllWhiskeys().ToList())
                    {
                        bestelling.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
                    }
                    this.AddNotification("All values should be filled in", NotificationType.ERROR);
                    return View(bestelling);
                }

#pragma warning disable CS0168 // Variable is declared but never used
                catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
                {
                    bestelling.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
                    bestelling.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
                    foreach (var item in _dataService.GetAllCustomers().ToList())
                    {
                        bestelling.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
                    }
                    foreach (var item in _dataService.GetAllWhiskeys().ToList())
                    {
                        bestelling.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
                    }
                    this.AddNotification("There was an error", NotificationType.ERROR);
                    return View(bestelling);
                }
            }
            else
            {
                try
                {
                    return RedirectToAction("GenerateNewReservationThreeBottles");
                }
#pragma warning disable CS0168 // Variable is declared but never used
                catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
                {

                    bestelling.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
                    bestelling.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
                    foreach (var item in _dataService.GetAllCustomers().ToList())
                    {
                        bestelling.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
                    }
                    foreach (var item in _dataService.GetAllWhiskeys().ToList())
                    {
                        bestelling.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
                    }
                    this.AddNotification("There was an error", NotificationType.ERROR);
                    return View(bestelling);
                }
            }
            //try
            //{
            //    if (command == "Create")
            //    {
            //        //Dictionary<WhiskeyModel, int> DictionaryTostore = new Dictionary<WhiskeyModel, int>();
            //        //DictionaryTostore = new Dictionary<WhiskeyModel, int> { { _dataService.GetWhiskeyTroughName(bestelling.StoreChoiceWhiskeyFromDropDownList), bestelling.StoreChoiceAmountOfBottlesWhiskey } };

            //        //int temp;
            //        //if (amountofbottles1 != null && whiskey1 != null)
            //        //{
            //        //    if (Int32.TryParse(amountofbottles1, out temp))
            //        //    {
            //        //        DictionaryTostore.Add(_dataService.GetWhiskeyTroughName(whiskey1),Int32.Parse(amountofbottles1));
            //        //    } 

            //        //}
            //        //if (amountofbottles2 != null && whiskey2 != null)
            //        //{
            //        //    if (Int32.TryParse(amountofbottles1, out temp))
            //        //    {
            //        //        DictionaryTostore.Add(_dataService.GetWhiskeyTroughName(whiskey1), Int32.Parse(amountofbottles1));
            //        //    }

            //        //}
            //        //if (amountofbottles3 != null && whiskey3 != null)
            //        //{
            //        //    if (Int32.TryParse(amountofbottles1, out temp))
            //        //    {
            //        //        DictionaryTostore.Add(_dataService.GetWhiskeyTroughName(whiskey1), Int32.Parse(amountofbottles1));
            //        //    }

            //        //}
            //        //if (amountofbottles4 != null && whiskey4 != null)
            //        //{
            //        //    if (Int32.TryParse(amountofbottles1, out temp))
            //        //    {
            //        //        DictionaryTostore.Add(_dataService.GetWhiskeyTroughName(whiskey1), Int32.Parse(amountofbottles1));
            //        //    }

            //        //}
            //        //if (amountofbottles5 != null && whiskey5 != null)
            //        //{
            //        //    if (Int32.TryParse(amountofbottles1, out temp))
            //        //    {
            //        //        DictionaryTostore.Add(_dataService.GetWhiskeyTroughName(whiskey1), Int32.Parse(amountofbottles1));
            //        //    }

            //        //}

            //        //bestelling.bestellingModel.WhiskeyAndAmount = DictionaryTostore;
            //        //var fullname = bestelling.StoreChoiceCustomerFromDropDownList;
            //        //var firstname = fullname.Split(' ')[0];
            //        //var lastname = fullname.Split(' ')[1];
            //        bestelling.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
            //        bestelling.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
            //        foreach (var item in _dataService.GetAllCustomers().ToList())
            //        {
            //            bestelling.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
            //        }
            //        foreach (var item in _dataService.GetAllWhiskeys().ToList())
            //        {
            //            bestelling.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
            //        }

            //        bestelling.bestellingModel.WhiskeyAndAmount = new Dictionary<WhiskeyModel, int> { { _dataService.GetWhiskeyTroughName(bestelling.StoreChoiceWhiskeyFromDropDownList), bestelling.StoreChoiceAmountOfBottlesWhiskey }, { _dataService.GetWhiskeyTroughName(bestelling.StoreChoiceWhiskeyFromDropDownList2), bestelling.StoreChoiceAmountOfBottlesWhiskey2 } };
            //        bestelling.bestellingModel.Customer = _dataService.GetCustomer(bestelling.StoreChoiceCustomerFromDropDownList);
            //        _dataService.AddBestelling(bestelling.bestellingModel);
            //        // TODO: Add insert logic here
            //        // bestelling.bestellingModel.WhiskeyAndAmount = new Dictionary<WhiskeyModel, int>() { _dataService.GetWhiskeyTroughName(bestelling.StoreChoiceWhiskeyFromDropDownList),Int32.Parse( bestelling.StoreChoiceWhiskeyFromDropDownList )};
            //        // _dataService.AddBestelling(bestelling);
            //        return RedirectToAction("ReservationOverview");
            //    }
            //    else if (command == "Create another one")
            //    {
            //        bestelling.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
            //        bestelling.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
            //        foreach (var item in _dataService.GetAllCustomers().ToList())
            //        {
            //            bestelling.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
            //        }
            //        foreach (var item in _dataService.GetAllWhiskeys().ToList())
            //        {
            //            bestelling.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
            //        }
            //        return RedirectToAction("GenerateNewReservationThreeBottles");
            //    }
            //    else
            //    {
            //        bestelling.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
            //        bestelling.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
            //        foreach (var item in _dataService.GetAllCustomers().ToList())
            //        {
            //            bestelling.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
            //        }
            //        foreach (var item in _dataService.GetAllWhiskeys().ToList())
            //        {
            //            bestelling.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
            //        }
            //        return View();
            //    }
            //}
            //catch
            //{
            //    bestelling.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
            //    bestelling.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
            //    foreach (var item in _dataService.GetAllCustomers().ToList())
            //    {
            //        bestelling.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
            //    }
            //    foreach (var item in _dataService.GetAllWhiskeys().ToList())
            //    {
            //        bestelling.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
            //    }
            //    return View();
            //}


            ////try
            ////{
            ////    if (command == "Create")
            ////    {
            ////        bestelling.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
            ////        bestelling.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
            ////        foreach (var item in _dataService.GetAllCustomers().ToList())
            ////        {
            ////            bestelling.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
            ////        }
            ////        foreach (var item in _dataService.GetAllWhiskeys().ToList())
            ////        {
            ////            bestelling.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
            ////        }
            ////        bestelling.bestellingModel.WhiskeyAndAmount = new Dictionary<WhiskeyModel, int> { { _dataService.GetWhiskeyTroughName(bestelling.StoreChoiceWhiskeyFromDropDownList), bestelling.StoreChoiceAmountOfBottlesWhiskey }, { _dataService.GetWhiskeyTroughName(bestelling.StoreChoiceWhiskeyFromDropDownList2), bestelling.StoreChoiceAmountOfBottlesWhiskey2 } };

            ////        //var fullname = bestelling.StoreChoiceCustomerFromDropDownList;
            ////        //var firstname = fullname.Split(' ')[0];
            ////        //var lastname = fullname.Split(' ')[1];
            ////        bestelling.bestellingModel.Customer = _dataService.GetCustomer(bestelling.StoreChoiceCustomerFromDropDownList);
            ////        _dataService.AddBestelling(bestelling.bestellingModel);
            ////        // TODO: Add insert logic here
            ////        // bestelling.bestellingModel.WhiskeyAndAmount = new Dictionary<WhiskeyModel, int>() { _dataService.GetWhiskeyTroughName(bestelling.StoreChoiceWhiskeyFromDropDownList),Int32.Parse( bestelling.StoreChoiceWhiskeyFromDropDownList )};
            ////        // _dataService.AddBestelling(bestelling);
            ////        return RedirectToAction("ReservationOverview");
            ////    }
            ////    else if (command == "Create another one")
            ////    {
            ////        bestelling.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
            ////        bestelling.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
            ////        foreach (var item in _dataService.GetAllCustomers().ToList())
            ////        {
            ////            bestelling.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
            ////        }
            ////        foreach (var item in _dataService.GetAllWhiskeys().ToList())
            ////        {
            ////            bestelling.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
            ////        }
            ////        return RedirectToAction("GenerateNewReservationThreeBottles", bestelling);
            ////    }
            ////    else
            ////    {
            ////        bestelling.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
            ////        bestelling.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
            ////        foreach (var item in _dataService.GetAllCustomers().ToList())
            ////        {
            ////            bestelling.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
            ////        }
            ////        foreach (var item in _dataService.GetAllWhiskeys().ToList())
            ////        {
            ////            bestelling.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
            ////        }
            ////        return View();
            ////    }
            ////}
            ////catch
            ////{
            ////    bestelling.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
            ////    bestelling.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
            ////    foreach (var item in _dataService.GetAllCustomers().ToList())
            ////    {
            ////        bestelling.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
            ////    }
            ////    foreach (var item in _dataService.GetAllWhiskeys().ToList())
            ////    {
            ////        bestelling.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
            ////    }
            ////    return View();
            ////}
        }

        [Authorize]
        [HttpPost]
        public ActionResult GenerateNewReservationThreeBottles(GeneraterReservationThreeBottlesViewModel bestelling, string command)
        {
            if (command == "Create")
            {
                try
                {
                    bestelling.bestellingModel.DateOfReservation = DateTime.Now;
                    bestelling.bestellingModel.WhiskeyAndAmount = new Dictionary<WhiskeyModel, int> { { _dataService.GetWhiskeyTroughName(bestelling.StoreChoiceWhiskeyFromDropDownList), bestelling.StoreChoiceAmountOfBottlesWhiskey },
                    { _dataService.GetWhiskeyTroughName(bestelling.StoreChoiceWhiskeyFromDropDownList2), bestelling.StoreChoiceAmountOfBottlesWhiskey2 },
                    { _dataService.GetWhiskeyTroughName(bestelling.StoreChoiceWhiskeyFromDropDownList3), bestelling.StoreChoiceAmountOfBottlesWhiskey3} };
                    bestelling.bestellingModel.Customer = _dataService.GetCustomer(bestelling.StoreChoiceCustomerFromDropDownList);
                    bestelling.bestellingModel.id = Guid.NewGuid().ToString();
                    _dataService.AddBestelling(bestelling.bestellingModel);
                    return RedirectToAction("ReservationOverview");
                }
#pragma warning disable CS0168 // Variable is declared but never used
                catch (ArgumentException ex)
#pragma warning restore CS0168 // Variable is declared but never used
                {
                    bestelling.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
                    bestelling.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
                    foreach (var item in _dataService.GetAllCustomers().ToList())
                    {
                        bestelling.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
                    }
                    foreach (var item in _dataService.GetAllWhiskeys().ToList())
                    {
                        bestelling.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
                    }
                    this.AddNotification("You can't add duplicate whiskey's", NotificationType.ERROR);
                    return View(bestelling);
                }
#pragma warning disable CS0168 // Variable is declared but never used
                catch (NullReferenceException ex)
#pragma warning restore CS0168 // Variable is declared but never used
                {
                    bestelling.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
                    bestelling.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
                    foreach (var item in _dataService.GetAllCustomers().ToList())
                    {
                        bestelling.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
                    }
                    foreach (var item in _dataService.GetAllWhiskeys().ToList())
                    {
                        bestelling.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
                    }
                    this.AddNotification("All values should be filled in", NotificationType.ERROR);
                    return View(bestelling);
                }

#pragma warning disable CS0168 // Variable is declared but never used
                catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
                {
                    bestelling.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
                    bestelling.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
                    foreach (var item in _dataService.GetAllCustomers().ToList())
                    {
                        bestelling.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
                    }
                    foreach (var item in _dataService.GetAllWhiskeys().ToList())
                    {
                        bestelling.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
                    }
                    this.AddNotification("There was an error", NotificationType.ERROR);
                    return View(bestelling);
                }
            }
            else
            {
                try
                {
                    return RedirectToAction("GenerateNewReservationFourBottles");
                }
#pragma warning disable CS0168 // Variable is declared but never used
                catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
                {

                    bestelling.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
                    bestelling.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
                    foreach (var item in _dataService.GetAllCustomers().ToList())
                    {
                        bestelling.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
                    }
                    foreach (var item in _dataService.GetAllWhiskeys().ToList())
                    {
                        bestelling.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
                    }
                    this.AddNotification("There was an error", NotificationType.ERROR);
                    return View(bestelling);
                }
            }
      
        }

        [Authorize]
        [HttpPost]
        public ActionResult GenerateNewReservationFourBottles(GenerateReservationFourBottlesViewModel bestelling, string command)
        {
            if (command == "Create")
            {
                try
                {
                    bestelling.bestellingModel.DateOfReservation = DateTime.Now;
                    bestelling.bestellingModel.WhiskeyAndAmount = new Dictionary<WhiskeyModel, int> { { _dataService.GetWhiskeyTroughName(bestelling.StoreChoiceWhiskeyFromDropDownList), bestelling.StoreChoiceAmountOfBottlesWhiskey },
                    { _dataService.GetWhiskeyTroughName(bestelling.StoreChoiceWhiskeyFromDropDownList2), bestelling.StoreChoiceAmountOfBottlesWhiskey2 },
                    { _dataService.GetWhiskeyTroughName(bestelling.StoreChoiceWhiskeyFromDropDownList3), bestelling.StoreChoiceAmountOfBottlesWhiskey3} ,
                    { _dataService.GetWhiskeyTroughName(bestelling.StoreChoiceWhiskeyFromDropDownList4), bestelling.StoreChoiceAmountOfBottlesWhiskey4} };
                    bestelling.bestellingModel.id = Guid.NewGuid().ToString();
                    bestelling.bestellingModel.Customer = _dataService.GetCustomer(bestelling.StoreChoiceCustomerFromDropDownList);
                    _dataService.AddBestelling(bestelling.bestellingModel);
                    return RedirectToAction("ReservationOverview");
                }
#pragma warning disable CS0168 // Variable is declared but never used
                catch (ArgumentException ex)
#pragma warning restore CS0168 // Variable is declared but never used
                {
                    bestelling.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
                    bestelling.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
                    foreach (var item in _dataService.GetAllCustomers().ToList())
                    {
                        bestelling.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
                    }
                    foreach (var item in _dataService.GetAllWhiskeys().ToList())
                    {
                        bestelling.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
                    }
                    this.AddNotification("You can't add duplicate whiskey's", NotificationType.ERROR);
                    return View(bestelling);
                }
#pragma warning disable CS0168 // Variable is declared but never used
                catch (NullReferenceException ex)
#pragma warning restore CS0168 // Variable is declared but never used
                {
                    bestelling.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
                    bestelling.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
                    foreach (var item in _dataService.GetAllCustomers().ToList())
                    {
                        bestelling.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
                    }
                    foreach (var item in _dataService.GetAllWhiskeys().ToList())
                    {
                        bestelling.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
                    }
                    this.AddNotification("All values should be filled in", NotificationType.ERROR);
                    return View(bestelling);
                }

#pragma warning disable CS0168 // Variable is declared but never used
                catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
                {
                    bestelling.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
                    bestelling.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
                    foreach (var item in _dataService.GetAllCustomers().ToList())
                    {
                        bestelling.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
                    }
                    foreach (var item in _dataService.GetAllWhiskeys().ToList())
                    {
                        bestelling.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
                    }
                    this.AddNotification("There was an error", NotificationType.ERROR);
                    return View(bestelling);
                }
            }
            else
            {
                try
                {
                    return RedirectToAction("GenerateNewReservationFiveBottles");
                }
#pragma warning disable CS0168 // Variable is declared but never used
                catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
                {

                    bestelling.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
                    bestelling.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
                    foreach (var item in _dataService.GetAllCustomers().ToList())
                    {
                        bestelling.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
                    }
                    foreach (var item in _dataService.GetAllWhiskeys().ToList())
                    {
                        bestelling.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
                    }
                    this.AddNotification("There was an error", NotificationType.ERROR);
                    return View(bestelling);
                }
            }
        }

        [Authorize]
        [HttpPost]
        public ActionResult GenerateNewReservationFiveBottles(GenerateReservationFiveBottlesViewModel bestelling, string command)
        {
            if (command == "Create")
            {
                try
                {
                    bestelling.bestellingModel.DateOfReservation = DateTime.Now;
                    bestelling.bestellingModel.WhiskeyAndAmount = new Dictionary<WhiskeyModel, int> { { _dataService.GetWhiskeyTroughName(bestelling.StoreChoiceWhiskeyFromDropDownList), bestelling.StoreChoiceAmountOfBottlesWhiskey },
                    { _dataService.GetWhiskeyTroughName(bestelling.StoreChoiceWhiskeyFromDropDownList2), bestelling.StoreChoiceAmountOfBottlesWhiskey2 },
                    { _dataService.GetWhiskeyTroughName(bestelling.StoreChoiceWhiskeyFromDropDownList3), bestelling.StoreChoiceAmountOfBottlesWhiskey3} ,
                    { _dataService.GetWhiskeyTroughName(bestelling.StoreChoiceWhiskeyFromDropDownList4), bestelling.StoreChoiceAmountOfBottlesWhiskey4},
                    { _dataService.GetWhiskeyTroughName(bestelling.StoreChoiceWhiskeyFromDropDownList5), bestelling.StoreChoiceAmountOfBottlesWhiskey5 } };
                    bestelling.bestellingModel.Customer = _dataService.GetCustomer(bestelling.StoreChoiceCustomerFromDropDownList);
                    bestelling.bestellingModel.id = Guid.NewGuid().ToString();
                    _dataService.AddBestelling(bestelling.bestellingModel);
                    return RedirectToAction("ReservationOverview");
                }
#pragma warning disable CS0168 // Variable is declared but never used
                catch (ArgumentException ex)
#pragma warning restore CS0168 // Variable is declared but never used
                {
                    bestelling.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
                    bestelling.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
                    foreach (var item in _dataService.GetAllCustomers().ToList())
                    {
                        bestelling.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
                    }
                    foreach (var item in _dataService.GetAllWhiskeys().ToList())
                    {
                        bestelling.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
                    }
                    this.AddNotification("You can't add duplicate whiskey's", NotificationType.ERROR);
                    return View(bestelling);
                }
#pragma warning disable CS0168 // Variable is declared but never used
                catch (NullReferenceException ex)
#pragma warning restore CS0168 // Variable is declared but never used
                {
                    bestelling.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
                    bestelling.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
                    foreach (var item in _dataService.GetAllCustomers().ToList())
                    {
                        bestelling.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
                    }
                    foreach (var item in _dataService.GetAllWhiskeys().ToList())
                    {
                        bestelling.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
                    }
                    this.AddNotification("All values should be filled in", NotificationType.ERROR);
                    return View(bestelling);
                }

#pragma warning disable CS0168 // Variable is declared but never used
                catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
                {
                    bestelling.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
                    bestelling.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
                    foreach (var item in _dataService.GetAllCustomers().ToList())
                    {
                        bestelling.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
                    }
                    foreach (var item in _dataService.GetAllWhiskeys().ToList())
                    {
                        bestelling.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
                    }
                    this.AddNotification("There was an error", NotificationType.ERROR);
                    return View(bestelling);
                }
            }
            else
            {
                try
                {
                    bestelling.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
                    bestelling.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
                    foreach (var item in _dataService.GetAllCustomers().ToList())
                    {
                        bestelling.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
                    }
                    foreach (var item in _dataService.GetAllWhiskeys().ToList())
                    {
                        bestelling.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
                    }
                    this.AddNotification("You can't add more than five bottles", NotificationType.WARNING);
                    return View(bestelling);
                }
#pragma warning disable CS0168 // Variable is declared but never used
                catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
                {

                    bestelling.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
                    bestelling.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
                    foreach (var item in _dataService.GetAllCustomers().ToList())
                    {
                        bestelling.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
                    }
                    foreach (var item in _dataService.GetAllWhiskeys().ToList())
                    {
                        bestelling.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
                    }
                    this.AddNotification("There was an error", NotificationType.ERROR);
                    return View(bestelling);
                }
            }
        }

        // GET: ReservationAdd/Edit/5
        [Authorize]

        public ActionResult ChangeDataReservation(string id)
        {
            if (_dataService.GetBestelling(id).WhiskeyAndAmount.Count <= 1)
            {
                ChangeDataReservationViewModel changeDataReservationViewModel = new ChangeDataReservationViewModel();
                changeDataReservationViewModel.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
                changeDataReservationViewModel.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();

                foreach (var item in _dataService.GetAllCustomers())
                {
                    changeDataReservationViewModel.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
                }
                foreach (var item in _dataService.GetAllWhiskeys())
                {
                    changeDataReservationViewModel.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
                }
                changeDataReservationViewModel.bestellingModel = _dataService.GetBestelling(id);
                return View(changeDataReservationViewModel);
            }
            if (_dataService.GetBestelling(id).WhiskeyAndAmount.Count == 2)
            {
                ChangeDataReservationViewModelTwoBottlesViewModel changeDataReservationViewModel2 = new  ChangeDataReservationViewModelTwoBottlesViewModel();
                changeDataReservationViewModel2.bestellingModel = _dataService.GetBestelling(id);
                TempData["datachange2"] = changeDataReservationViewModel2;
                return RedirectToAction("ChangeDataReservationTwoBottles");
            }
            if (_dataService.GetBestelling(id).WhiskeyAndAmount.Count == 3)
            {
                ChangeDataReservationViewModelThreeBottlesViewModel changeDataReservationViewModel3 = new ChangeDataReservationViewModelThreeBottlesViewModel();
                changeDataReservationViewModel3.bestellingModel = _dataService.GetBestelling(id);
                TempData["datachange3"] = changeDataReservationViewModel3;
                return RedirectToAction("ChangeDataReservationThreeBottles");
            }
            if (_dataService.GetBestelling(id).WhiskeyAndAmount.Count == 4)
            {
                ChangeDataReservationViewModelFourBottlesViewModel changeDataReservationViewModel4 = new ChangeDataReservationViewModelFourBottlesViewModel();
                changeDataReservationViewModel4.bestellingModel = _dataService.GetBestelling(id);
                TempData["datachange4"] = changeDataReservationViewModel4;
                return RedirectToAction("ChangeDataReservationFourBottles");
            }
            else
            {
                ChangeDataReservationViewModelFiveBottlesViewModel changeDataReservationViewModel5 = new ChangeDataReservationViewModelFiveBottlesViewModel();
                changeDataReservationViewModel5.bestellingModel = _dataService.GetBestelling(id);
                TempData["datachange5"] = changeDataReservationViewModel5;
                return RedirectToAction("ChangeDataReservationFiveBottles");
            }

        }


        [Authorize]

        public ActionResult ChangeDataReservationTwoBottles()
        {
            ChangeDataReservationViewModelTwoBottlesViewModel change = (ChangeDataReservationViewModelTwoBottlesViewModel)TempData["datachange2"];
            change.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
            change.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();

            foreach (var item in _dataService.GetAllCustomers())
            {
                change.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
            }
            foreach (var item in _dataService.GetAllWhiskeys())
            {
                change.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
            }
            return View(change);
        }

        [Authorize]


        public ActionResult ChangeDataReservationThreeBottles()
        {
            ChangeDataReservationViewModelThreeBottlesViewModel change = (ChangeDataReservationViewModelThreeBottlesViewModel)TempData["datachange3"];
            change.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
            change.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();

            foreach (var item in _dataService.GetAllCustomers())
            {
                change.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
            }
            foreach (var item in _dataService.GetAllWhiskeys())
            {
                change.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
            }
            return View(change);
        }

        [Authorize]

        public ActionResult ChangeDataReservationFourBottles()
        {
            ChangeDataReservationViewModelFourBottlesViewModel change = (ChangeDataReservationViewModelFourBottlesViewModel)TempData["datachange4"];
            change.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
            change.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();

            foreach (var item in _dataService.GetAllCustomers())
            {
                change.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
            }
            foreach (var item in _dataService.GetAllWhiskeys())
            {
                change.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
            }
            return View(change);
        }

        [Authorize]

        public ActionResult ChangeDataReservationFiveBottles()
        {
            ChangeDataReservationViewModelFiveBottlesViewModel change = (ChangeDataReservationViewModelFiveBottlesViewModel)TempData["datachange5"];
            change.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
            change.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();

            foreach (var item in _dataService.GetAllCustomers())
            {
                change.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
            }
            foreach (var item in _dataService.GetAllWhiskeys())
            {
                change.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
            }
            return View(change);
        }

        [Authorize]
        [HttpPost]
        public ActionResult ChangeDataReservation(string id, ChangeDataReservationViewModel bestelling)
        {

            try
            {
                // TODO: Add update logic here
                bestelling.bestellingModel.WhiskeyAndAmount = new Dictionary<WhiskeyModel, int> { { _dataService.GetWhiskeyTroughName(bestelling.StoreChoiceWhiskeyFromDropDownList), bestelling.StoreChoiceAmountOfBottlesWhiskey } };
                bestelling.bestellingModel.Customer = _dataService.GetCustomer(bestelling.StoreChoiceCustomerFromDropDownList);
                _dataService.UpdateBestelling(bestelling.bestellingModel);
                return RedirectToAction("ReservationOverview");
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (NullReferenceException ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                bestelling.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
                bestelling.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
                foreach (var item in _dataService.GetAllCustomers())
                {
                    bestelling.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
                }
                foreach (var item in _dataService.GetAllWhiskeys())
                {
                    bestelling.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
                }
                this.AddNotification("All values should be filled in", NotificationType.ERROR);
                return View(bestelling);
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (ArgumentNullException ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                bestelling.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
                bestelling.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
                foreach (var item in _dataService.GetAllCustomers())
                {
                    bestelling.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
                }
                foreach (var item in _dataService.GetAllWhiskeys())
                {
                    bestelling.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
                }
                this.AddNotification("All values should be filled in", NotificationType.ERROR);
                return View(bestelling);
            }
        }

        [Authorize]
        [HttpPost]

        public ActionResult ChangeDataReservationTwoBottles(string id, ChangeDataReservationViewModelTwoBottlesViewModel bestelling)
        {
            try
            {
                // TODO: Add update logic here
                bestelling.bestellingModel.WhiskeyAndAmount = new Dictionary<WhiskeyModel, int> { { _dataService.GetWhiskeyTroughName(bestelling.StoreChoiceWhiskeyFromDropDownList),
                bestelling.StoreChoiceAmountOfBottlesWhiskey }, { _dataService.GetWhiskeyTroughName(bestelling.StoreChoiceWhiskeyFromDropDownList2), bestelling.StoreChoiceAmountOfBottlesWhiskey2} };
                bestelling.bestellingModel.Customer = _dataService.GetCustomer(bestelling.StoreChoiceCustomerFromDropDownList);
                _dataService.UpdateBestelling(bestelling.bestellingModel);
                return RedirectToAction("ReservationOverview");
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (NullReferenceException ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                bestelling.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
                bestelling.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
                foreach (var item in _dataService.GetAllCustomers())
                {
                    bestelling.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
                }
                foreach (var item in _dataService.GetAllWhiskeys())
                {
                    bestelling.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
                }
                this.AddNotification("All values should be filled in", NotificationType.ERROR);
                return View(bestelling);
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (ArgumentNullException ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                bestelling.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
                bestelling.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
                foreach (var item in _dataService.GetAllCustomers())
                {
                    bestelling.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
                }
                foreach (var item in _dataService.GetAllWhiskeys())
                {
                    bestelling.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
                }
                this.AddNotification("All values should be filled in", NotificationType.ERROR);
                return View(bestelling);
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (ArgumentException ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                bestelling.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
                bestelling.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
                foreach (var item in _dataService.GetAllCustomers().ToList())
                {
                    bestelling.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
                }
                foreach (var item in _dataService.GetAllWhiskeys().ToList())
                {
                    bestelling.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
                }
                this.AddNotification("You can't add duplicate whiskey's", NotificationType.ERROR);
                return View(bestelling);
            }
        }

        [Authorize]
        [HttpPost]

        public ActionResult ChangeDataReservationThreeBottles(string id, ChangeDataReservationViewModelThreeBottlesViewModel bestelling)
        {
            try
            {
                // TODO: Add update logic here
                bestelling.bestellingModel.WhiskeyAndAmount = new Dictionary<WhiskeyModel, int> { { _dataService.GetWhiskeyTroughName(bestelling.StoreChoiceWhiskeyFromDropDownList), bestelling.StoreChoiceAmountOfBottlesWhiskey },
                { _dataService.GetWhiskeyTroughName(bestelling.StoreChoiceWhiskeyFromDropDownList2), bestelling.StoreChoiceAmountOfBottlesWhiskey2 }, { _dataService.GetWhiskeyTroughName(bestelling.StoreChoiceWhiskeyFromDropDownList3), bestelling.StoreChoiceAmountOfBottlesWhiskey3} };
                bestelling.bestellingModel.Customer = _dataService.GetCustomer(bestelling.StoreChoiceCustomerFromDropDownList);
                _dataService.UpdateBestelling(bestelling.bestellingModel);
                return RedirectToAction("ReservationOverview");
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (NullReferenceException ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                bestelling.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
                bestelling.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
                foreach (var item in _dataService.GetAllCustomers())
                {
                    bestelling.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
                }
                foreach (var item in _dataService.GetAllWhiskeys())
                {
                    bestelling.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
                }
                this.AddNotification("All values should be filled in", NotificationType.ERROR);
                return View(bestelling);
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (ArgumentNullException ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                bestelling.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
                bestelling.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
                foreach (var item in _dataService.GetAllCustomers())
                {
                    bestelling.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
                }
                foreach (var item in _dataService.GetAllWhiskeys())
                {
                    bestelling.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
                }
                this.AddNotification("All values should be filled in", NotificationType.ERROR);
                return View(bestelling);
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (ArgumentException ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                bestelling.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
                bestelling.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
                foreach (var item in _dataService.GetAllCustomers().ToList())
                {
                    bestelling.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
                }
                foreach (var item in _dataService.GetAllWhiskeys().ToList())
                {
                    bestelling.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
                }
                this.AddNotification("You can't add duplicate whiskey's", NotificationType.ERROR);
                return View(bestelling);
            }
        }

        [Authorize]
        [HttpPost]

        public ActionResult ChangeDataReservationFourBottles(string id, ChangeDataReservationViewModelFourBottlesViewModel bestelling)
        {
            try
            {
                // TODO: Add update logic here
                bestelling.bestellingModel.WhiskeyAndAmount = new Dictionary<WhiskeyModel, int> { { _dataService.GetWhiskeyTroughName(bestelling.StoreChoiceWhiskeyFromDropDownList), bestelling.StoreChoiceAmountOfBottlesWhiskey },
                { _dataService.GetWhiskeyTroughName(bestelling.StoreChoiceWhiskeyFromDropDownList2), bestelling.StoreChoiceAmountOfBottlesWhiskey2 }, { _dataService.GetWhiskeyTroughName(bestelling.StoreChoiceWhiskeyFromDropDownList3), bestelling.StoreChoiceAmountOfBottlesWhiskey3},
                {_dataService.GetWhiskeyTroughName(bestelling.StoreChoiceWhiskeyFromDropDownList4), bestelling.StoreChoiceAmountOfBottlesWhiskey4 } };
                bestelling.bestellingModel.Customer = _dataService.GetCustomer(bestelling.StoreChoiceCustomerFromDropDownList);
                _dataService.UpdateBestelling(bestelling.bestellingModel);
                return RedirectToAction("ReservationOverview");
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (NullReferenceException ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                bestelling.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
                bestelling.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
                foreach (var item in _dataService.GetAllCustomers())
                {
                    bestelling.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
                }
                foreach (var item in _dataService.GetAllWhiskeys())
                {
                    bestelling.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
                }
                this.AddNotification("All values should be filled in", NotificationType.ERROR);
                return View(bestelling);
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (ArgumentNullException ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                bestelling.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
                bestelling.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
                foreach (var item in _dataService.GetAllCustomers())
                {
                    bestelling.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
                }
                foreach (var item in _dataService.GetAllWhiskeys())
                {
                    bestelling.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
                }
                this.AddNotification("All values should be filled in", NotificationType.ERROR);
                return View(bestelling);
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (ArgumentException ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                bestelling.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
                bestelling.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
                foreach (var item in _dataService.GetAllCustomers().ToList())
                {
                    bestelling.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
                }
                foreach (var item in _dataService.GetAllWhiskeys().ToList())
                {
                    bestelling.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
                }
                this.AddNotification("You can't add duplicate whiskey's", NotificationType.ERROR);
                return View(bestelling);
            }
        }

        [Authorize]
        [HttpPost]

        public ActionResult ChangeDataReservationFiveBottles(string id, ChangeDataReservationViewModelFiveBottlesViewModel bestelling)
        {
            try
            {
                // TODO: Add update logic here
                bestelling.bestellingModel.WhiskeyAndAmount = new Dictionary<WhiskeyModel, int> { { _dataService.GetWhiskeyTroughName(bestelling.StoreChoiceWhiskeyFromDropDownList), bestelling.StoreChoiceAmountOfBottlesWhiskey },
                { _dataService.GetWhiskeyTroughName(bestelling.StoreChoiceWhiskeyFromDropDownList2), bestelling.StoreChoiceAmountOfBottlesWhiskey2 }, { _dataService.GetWhiskeyTroughName(bestelling.StoreChoiceWhiskeyFromDropDownList3), bestelling.StoreChoiceAmountOfBottlesWhiskey3},
                {_dataService.GetWhiskeyTroughName(bestelling.StoreChoiceWhiskeyFromDropDownList4), bestelling.StoreChoiceAmountOfBottlesWhiskey4 } ,
                    { _dataService.GetWhiskeyTroughName(bestelling.StoreChoiceWhiskeyFromDropDownList5), bestelling.StoreChoiceAmountOfBottlesWhiskey5} };
                bestelling.bestellingModel.Customer = _dataService.GetCustomer(bestelling.StoreChoiceCustomerFromDropDownList);
                _dataService.UpdateBestelling(bestelling.bestellingModel);
                return RedirectToAction("ReservationOverview");
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (NullReferenceException ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                bestelling.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
                bestelling.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
                foreach (var item in _dataService.GetAllCustomers())
                {
                    bestelling.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
                }
                foreach (var item in _dataService.GetAllWhiskeys())
                {
                    bestelling.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
                }
                this.AddNotification("All values should be filled in", NotificationType.ERROR);
                return View(bestelling);
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (ArgumentNullException ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                bestelling.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
                bestelling.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
                foreach (var item in _dataService.GetAllCustomers())
                {
                    bestelling.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
                }
                foreach (var item in _dataService.GetAllWhiskeys())
                {
                    bestelling.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
                }
                this.AddNotification("All values should be filled in", NotificationType.ERROR);
                return View(bestelling);
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (ArgumentException ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                bestelling.GenerateDropDownDataFromCustomer = new List<SelectListItem>();
                bestelling.GenerateDropDownDataFromWhiskey = new List<SelectListItem>();
                foreach (var item in _dataService.GetAllCustomers().ToList())
                {
                    bestelling.GenerateDropDownDataFromCustomer.Add(new SelectListItem { Text = item.FirstName + " " + item.LastName, Value = item.id });
                }
                foreach (var item in _dataService.GetAllWhiskeys().ToList())
                {
                    bestelling.GenerateDropDownDataFromWhiskey.Add(new SelectListItem { Text = item.Name, Value = item.Name });
                }
                this.AddNotification("You can't add duplicate whiskey's", NotificationType.ERROR);
                return View(bestelling);
            }
        }

        [Authorize]

        // GET: ReservationAdd/Delete/5
        public ActionResult RemoveReservation(string id)
        {
            return View(_dataService.GetBestelling(id));
        }

        // POST: ReservationAdd/Delete/5
        [Authorize]
        [HttpPost]
        public ActionResult RemoveReservation(string id, BestellingModel bestelling)
        {
            try
            {
                // TODO: Add delete logic here
                _dataService.DeleteBestelling(bestelling.id);
                return RedirectToAction("ReservationOverview");
            }
            catch
            {
                return View();
            }
        }
    }
}
