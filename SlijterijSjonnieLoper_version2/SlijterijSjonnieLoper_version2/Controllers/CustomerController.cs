﻿using SlijterijSjonnieLoper_version2.DAL;
using SlijterijSjonnieLoper_version2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SlijterijSjonnieLoper_version2.Controllers
{
    public class CustomerController : AccountController
    {
        // GET: AddCustomer
        

        private IDataService _dataService = MockdataService.GetMockdataService();
        //private IDataService _dataService = ApplicationDataService.GetService();
        [Authorize]
        public ActionResult CustomerOverview()
        {
            
            return View(_dataService.GetAllCustomers().ToList());
        }

        // GET: AddCustomer/Details/5
        [Authorize]
        public ActionResult CustomerData(string id)
        {
            return View(_dataService.GetCustomer(id));
        }

        // GET: AddCustomer/Create
        [Authorize]
        public ActionResult AddNewCustomer()
        {
            return View();
        }

        // POST: AddCustomer/Create
        [Authorize]
        [HttpPost]
        public ActionResult AddNewCustomer(CustomerModel customer)
        {
            try
            {
                // TODO: Add insert logic here
                _dataService.AddCustomer(customer);
                return RedirectToAction("CustomerOverview");
            }
            catch
            {
                return View();
            }
        }

        // GET: AddCustomer/Edit/5
        [Authorize]
        public ActionResult ChangeCustomerData(string id)
        {
            return View(_dataService.GetCustomer(id));
            
        }

        // POST: AddCustomer/Edit/5
        [Authorize]
        [HttpPost]

        public ActionResult ChangeCustomerData(string id, CustomerModel customer)
        {
            try
            {
                // TODO: Add update logic here
                _dataService.UpdateCustomer(customer);
                return RedirectToAction("CustomerOverview");
            }
            catch
            {
                return View();
            }
        }

        // GET: AddCustomer/Delete/5
        [Authorize]

        public ActionResult RemoveCustomerdata(string id)
        {
            return View(_dataService.GetCustomer(id));
        }

        // POST: AddCustomer/Delete/
        [Authorize]
        [HttpPost]
        public ActionResult RemoveCustomerData(string id, CustomerModel customer)
        {
            try
            {
                // TODO: Add delete logic here
                _dataService.DeleteCustomer(customer.id);
                return RedirectToAction("CustomerOverview");
            }
            catch
            {
                return View();
            }
        }
    }
}
