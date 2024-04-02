using BusinessLogicObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface ICustomerDAL
    {
        string SaveCustomer(Customer cust);
        List<Customer> GetAllCustomers();
        bool Login(string username, string password);
        Customer GetCustomerByEmail(string email);
        Customer GetCustomerByID(int customerID);
        string SaveSubscriberEmail(string email);
        List<string> GetAllSubscribers();
        string DeleteCustomer(int customerID);
        string UpdateCustomer(Customer updatedCustomer);
    }
}
