﻿using SlijterijSjonnieLoper_version2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Data;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using System.Web.WebSockets;
using SlijterijSjonnieLoper_version2.GeneralFunctions;
using WebGrease.Configuration;

namespace SlijterijSjonnieLoper_version2.DAL
{
    public class MockdataService : IDataService
    {
        private List<BestellingModel> _bestelling;
        private List<CustomerModel> _customer;
        private List<EmployeeModel> _employee;
        private List<WhiskeyModel> _whiskey;

        private static MockdataService _MockdataService;

        private MockdataService()
        {

        }

        public static MockdataService GetMockdataService()
        {
            if (_MockdataService == null)
            {
                _MockdataService = new MockdataService();
                _MockdataService.InitData();
            }

            return _MockdataService;
        }
        //Dictionary<WhiskeyModel, int> smthng = new Dictionary<WhiskeyModel, int>();
       

        public void InitData()
        {
            //smthng.Add(new WhiskeyModel { id = Guid.NewGuid().ToString() }, 12);
            _bestelling = new List<BestellingModel>()
            {
                //new BestellingModel { id = Guid.NewGuid().ToString(), AmountOfBottles = 14,
                //    City = "Alaska", CompletedOrder = false, Customer = _customer.FirstOrDefault(a => a.FirstName == "John"), DateOfCompletionOrder = new DateTime(2020, 12, 12),
                //    DateOfReservation = new DateTime(2019, 12, 12), HouseNumberAddition = "N.A", StreetNumber = 9,
                //    PostalCode = "3526XL", StreetName ="Grovestreet", Whiskey = _whiskey.FirstOrDefault(a => a.Name == "John Wickers")} ,

                // werkt niet
             

                new BestellingModel { id = Guid.NewGuid().ToString(), WhiskeyAndAmount =  new Dictionary<WhiskeyModel, int>() {{ new WhiskeyModel { id = Guid.NewGuid().ToString(),
                    age = 12, alcoholPercentages = AlcoholPercentagesModel.fortysix, IsRemoved = false, Name = "Lambare",
                    NumberOfBottlesOnStorage = 12, Price = 45.50, typesOfWhiskey = TypesOfWhiskeyModel.Rye,
                    NumberOfBottlesReserved = 12, ProductionSite = ProductionSite.LowLand,
                    LabelImage = new  MemoryPostedFile(File.ReadAllBytes(HttpContext.Current.Server.MapPath(@"~/Images/WhiskeyLabel.jpg")))}, 12 } },
                    City = "Alaska", CompletedOrder = false, Customer = new CustomerModel { id = Guid.NewGuid().ToString(),
                    DateOfBirth = new DateTime(2000, 12, 12), BirthPlace = "California", City = "Alaska", FirstName = "John",
                    LastName = "Smith", HouseNumberAddition = "N.A", PostalNumber = "3525XA", PrepositionName = "N.A",
                    StreetName = "Juxtonstreet", StreetNumber = 9}, DateOfCompletionOrder = new DateTime(2020, 12, 12),
                    DateOfReservation = new DateTime(2019, 12, 12), HouseNumberAddition = "N.A", StreetNumber = 9,
                    PostalCode = "3526XL", StreetName ="Grovestreet" },

                new BestellingModel { id = Guid.NewGuid().ToString(), WhiskeyAndAmount =  new Dictionary<WhiskeyModel, int>() {{ new WhiskeyModel { id = Guid.NewGuid().ToString(),
                    age = 12, alcoholPercentages = AlcoholPercentagesModel.fortysix, IsRemoved = false, Name = "Lambare",
                    NumberOfBottlesOnStorage = 12, Price = 45.50, typesOfWhiskey = TypesOfWhiskeyModel.Rye,
                    NumberOfBottlesReserved = 12, ProductionSite = ProductionSite.LowLand,
                    LabelImage = new  MemoryPostedFile(File.ReadAllBytes(HttpContext.Current.Server.MapPath(@"~/Images/WhiskeyLabel.jpg")))}, 12 } },
                    City = "Alaska", CompletedOrder = false, Customer = new CustomerModel { id = Guid.NewGuid().ToString(),
                    DateOfBirth = new DateTime(2000, 12, 12), BirthPlace = "California", City = "Alaska", FirstName = "John",
                    LastName = "Smith", HouseNumberAddition = "N.A", PostalNumber = "3525XA", PrepositionName = "N.A",
                    StreetName = "Juxtonstreet", StreetNumber = 9}, DateOfCompletionOrder = new DateTime(2020, 12, 12),
                    DateOfReservation = new DateTime(2019, 12, 12), HouseNumberAddition = "N.A", StreetNumber = 9,
                    PostalCode = "3526XL", StreetName ="Grovestreet" },

               new BestellingModel { id = Guid.NewGuid().ToString(), WhiskeyAndAmount =  new Dictionary<WhiskeyModel, int>() {{ new WhiskeyModel { id = Guid.NewGuid().ToString(),
                    age = 12, alcoholPercentages = AlcoholPercentagesModel.fortysix, IsRemoved = false, Name = "Lambare",
                    NumberOfBottlesOnStorage = 12, Price = 45.50, typesOfWhiskey = TypesOfWhiskeyModel.Rye,
                    NumberOfBottlesReserved = 12, ProductionSite = ProductionSite.LowLand,
                    LabelImage = new  MemoryPostedFile(File.ReadAllBytes(HttpContext.Current.Server.MapPath(@"~/Images/WhiskeyLabel.jpg")))}, 12 } },
                    City = "Alaska", CompletedOrder = false, Customer = new CustomerModel { id = Guid.NewGuid().ToString(),
                    DateOfBirth = new DateTime(2000, 12, 12), BirthPlace = "California", City = "Alaska", FirstName = "John",
                    LastName = "Smith", HouseNumberAddition = "N.A", PostalNumber = "3525XA", PrepositionName = "N.A",
                    StreetName = "Juxtonstreet", StreetNumber = 9}, DateOfCompletionOrder = new DateTime(2020, 12, 12),
                    DateOfReservation = new DateTime(2019, 12, 12), HouseNumberAddition = "N.A", StreetNumber = 9,
                    PostalCode = "3526XL", StreetName ="Grovestreet" },

               new BestellingModel { id = Guid.NewGuid().ToString(), WhiskeyAndAmount =  new Dictionary<WhiskeyModel, int>() {{ new WhiskeyModel { id = Guid.NewGuid().ToString(),
                    age = 12, alcoholPercentages = AlcoholPercentagesModel.fortysix, IsRemoved = false, Name = "Lambare",
                    NumberOfBottlesOnStorage = 12, Price = 45.50, typesOfWhiskey = TypesOfWhiskeyModel.Rye,
                    NumberOfBottlesReserved = 12, ProductionSite = ProductionSite.LowLand,
                    LabelImage = new  MemoryPostedFile(File.ReadAllBytes(HttpContext.Current.Server.MapPath(@"~/Images/WhiskeyLabel.jpg")))}, 12 } },
                    City = "Alaska", CompletedOrder = false, Customer = new CustomerModel { id = Guid.NewGuid().ToString(),
                    DateOfBirth = new DateTime(2000, 12, 12), BirthPlace = "California", City = "Alaska", FirstName = "John",
                    LastName = "Smith", HouseNumberAddition = "N.A", PostalNumber = "3525XA", PrepositionName = "N.A",
                    StreetName = "Juxtonstreet", StreetNumber = 9}, DateOfCompletionOrder = new DateTime(2020, 12, 12),
                    DateOfReservation = new DateTime(2019, 12, 12), HouseNumberAddition = "N.A", StreetNumber = 9,
                    PostalCode = "3526XL", StreetName ="Grovestreet" },

            };
            _customer = new List<CustomerModel>()
            {
                new CustomerModel { id = Guid.NewGuid().ToString(),EmailAdress ="test@gmail.com", BirthPlace = "Alaska", City = "London",
                DateOfBirth = new DateTime(1987, 12, 12), FirstName = "John", LastName = "Smith", HouseNumberAddition = "N.A",
                PostalNumber = "45AL", PrepositionName = "Von", StreetName = "Berkleylane", StreetNumber = 12},

                new CustomerModel { id = Guid.NewGuid().ToString(),EmailAdress ="test@gmail.com", BirthPlace = "Alaska", City = "London",
                DateOfBirth = new DateTime(1987, 12, 12), FirstName = "John", LastName = "Smith", HouseNumberAddition = "N.A",
                PostalNumber = "45AL", PrepositionName = "Von", StreetName = "Berkleylane", StreetNumber = 12},

                new CustomerModel { id = Guid.NewGuid().ToString(),EmailAdress ="test@gmail.com", BirthPlace = "Alaska", City = "London",
                DateOfBirth = new DateTime(1987, 12, 12), FirstName = "John", LastName = "Smith", HouseNumberAddition = "N.A",
                PostalNumber = "45AL", PrepositionName = "Von", StreetName = "Berkleylane", StreetNumber = 12},

                new CustomerModel { id = Guid.NewGuid().ToString(),EmailAdress ="test@gmail.com", BirthPlace = "Alaska", City = "London",
                DateOfBirth = new DateTime(1987, 12, 12), FirstName = "John", LastName = "Smith", HouseNumberAddition = "N.A",
                PostalNumber = "45AL", PrepositionName = "Von", StreetName = "Berkleylane", StreetNumber = 12},

                new CustomerModel { id = Guid.NewGuid().ToString(),EmailAdress ="test@gmail.com", BirthPlace = "Alaska", City = "London",
                DateOfBirth = new DateTime(1987, 12, 12), FirstName = "John", LastName = "Smith", HouseNumberAddition = "N.A",
                PostalNumber = "45AL", PrepositionName = "Von", StreetName = "Berkleylane", StreetNumber = 12},


            };
            _employee = new List<EmployeeModel>()
            {
                new EmployeeModel { id = Guid.NewGuid().ToString(), FirstName = "Lisa", LastName = "Wong", BirthDate = new DateTime(1994, 12, 12),
                BirthPlace ="Shanghai", City = "Toronto", HouseNumberAddition = "N.A", PassWord = "password", UserName = "username",
                PostalCode = "3525CL", PrepositionName = "N.A", RoleEmployee = RoleEmployeeModel.Security, StreetName = "Washingtonstreet",
                StreetNumber = 89, WorkingSince = new DateTime(2019, 12,14)},

                new EmployeeModel { id = Guid.NewGuid().ToString(), FirstName = "Lisa", LastName = "Wong", BirthDate = new DateTime(1994, 12, 12),
                BirthPlace ="Shanghai", City = "Toronto", HouseNumberAddition = "N.A", PassWord = "password", UserName = "username",
                PostalCode = "3525CL", PrepositionName = "N.A", RoleEmployee = RoleEmployeeModel.Security, StreetName = "Washingtonstreet",
                StreetNumber = 89, WorkingSince = new DateTime(2019, 12,14)},

                new EmployeeModel { id = Guid.NewGuid().ToString(), FirstName = "Lisa", LastName = "Wong", BirthDate = new DateTime(1994, 12, 12),
                BirthPlace ="Shanghai", City = "Toronto", HouseNumberAddition = "N.A", PassWord = "password", UserName = "username",
                PostalCode = "3525CL", PrepositionName = "N.A", RoleEmployee = RoleEmployeeModel.Security, StreetName = "Washingtonstreet",
                StreetNumber = 89, WorkingSince = new DateTime(2019, 12,14)},

                new EmployeeModel { id = Guid.NewGuid().ToString(), FirstName = "Lisa", LastName = "Wong", BirthDate = new DateTime(1994, 12, 12),
                BirthPlace ="Shanghai", City = "Toronto", HouseNumberAddition = "N.A", PassWord = "password", UserName = "username",
                PostalCode = "3525CL", PrepositionName = "N.A", RoleEmployee = RoleEmployeeModel.Security, StreetName = "Washingtonstreet",
                StreetNumber = 89, WorkingSince = new DateTime(2019, 12,14)},

                new EmployeeModel { id = Guid.NewGuid().ToString(), FirstName = "Lisa", LastName = "Wong", BirthDate = new DateTime(1994, 12, 12),
                BirthPlace ="Shanghai", City = "Toronto", HouseNumberAddition = "N.A", PassWord = "password", UserName = "username",
                PostalCode = "3525CL", PrepositionName = "N.A", RoleEmployee = RoleEmployeeModel.Security, StreetName = "Washingtonstreet",
                StreetNumber = 89, WorkingSince = new DateTime(2019, 12,14)},
            };
            _whiskey = new List<WhiskeyModel>()
            {
                new WhiskeyModel { id = Guid.NewGuid().ToString(), age = 21, alcoholPercentages = AlcoholPercentagesModel.thirthyeight,
                IsRemoved = false, Name = "John Wickers", NumberOfBottlesOnStorage = 12, NumberOfBottlesReserved = 14, Price = 45.75,
                ProductionSite = ProductionSite.Sparrow , typesOfWhiskey = TypesOfWhiskeyModel.Bourbon ,
                LabelImage = new MemoryPostedFile(File.ReadAllBytes(HttpContext.Current.Server.MapPath(@"~/Images/WhiskeyLabel.jpg")))},

                new WhiskeyModel { id = Guid.NewGuid().ToString(), age = 21, alcoholPercentages = AlcoholPercentagesModel.thirthyeight,
                IsRemoved = false, Name = "John Wickers2", NumberOfBottlesOnStorage = 12, NumberOfBottlesReserved = 14, Price = 45.75,
                ProductionSite = ProductionSite.Sparrow , typesOfWhiskey = TypesOfWhiskeyModel.Bourbon ,
                LabelImage = new MemoryPostedFile(File.ReadAllBytes(HttpContext.Current.Server.MapPath(@"~/Images/WhiskeyLabel.jpg")))},

                new WhiskeyModel { id = Guid.NewGuid().ToString(), age = 21, alcoholPercentages = AlcoholPercentagesModel.thirthyeight,
                IsRemoved = false, Name = "John Wickers3", NumberOfBottlesOnStorage = 12, NumberOfBottlesReserved = 14, Price = 45.75,
                ProductionSite = ProductionSite.Sparrow , typesOfWhiskey = TypesOfWhiskeyModel.Bourbon ,
                LabelImage = new MemoryPostedFile(File.ReadAllBytes(HttpContext.Current.Server.MapPath(@"~/Images/WhiskeyLabel.jpg")))},

                new WhiskeyModel { id = Guid.NewGuid().ToString(), age = 21, alcoholPercentages = AlcoholPercentagesModel.thirthyeight,
                IsRemoved = false, Name = "John Wickers4", NumberOfBottlesOnStorage = 12, NumberOfBottlesReserved = 14, Price = 45.75,
                ProductionSite = ProductionSite.Sparrow , typesOfWhiskey = TypesOfWhiskeyModel.Bourbon ,
                LabelImage = new MemoryPostedFile(File.ReadAllBytes(HttpContext.Current.Server.MapPath(@"~/Images/WhiskeyLabel.jpg")))},

                new WhiskeyModel { id = Guid.NewGuid().ToString(), age = 21, alcoholPercentages = AlcoholPercentagesModel.thirthyeight,
                IsRemoved = false, Name = "John Wickers5", NumberOfBottlesOnStorage = 12, NumberOfBottlesReserved = 14, Price = 45.75,
                ProductionSite = ProductionSite.Sparrow , typesOfWhiskey = TypesOfWhiskeyModel.Bourbon ,
                LabelImage = new MemoryPostedFile(File.ReadAllBytes(HttpContext.Current.Server.MapPath(@"~/Images/WhiskeyLabel.jpg")))},
            };
        }

