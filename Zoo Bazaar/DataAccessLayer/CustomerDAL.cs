using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using BCrypt;
using BusinessLogicObjectLayer;

namespace DataAccessLayer
{
    public class CustomerDAL : ICustomerDAL
    {
        public string SaveCustomer(Customer cust)
        {

            using (MySqlConnection connection = DatabaseLink.CreateConnection())
            {
                try
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO customers (ID, FirstName, LastName, Password, DateOfBirth, Email, Phone, Address) " +
                        "VALUES (@CustID, @FirstName, @LastName, @Password, @DateOfBirth, @Email, @Phone, @Address)";

                    using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@CustID", cust.CustomerID);
                        command.Parameters.AddWithValue("@FirstName", cust.FirstName);
                        command.Parameters.AddWithValue("@LastName", cust.LastName);

                        string hashedPassword = HashPassword(cust.Password);
                        command.Parameters.AddWithValue("@Password", hashedPassword);

                        // Convert DateOnly to a string in the "YYYY-MM-DD" format
                        command.Parameters.AddWithValue("@DateOfBirth", cust.DateOfBirth.ToString("yyyy-MM-dd"));

                        command.Parameters.AddWithValue("@Email", cust.Email);
                        command.Parameters.AddWithValue("@Phone", cust.Phone);
                        command.Parameters.AddWithValue("@Address", cust.Address);
                   
                        command.ExecuteNonQuery();

                        return "Customer saved successfully.";
                    }
                }
                catch (Exception ex)
                {
                    // Handle the exception or log it.
                    return $"Error: {ex.Message}! Failed to save the diver.";
                }
            }
        }




        private string HashPassword(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("Password cannot be null or empty", nameof(password));
            }

            // Generate a salt and hash the password with BCrypt
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password, BCrypt.Net.BCrypt.GenerateSalt());
            return hashedPassword;
        }


        public List<Customer> GetAllCustomers()
        {

            List<Customer> customers = new List<Customer>();

            using (MySqlConnection connection = DatabaseLink.CreateConnection())
            {
                connection.Open();

                string selectQuery = "SELECT * FROM customers";

                using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Customer diver = new Customer
                        {
                            CustomerID = reader.GetInt32("ID"),
                            FirstName = reader.GetString("FirstName"),
                            LastName = reader.GetString("LastName"),
                            Password = reader.GetString("Password"),

                            // Convert DATE from database to DateOnly
                            DateOfBirth = DateOnly.Parse(reader.GetDateTime("DateOfBirth").ToString("yyyy-MM-dd")),

                            Email = reader.GetString("Email"),
                            Phone = reader.GetString("Phone"),
                            Address = reader.GetString("Address"),
                       
                        };

                        customers.Add(diver);
                    }
                }
            }

            return customers;
        }

        public bool Login(string username, string password)
        {


            using (MySqlConnection connection = DatabaseLink.CreateConnection())
            {
                connection.Open();

                string selectQuery = "SELECT * FROM customers WHERE Email = @Email";

                using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@Email", username);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Retrieve the stored hashed password
                            string storedHashedPassword = reader.GetString("Password");

                            // Verify the provided password against the stored hashed password
                            bool passwordMatches = BCrypt.Net.BCrypt.Verify(password, storedHashedPassword);

                            if (passwordMatches)
                            {
                                // Login successful, set a session or authentication token here
                                return true;
                            }
                        }
                    }
                }
            }

            return false; // Login failed
        }


        public Customer GetCustomerByEmail(string email)
        {

            Customer customer = null;

            using (MySqlConnection connection = DatabaseLink.CreateConnection())
            {
                connection.Open();

                string selectQuery = "SELECT * FROM customers WHERE Email = @Email";

                using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            customer = new Customer
                            {
                                CustomerID = reader.GetInt32("ID"),
                                FirstName = reader.GetString("FirstName"),
                                LastName = reader.GetString("LastName"),
                                Password = reader.GetString("Password"),
                                DateOfBirth = DateOnly.Parse(reader.GetDateTime("DateOfBirth").ToString("yyyy-MM-dd")),
                                Email = reader.GetString("Email"),
                                Phone = reader.GetString("Phone"),
                                Address = reader.GetString("Address"),
                               
                            };
                        }
                    }
                }
            }

            return customer;
        }


        public Customer GetCustomerByID(int customerID)
        {
            Customer cust = null;

            using (MySqlConnection connection = DatabaseLink.CreateConnection())
            {
                connection.Open();

                string selectQuery = "SELECT * FROM customers WHERE ID = @ID";

                using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@ID", customerID);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cust = new Customer
                            {
                                CustomerID = reader.GetInt32("ID"),
                                FirstName = reader.GetString("FirstName"),
                                LastName = reader.GetString("LastName"),
                                Password = reader.GetString("Password"),
                                DateOfBirth = DateOnly.Parse(reader.GetDateTime("DateOfBirth").ToString("yyyy-MM-dd")),
                                Email = reader.GetString("Email"),
                                Phone = reader.GetString("Phone"),
                                Address = reader.GetString("Address"),
                             
                            };
                        }
                    }
                }
            }

            return cust;
        }


        public string SaveSubscriberEmail(string email)
        {
            using (MySqlConnection connection = DatabaseLink.CreateConnection())
            {
                try
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO subscribers (Email) VALUES (@Email)";

                    using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        command.ExecuteNonQuery();

                        return "Subscriber email saved successfully.";
                    }
                }
                catch (Exception ex)
                {
                    // Handle the exception or log it.
                    return $"Error: {ex.Message}! Failed to save subscriber email.";
                }
            }
        }

        public List<string> GetAllSubscribers()
        {
            List<string> subscribers = new List<string>();

            using (MySqlConnection connection = DatabaseLink.CreateConnection())
            {
                connection.Open();

                string selectQuery = "SELECT Email FROM subscribers";

                using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string email = reader.GetString("Email");
                        subscribers.Add(email);
                    }
                }
            }

            return subscribers;
        }

        public string DeleteCustomer(int customerID)
        {
            using (MySqlConnection connection = DatabaseLink.CreateConnection())
            {
                try
                {
                    connection.Open();

                    string deleteQuery = "DELETE FROM customers WHERE ID = @CustomerID";

                    using (MySqlCommand command = new MySqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", customerID);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            return "Customer deleted successfully.";
                        }
                        else
                        {
                            return "Customer with the specified ID not found.";
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle the exception or log it.
                    return $"Error: {ex.Message}! Failed to delete the diver.";
                }
            }
        }

        public string UpdateCustomer(Customer updatedCustomer)
        {
            using (MySqlConnection connection = DatabaseLink.CreateConnection())
            {
                try
                {
                    connection.Open();

                    string updateQuery = "UPDATE customers " +
                                         "SET FirstName = @FirstName, " +
                                         "    LastName = @LastName, " +
                                         "    Password = @Password, " +
                                         "    DateOfBirth = @DateOfBirth, " +
                                         "    Email = @Email, " +
                                         "    Phone = @Phone, " +
                                         "    Address = @Address, " +
                                         "    Rating = @Rating, " +
                                         "    PromoCode = @PromoCode, " +
                                         "    DivingLevel = @DivingLevel " +
                                         "WHERE ID = @CustomerID";

                    using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", updatedCustomer.FirstName);
                        command.Parameters.AddWithValue("@LastName", updatedCustomer.LastName);

                        string hashedPassword = HashPassword(updatedCustomer.Password);
                        command.Parameters.AddWithValue("@Password", hashedPassword);

                        command.Parameters.AddWithValue("@DateOfBirth", updatedCustomer.DateOfBirth.ToString("yyyy-MM-dd"));
                        command.Parameters.AddWithValue("@Email", updatedCustomer.Email);
                        command.Parameters.AddWithValue("@Phone", updatedCustomer.Phone);
                        command.Parameters.AddWithValue("@Address", updatedCustomer.Address);
        
                        command.Parameters.AddWithValue("@CustomerID", updatedCustomer.CustomerID);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            return "This account was updated successfully.";
                        }
                        else
                        {
                            return "Customer with the specified ID not found.";
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle the exception or log it.
                    return $"Error: {ex.Message}! Failed to update the diver.";
                }
            }
        }



    }
}
