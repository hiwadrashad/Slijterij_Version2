using SlijterijSjonnieLoper_version2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SlijterijSjonnieLoper_version2.DAL
{
    public class ApplicationDataService : IDataService
    {
        private ApplicationDbContext.ApplicationDbContext _dbContext = ApplicationDbContext.ApplicationDbContext.GetDbcontext();
        private static ApplicationDataService _applicationDataService;

        private ApplicationDataService() { }

        public static ApplicationDataService GetService()
        {
            if (_applicationDataService == null)
            {
                _applicationDataService = new ApplicationDataService();
            }
            return _applicationDataService;
        }

        public bool AddBestelling(BestellingModel bestelling)
        {
            _dbContext.bestellingModels.Add(bestelling);
            _dbContext.SaveChanges();
            return true;
        }

        public bool AddCustomer(CustomerModel customer)
        {
            _dbContext.customerModels.Add(customer);
            _dbContext.SaveChanges();
            return true;
        }

        public bool AddEmployee(EmployeeModel employee)
        {
            _dbContext.employeeModels.Add(employee);
            _dbContext.SaveChanges();
            return true;
        }

        public bool AddWhiskey(WhiskeyModel whiskey)
        {
            _dbContext.whiskeyModels.Add(whiskey);
            _dbContext.SaveChanges();
            return true;
        }


        public bool CheckAndAssignIfOrderIsDoneTroughCheckingDateOfCompletion()
        {
            for (int i = 0; i < _dbContext.bestellingModels.Count(); i++)
            {
                if (_dbContext.bestellingModels.ToList()[i].DateOfCompletionOrder <= DateTime.Now)
                {
                    _dbContext.bestellingModels.ToList()[i].CompletedOrder = true;
                    var item = _dbContext.bestellingModels.Where(a => a.id == _dbContext.bestellingModels.ToList()[i].id).FirstOrDefault();
                    item = _dbContext.bestellingModels.ToList()[i];
                }
            }
            return true;
        }

        public bool DeleteBestelling(string id)
        {
            _dbContext.bestellingModels.Remove(_dbContext.bestellingModels.Where(a => a.id == id).FirstOrDefault());
            _dbContext.SaveChanges();
            return true;
        }

        public bool DeleteCustomer(string id)
        {
            _dbContext.customerModels.Remove(_dbContext.customerModels.Where(a => a.id == id).FirstOrDefault());
            _dbContext.SaveChanges();
            return true;
        }

        public bool DeleteEmployee(string id)
        {
            _dbContext.employeeModels.Remove(_dbContext.employeeModels.Where(a => a.id == id).FirstOrDefault());
            _dbContext.SaveChanges();
            return true;
        }

        public bool DeleteWhiskey(string id)
        {
            _dbContext.whiskeyModels.Remove(_dbContext.whiskeyModels.Where(a => a.id == id).FirstOrDefault());
            _dbContext.SaveChanges();
            return true;
        }


        public IEnumerable<BestellingModel> GetAllBestellingen()
        {
            return _dbContext.bestellingModels;
        }

        public IEnumerable<CustomerModel> GetAllCustomers()
        {
            return _dbContext.customerModels;
        }

        public IEnumerable<EmployeeModel> GetAllEmployees()
        {
            return _dbContext.employeeModels;
        }

        public IEnumerable<WhiskeyModel> GetAllWhiskeys()
        {
            return _dbContext.whiskeyModels;
        }


        public BestellingModel GetBestelling(string id)
        {
            return _dbContext.bestellingModels.Where(a => a.id == id).FirstOrDefault();
        }

        public CustomerModel GetCustomer(string id)
        {
            return _dbContext.customerModels.Where(a => a.id == id).FirstOrDefault();
        }

        public EmployeeModel GetEmployee(string id)
        {
            return _dbContext.employeeModels.Where(a => a.id == id).FirstOrDefault();
        }

        public WhiskeyModel GetWhiskey(string id)
        {
            return _dbContext.whiskeyModels.Where(a => a.id == id).FirstOrDefault();
        }


        public CustomerModel GetCustomerTroughFirstAndLastName(string firstname, string lastname)
        {
            return _dbContext.customerModels.Where(a => a.FirstName == firstname && a.LastName == lastname).FirstOrDefault();
        }

        public WhiskeyModel GetWhiskeyTroughName(string name)
        {
            return _dbContext.whiskeyModels.Where(a => a.Name == name).FirstOrDefault();
        }
#nullable enable
        public List<WhiskeyModel>? SearchWhiskeys(string name)
        {
            List<WhiskeyModel> combinedsearch = new List<WhiskeyModel>();
            var textsplit = name.Split(' ').ToList();
            foreach (var item in textsplit)
            {
                if (_dbContext.whiskeyModels.Where(a => a.Name.ToLower() == name.ToLower() || a.ProductionSite.ToString().ToLower() == name.ToLower() || a.alcoholPercentages.ToString().ToLower() == name.ToLower() || a.age.ToString().ToLower() == name.ToLower() || a.typesOfWhiskey.ToString().ToLower() == name.ToLower() || name == null).ToList() != null)
                {
                    combinedsearch.AddRange(_dbContext.whiskeyModels.Where(a => a.Name.ToLower() == name.ToLower() || a.ProductionSite.ToString().ToLower() == name.ToLower() || a.alcoholPercentages.ToString().ToLower() == name.ToLower() || a.age.ToString().ToLower() == name.ToLower() || a.typesOfWhiskey.ToString().ToLower() == name.ToLower() || name == null).ToList());
                }
            }
            var listwithnoduplicates = combinedsearch.Distinct().ToList();

            return listwithnoduplicates;
        }
#nullable disable

        public bool UpdateBestelling(BestellingModel bestelling)
        {
            var item = _dbContext.bestellingModels.Where(a => a.id == bestelling.id).FirstOrDefault();
            item = bestelling;
            _dbContext.SaveChanges();
            return true;
        }

        public bool UpdateCustomer(CustomerModel customer)
        {
            var item = _dbContext.customerModels.Where(a => a.id == customer.id).FirstOrDefault();
            item = customer;
            _dbContext.SaveChanges();
            return true;
        }

        public bool UpdateEmployee(EmployeeModel employee)
        {
            var item = _dbContext.employeeModels.Where(a => a.id == employee.id).FirstOrDefault();
            item = employee;
            _dbContext.SaveChanges();
            return true;
        }

        public bool UpdateWhiskey(WhiskeyModel whiskey)
        {
            var item = _dbContext.whiskeyModels.Where(a => a.id == whiskey.id).FirstOrDefault();
            item = whiskey;
            _dbContext.SaveChanges();
            return true;
        }
    }
}