        public bool AddBestelling(BestellingModel bestelling)
        {
            _bestelling.Add(bestelling);
            return true;
        }

        public bool AddCustomer(CustomerModel customer)
        {
            _customer.Add(customer);
            return true;
        }

        public bool AddEmployee(EmployeeModel employee)
        {
            _employee.Add(employee);
            return true;
        }

        public bool AddWhiskey(WhiskeyModel whiskey)
        {
            _whiskey.Add(whiskey);
            return true;
        }

        public bool DeleteBestelling(string id)
        {
            BestellingModel bestelling = _bestelling.FirstOrDefault(a => a.id == id);
            _bestelling.Remove(bestelling);
            return true;
        }

        public bool DeleteCustomer(string id)
        {
            CustomerModel customer = _customer.FirstOrDefault(a => a.id == id);
            _customer.Remove(customer);
            return true;
        }

        public bool DeleteEmployee(string id)
        {
            EmployeeModel employee = _employee.FirstOrDefault(a => a.id == id);
            _employee.Remove(employee);
            return true;
        }

        public bool DeleteWhiskey(string id)
        {
            WhiskeyModel whiskey = _whiskey.FirstOrDefault(a => a.id == id);
            _whiskey.Remove(whiskey);
            return true;
        }

        public IEnumerable<BestellingModel> GetAllBestellingen()
        {
            return _bestelling;
        }

