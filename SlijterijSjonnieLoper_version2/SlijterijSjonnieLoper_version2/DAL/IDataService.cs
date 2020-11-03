using SlijterijSjonnieLoper_version2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlijterijSjonnieLoper_version2.DAL
{
    interface IDataService
    {
        bool AddBestelling(BestellingModel bestelling);
        bool DeleteBestelling(string id);
        IEnumerable<BestellingModel> GetAllBestellingen();
        BestellingModel GetBestelling(string id);
        bool UpdateBestelling(BestellingModel bestelling);

        bool AddCustomer(CustomerModel customer);
        bool DeleteCustomer(string id);
        IEnumerable<CustomerModel> GetAllCustomers();
        CustomerModel GetCustomer(string id);
        bool UpdateCustomer(CustomerModel customer);

        bool AddEmployee(EmployeeModel employee);
        bool DeleteEmployee(string id);
        IEnumerable<EmployeeModel> GetAllEmployees();
        EmployeeModel GetEmployee(string id);
        bool UpdateEmployee(EmployeeModel employee);

        bool AddWhiskey(WhiskeyModel whiskey);
        bool DeleteWhiskey(string id);
        IEnumerable<WhiskeyModel> GetAllWhiskeys();
        WhiskeyModel GetWhiskey(string id);
        bool UpdateWhiskey(WhiskeyModel whiskey);

    }
}
