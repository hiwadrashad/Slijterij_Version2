using SlijterijSjonnieLoper_version2.DAL;
using SlijterijSjonnieLoper_version2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SlijterijSjonnieLoper_version2.Controllers
{
    public class CustomerController : Controller
    {
        // GET: AddCustomer
        public ActionResult CustomerOverview()
        {
            
            return View(MockdataService.GetMockdataService().GetAllCustomers().ToList());
        }

        // GET: AddCustomer/Details/5
        public ActionResult CustomerData(string id)
        {
            return View(MockdataService.GetMockdataService().GetCustomer(id));
        }

        // GET: AddCustomer/Create
        public ActionResult AddNewCustomer()
        {
            return View();
        }

        // POST: AddCustomer/Create
        [HttpPost]
        public ActionResult AddNewCustomer(CustomerModel customer)
        {
            try
            {
                // TODO: Add insert logic here
                MockdataService.GetMockdataService().AddCustomer(customer);
                return RedirectToAction("CustomerOverview");
            }
            catch
            {
                return View();
            }
        }

        // GET: AddCustomer/Edit/5
        public ActionResult ChangeCustomerData(string id)
        {
            return View(MockdataService.GetMockdataService().GetCustomer(id));
            
        }

        // POST: AddCustomer/Edit/5
        [HttpPost]
        public ActionResult ChangeCustomerData(string id, CustomerModel customer)
        {
            try
            {
                // TODO: Add update logic here
                MockdataService.GetMockdataService().UpdateCustomer(customer);
                return RedirectToAction("CustomerOverview");
            }
            catch
            {
                return View();
            }
        }

        // GET: AddCustomer/Delete/5
        public ActionResult RemoveCustomerdata(string id)
        {
            return View(MockdataService.GetMockdataService().GetCustomer(id));
        }

        // POST: AddCustomer/Delete/5
        [HttpPost]
        public ActionResult RemoveCustomerData(string id, CustomerModel customer)
        {
            try
            {
                // TODO: Add delete logic here
                MockdataService.GetMockdataService().DeleteCustomer(customer.id);
                return RedirectToAction("CustomerOverview");
            }
            catch
            {
                return View();
            }
        }
    }
}
