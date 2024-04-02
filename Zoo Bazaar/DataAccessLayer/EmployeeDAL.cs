using BusinessLogicLayer;
using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using BCrypt.Net;
using BusinessLogicObjectLayer;

namespace DataAccessLayer
{
    public class EmployeeDAL : IEmployeeDAL
    {

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


        public void CreateEmployee(Employee employee)
        {


            using (MySqlConnection connection = DatabaseLink.CreateConnection())
            {
                connection.Open();

                // Define the SQL query to insert data into the "employees" table
                string insertQuery = @"INSERT INTO employees 
            (ID, FirstName, LastName, Email, Password, Phone, Address, Gender, DateOfBirth, BSN, IBAN, EmergancyFirstName, EmergancyLastName, EmergancyPhone, ContractType, Position, MinHours, MaxHours) 
            VALUES 
            (@ID, @FirstName, @LastName, @Email, @Password, @Phone, @Address, @Gender, @DateOfBirth, @BSN, @IBAN, @EmergancyFirstName, @EmergancyLastName, @EmergancyPhone, @ContractType, @Position, @MinHours, @MaxHours)";

                using (MySqlCommand cmd = new MySqlCommand(insertQuery, connection))
                {
                    // Set parameters using values from the Employee object
                    cmd.Parameters.AddWithValue("@ID", employee.ID);
                    cmd.Parameters.AddWithValue("@FirstName", employee.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", employee.LastName);
                    cmd.Parameters.AddWithValue("@Email", employee.Email);

                    string hashedPassword = HashPassword(employee.Password);
                    cmd.Parameters.AddWithValue("@Password", hashedPassword);

                    cmd.Parameters.AddWithValue("@Phone", employee.Phone);
                    cmd.Parameters.AddWithValue("@Address", employee.Address);
                    cmd.Parameters.AddWithValue("@Gender", employee.Gender);
                    cmd.Parameters.AddWithValue("@DateOfBirth", employee.DateOfBirth.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@BSN", employee.BSN);
                    cmd.Parameters.AddWithValue("@IBAN", employee.IBAN);
                    cmd.Parameters.AddWithValue("@EmergancyFirstName", employee.EmergancyFirstName);
                    cmd.Parameters.AddWithValue("@EmergancyLastName", employee.EmergancyLastName);
                    cmd.Parameters.AddWithValue("@EmergancyPhone", employee.EmergancyPhone);
                    cmd.Parameters.AddWithValue("@ContractType", employee.ContractType.ToString());
                    cmd.Parameters.AddWithValue("@Position", employee.Position.ToString());
                    cmd.Parameters.AddWithValue("@MinHours", employee.MinHours);
                    cmd.Parameters.AddWithValue("@MaxHours", employee.MaxHours);


                    cmd.ExecuteNonQuery();
                }
            }
        }

        public string GetStoredPasswordHash(int employeeId)
        {
            string storedHashedPassword = "";

            using (MySqlConnection connection = DatabaseLink.CreateConnection())
            {
                connection.Open();

                // Define a SQL query to retrieve the stored hashed password
                string selectQuery = "SELECT Password FROM employees WHERE ID = @EmployeeId";

                using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@EmployeeId", employeeId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            storedHashedPassword = reader.GetString("Password");
                        }
                    }
                }
            }

            return storedHashedPassword;
        }


