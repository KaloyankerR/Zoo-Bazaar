using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicObjectLayer
{
    public class Customer
    {

        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }


        public Customer()
        {
            
        }
        public Customer(int customerID)
        {
            CustomerID = customerID;
        }
        public Customer(string firstName, string lastName, string password, DateOnly dateOfBirth, string email, string phone, string address)
        {
            CustomerID = GenerateID();
            FirstName = firstName;
            LastName = lastName;
            Password = password;
            DateOfBirth = dateOfBirth;
            Email = email;
            Phone = phone;
            Address = address;
 
        }

        public int GenerateID()
        {
            Random random = new Random();
            return random.Next(100000, 999999);
        }
    }
}
