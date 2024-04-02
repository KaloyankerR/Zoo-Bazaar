using BusinessLogicObjectLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicManagerLayer
{
    public class CustomerManager
    {
        private ICustomerDAL customerCRUD;


        public CustomerManager(ICustomerDAL cust)
        {
            this.customerCRUD = cust;
        }

        public string SaveCustomer(Customer cust)
        {
            string message = customerCRUD.SaveCustomer(cust);
            return message;
        }

        public List<Customer> GetAllCustomers()
        {
            List<Customer> customers = customerCRUD.GetAllCustomers();
            return customers;
        }
        public bool Login(string username, string password)
        {
            bool check = customerCRUD.Login(username, password);
            return check;
        }

        public Customer GetCustomerByEmail(string email)
        {
            Customer cust = customerCRUD.GetCustomerByEmail(email);
            return cust;
        }
        public Customer GetCustomerByID(int customerID)
        {
            Customer cust = customerCRUD.GetCustomerByID(customerID);
            return cust;
        }
        public string SaveSubscriberEmail(string email)
        {
            string message = customerCRUD.SaveSubscriberEmail(email);
            return message;
        }

        public List<string> GetAllSubscribers()
        {
            List<string> emails = customerCRUD.GetAllSubscribers();
            return emails;
        }

        public string DeleteCustomer(int customerID)
        {
            string message = customerCRUD.DeleteCustomer(customerID);
            return  message;
        }

        public string UpdateCustomer(Customer updatedCustomer)
        {
            string message = customerCRUD.UpdateCustomer(updatedCustomer);  
            return message; 
        }
    }
}