        public IEnumerable<CustomerModel> GetAllCustomers()
        {
            return _customer;
        }

        public IEnumerable<EmployeeModel> GetAllEmployees()
        {
            return _employee;
        }

        public IEnumerable<WhiskeyModel> GetAllWhiskeys()
        {
            return _whiskey;
        }

        public BestellingModel GetBestelling(string id)
        {
            return _bestelling.FirstOrDefault(a => a.id == id);
        }

        public CustomerModel GetCustomer(string id)
        {
            return _customer.FirstOrDefault(a => a.id == id);
        }

        public EmployeeModel GetEmployee(string id)
        {
            return _employee.FirstOrDefault(a => a.id == id);
        }

        public WhiskeyModel GetWhiskey(string id)
        {
            return _whiskey.FirstOrDefault(a => a.id == id);
        }

        public bool UpdateBestelling(BestellingModel bestelling)
        {
            var GetBestellingTroughId = _bestelling.Where(a => a.id == bestelling.id).FirstOrDefault();
            GetBestellingTroughId = bestelling;
            return true;
        }

        public bool UpdateCustomer(CustomerModel customer)
        {
            var GetCustomerTroughId = _customer.Where(a => a.id == customer.id).FirstOrDefault();
            GetCustomerTroughId = customer;
            return true;
        }