        public bool UpdatePassword(int employeeId, string originalPassword, string newPassword)
        {
            string storedHashedPassword = GetStoredPasswordHash(employeeId);

            // Verify that the provided original password matches the stored one
            bool isPasswordCorrect = BCrypt.Net.BCrypt.Verify(originalPassword, storedHashedPassword);

            if (isPasswordCorrect)
            {
                // Hash the new password with BCrypt
                string newHashedPassword = BCrypt.Net.BCrypt.HashPassword(newPassword, BCrypt.Net.BCrypt.GenerateSalt());

                // Update the password in the database
                using (MySqlConnection connection = DatabaseLink.CreateConnection())
                {
                    connection.Open();

                    string updateQuery = "UPDATE employees SET Password = @NewPassword WHERE ID = @EmployeeId";

                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@NewPassword", newHashedPassword);
                        cmd.Parameters.AddWithValue("@EmployeeId", employeeId);

                        cmd.ExecuteNonQuery();
                    }
                }

                return true; // Password updated successfully
            }
            else
            {
                return false; // Original password provided is incorrect
            }
        }



        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();

            using (MySqlConnection connection = DatabaseLink.CreateConnection())
            {
                connection.Open();

                // Define the SQL query to retrieve all employees from the "employees" table
                string selectQuery = "SELECT * FROM employees";

                using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Employee employee = new Employee
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Email = reader["Email"].ToString(),
                            Password = reader["Password"].ToString(),
                            Phone = reader["Phone"].ToString(),
                            Address = reader["Address"].ToString(),
                            Gender = reader["Gender"].ToString(),
                            DateOfBirth = DateOnly.FromDateTime(DateTime.Parse(reader["DateOfBirth"].ToString())),
                            BSN = reader["BSN"].ToString(),
                            IBAN = reader["IBAN"].ToString(),
                            EmergancyFirstName = reader["EmergancyFirstName"].ToString(),
                            EmergancyLastName = reader["EmergancyLastName"].ToString(),
                            EmergancyPhone = reader["EmergancyPhone"].ToString(),
                            ContractType = (ContractType)Enum.Parse(typeof(ContractType), reader["ContractType"].ToString()),
                            Position = (Position)Enum.Parse(typeof(Position), reader["Position"].ToString()),
                            MinHours = Convert.ToInt32(reader["MinHours"]),
                            MaxHours = Convert.ToInt32(reader["MaxHours"]),

                        };

                        employees.Add(employee);
                    }
                }
            }

            return employees;
        }



        public string DeleteEmployeeByID(int employeeID)
        {
            using (MySqlConnection connection = DatabaseLink.CreateConnection())
            {
                connection.Open();

                // Define the SQL query to delete an employee by their ID
                string deleteQuery = "DELETE FROM employees WHERE ID = @EmployeeID";

                using (MySqlCommand cmd = new MySqlCommand(deleteQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@EmployeeID", employeeID);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // The employee was successfully deleted
                        return "Employee deleted successfully!";
                    }
                    else
                    {
                        // No rows were affected, so the employee was not found or not deleted
                        return "Employee was not deleted. Please try again!";
                    }
                }
            }
        }

        public Employee GetEmployeeByID(int employeeID)
        {
            Employee employee = null;

            using (MySqlConnection connection = DatabaseLink.CreateConnection())
            {
                connection.Open();

                // Define the SQL query to select data from the "employees" table by employee ID
                string selectQuery = "SELECT * FROM employees WHERE ID = @EmployeeID";

                using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@EmployeeID", employeeID);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Create an Employee object and populate it with data from the database
                            employee = new Employee
                            {
                                ID = reader.GetInt32("ID"),
                                FirstName = reader.GetString("FirstName"),
                                LastName = reader.GetString("LastName"),
                                Email = reader.GetString("Email"),
                                Password = reader.GetString("Password"), // Assuming this is a string
                                Phone = reader.GetString("Phone"),
                                Address = reader.GetString("Address"),
                                Gender = reader.GetString("Gender"),
                                DateOfBirth = DateOnly.FromDateTime(DateTime.Parse(reader["DateOfBirth"].ToString())),
                                BSN = reader.GetString("BSN"),
                                IBAN = reader.GetString("IBAN"),
                                EmergancyFirstName = reader.GetString("EmergancyFirstName"),
                                EmergancyLastName = reader.GetString("EmergancyLastName"),
                                EmergancyPhone = reader.GetString("EmergancyPhone"),
                                ContractType = (ContractType)Enum.Parse(typeof(ContractType), reader.GetString("ContractType")),
                                Position = (Position)Enum.Parse(typeof(Position), reader.GetString("Position")),
                                MinHours = reader.GetInt32("MinHours"),
                                MaxHours = reader.GetInt32("MaxHours"),
                                
                            };
                        }
                    }
                }
            }

            return employee;
        }



        public List<Employee> GetAllEmployeesByName(string name)
        {
            List<Employee> employes = new List<Employee>();

            using (MySqlConnection conn = DatabaseLink.CreateConnection())
            {
                conn.Open();

                // Prepare the SQL statement
                var sql = "SELECT * FROM employees WHERE CONCAT(FirstName, ' ', LastName) LIKE @name";


                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@name", "%" + name + "%");
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Employee emp = new Employee()
                            {
                                ID = reader.GetInt32("ID"),
                                FirstName = reader.GetString("FirstName"),
                                LastName = reader.GetString("LastName"),
                                Email = reader.GetString("Email"),
                                Password = reader.GetString("Password"), // Assuming this is a string
                                Phone = reader.GetString("Phone"),
                                Address = reader.GetString("Address"),
                                Gender = reader.GetString("Gender"),
                                DateOfBirth = DateOnly.FromDateTime(DateTime.Parse(reader["DateOfBirth"].ToString())),
                                BSN = reader.GetString("BSN"),
                                IBAN = reader.GetString("IBAN"),
                                EmergancyFirstName = reader.GetString("EmergancyFirstName"),
                                EmergancyLastName = reader.GetString("EmergancyLastName"),
                                EmergancyPhone = reader.GetString("EmergancyPhone"),
                                ContractType = (ContractType)Enum.Parse(typeof(ContractType), reader.GetString("ContractType")),
                                Position = (Position)Enum.Parse(typeof(Position), reader.GetString("Position")),
                                MinHours = reader.GetInt32("MinHours"),
                                MaxHours = reader.GetInt32("MaxHours"),
                                
                            };

                            employes.Add(emp);
                        }
                    }
                }
            }

            return employes;
        }



        public Employee Login(string email, string password)
        {
            using (MySqlConnection connection = DatabaseLink.CreateConnection())
            {
                connection.Open();

                // Define the SQL query to retrieve an administrator by email
                string selectQuery = "SELECT * FROM employees WHERE Email = @Email";

                using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@Email", email);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Retrieve the hashed password from the database
                            string storedHashedPassword = reader.GetString("Password");

                            // Verify the provided password against the stored hash
                            if (BCrypt.Net.BCrypt.Verify(password, storedHashedPassword))
                            {
                                // Password is correct, return the Administrator object
                                return new Employee
                                {
                                    ID = reader.GetInt32("ID"),
                                    FirstName = reader.GetString("FirstName"),
                                    LastName = reader.GetString("LastName"),
                                    Email = email,
                                    Phone = reader.GetString("Phone"),
                                    Address = reader.GetString("Address"),
                                    Gender = reader.GetString("Gender"),
                                    DateOfBirth = DateOnly.Parse(reader.GetDateTime("DateOfBirth").ToString("yyyy-MM-dd")),
                                    BSN = reader.GetString("BSN"),
                                    IBAN = reader.GetString("IBAN"),
                                    EmergancyFirstName = reader.GetString("EmergancyFirstName"),
                                    EmergancyLastName = reader.GetString("EmergancyLastName"),
                                    EmergancyPhone = reader.GetString("EmergancyPhone"),
                                    ContractType = (ContractType)Enum.Parse(typeof(ContractType), reader.GetString("ContractType")),
                                    Position = (Position)Enum.Parse(typeof(Position), reader.GetString("Position")),
                                    MinHours = reader.GetInt32("MinHours"),
                                    MaxHours = reader.GetInt32("MaxHours"),
                                    
                                };
                            }
                        }
                    }
                }
            }

            // Return null if login fails
            return null;
        }


        public void SaveRegionToEmployee(Employee emp, ZooRegion region)
        {
            using (MySqlConnection connection = DatabaseLink.CreateConnection())
            {
                connection.Open();

                using (MySqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO regions_assigned_to_employees (EmployeeID, EmployeeName, RegionID, RegionName) VALUES (@EmployeeID, @EmployeeName, @RegionID, @RegionName)";
                    command.Parameters.AddWithValue("@EmployeeID", emp.ID);
                    command.Parameters.AddWithValue("@EmployeeName", emp.FirstName + " " + emp.LastName);
                    command.Parameters.AddWithValue("@RegionID", region.ID);
                    command.Parameters.AddWithValue("@RegionName", region.Name);

                    command.ExecuteNonQuery();
                }
            }
        }


        public List<string> GetAssignedRegionsByEmployeeID(int employeeID)
        {
            List<string> assignedRegions = new List<string>();

            using (MySqlConnection connection = DatabaseLink.CreateConnection())
            {
                connection.Open();

                using (MySqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "SELECT RegionID, RegionName FROM regions_assigned_to_employees WHERE EmployeeID = @EmployeeID";
                    command.Parameters.AddWithValue("@EmployeeID", employeeID);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                           

                            assignedRegions.Add(reader.GetString("RegionName"));
                        }
                    }
                }
            }

            return assignedRegions;
        }


        public string DeleteRegionAssignment(Employee emp, ZooRegion region)
        {
            try
            {
                using (MySqlConnection connection = DatabaseLink.CreateConnection())
                {
                    connection.Open();

                    using (MySqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "DELETE FROM regions_assigned_to_employees WHERE EmployeeID = @EmployeeID AND RegionID = @RegionID";
                        command.Parameters.AddWithValue("@EmployeeID", emp.ID);
                        command.Parameters.AddWithValue("@RegionID", region.ID);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            return $"Region assignment deleted successfully for Employee ID {emp.ID} and Region ID {region.ID}";
                        }
                        else
                        {
                            return $"No matching region assignment found for Employee ID {emp.ID} and Region ID {region.ID}";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Error deleting region assignment: {ex.Message}";
            }
        }



    }
}