        public bool UpdateEmployee(EmployeeModel employee)
        {
            var GetEmployeeTroughId = _employee.Where(a => a.id == employee.id).FirstOrDefault();
            GetEmployeeTroughId = employee;
            return true;
        }

        public bool UpdateWhiskey(WhiskeyModel whiskey)
        {
            var GetWhiskeyTroughId = _whiskey.Where(a => a.id == whiskey.id).FirstOrDefault();
            GetWhiskeyTroughId = whiskey;
            return true;
        }

#nullable enable
        public List<WhiskeyModel>? SearchWhiskeys(string name)
        {
            List<WhiskeyModel> combinedsearch = new List<WhiskeyModel>();
            var textsplit = name.Split(' ').ToList();
            foreach (var item in textsplit)
            {
                if (_whiskey.Where(a => a.Name.ToLower() == name.ToLower() || a.ProductionSite.ToString().ToLower() == name.ToLower() ||
                a.alcoholPercentages.ToString().ToLower() == name.ToLower() || a.age.ToString().ToLower() == name.ToLower() ||
                a.typesOfWhiskey.ToString().ToLower() == name.ToLower() || name == null).ToList() != null)
                {
                    combinedsearch.AddRange(_whiskey.Where(a => a.Name.ToLower() == name.ToLower() || a.ProductionSite.ToString().ToLower() == name.ToLower() ||
                    a.alcoholPercentages.ToString().ToLower() == name.ToLower() || a.age.ToString().ToLower() == name.ToLower() ||
                    a.typesOfWhiskey.ToString().ToLower() == name.ToLower() || name == null).ToList());
                }
            }
            var listwithnoduplicates = combinedsearch.Distinct().ToList();
            //return _whiskey.Where(a => a.Name.ToLower() == name.ToLower() || a.ProductionSite.ToString().ToLower() == name.ToLower() || a.alcoholPercentages.ToString().ToLower() == name.ToLower() || a.age.ToString().ToLower() == name.ToLower() || a.typesOfWhiskey.ToString().ToLower() == name.ToLower() || name == null).ToList();
            return listwithnoduplicates;
        }
#nullable disable

        public WhiskeyModel GetWhiskeyTroughName(string name)
        {
            return _whiskey.Where(a => a.Name == name).FirstOrDefault();
        }

        public CustomerModel GetCustomerTroughFirstAndLastName(string firstname, string lastname)
        {
            return _customer.Where(a => a.FirstName == firstname && a.LastName == lastname).FirstOrDefault();
        }

        public bool CheckAndAssignIfOrderIsDoneTroughCheckingDateOfCompletion()
        {
            for(int i = 0; i<_bestelling.Count; i++)
            {
                if (_bestelling[i].DateOfCompletionOrder <= DateTime.Now)
                {
                    _bestelling[i].CompletedOrder = true;
                   // SmtpMailService.SendCustomerMail.SendMailToCustomer(_bestelling[i].Customer.EmailAdress,ITextSharpPdfCreator.GenerateMailForCustomer.GeneratePdfFileForCustomer());
                     
                }
            }
         return true;
        }
       
    }
}