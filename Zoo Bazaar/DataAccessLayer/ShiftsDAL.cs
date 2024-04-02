using BusinessLogicObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using BusinessLogicLayer;

namespace DataAccessLayer
{
    public class ShiftsDAL : IShiftsDAL
    {
        public List<Shift> GetShifts() 
        {
            List<Shift> shifts = new List<Shift>();

            string query = "SELECT * FROM shifts";

            using (MySqlConnection connection = DatabaseLink.CreateConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Shift shift = new Shift
                                (Convert.ToInt32(reader["ShiftID"]), (Position)Convert.ToInt32(reader["Position"])
                                    , Convert.ToDateTime(reader["Start"]),
                                    Convert.ToDateTime(reader["End"]),
                                    Convert.ToInt32(reader["Capacity"]),
                                    new List<Employee>()
                                );

                                shifts.Add(shift);
                            }
                        }

                        

                        return shifts;
                    }
                    catch (Exception ex)
                    {
                        // Handle the exception as needed
                        Console.WriteLine($"Error getting animals: {ex.Message}");
                        return null;
                    }
                }
            }
        }

        public void LoadEmp(List<Shift> shifts, List<Employee> employees)
        {

            string query = "SELECT * FROM shifts_emp";

            using (MySqlConnection connection = DatabaseLink.CreateConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                foreach(Shift shift in shifts)
                                {
                                    if(shift.ID == Convert.ToInt32(reader["ShiftID"]))
                                    {
                                        foreach (Employee employee in employees)
                                        {
                                            if(employee.ID == Convert.ToInt32(reader["EmployeeID"]))
                                            {
                                                if (shift.EmployeesAssigned.Contains(employee) == false)
                                                {
                                                    shift.EmployeesAssigned.Add(employee);
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }



                       // return shifts;
                    }
                    catch (Exception ex)
                    {
                        // Handle the exception as needed
                        Console.WriteLine($"Error getting animals: {ex.Message}");
                         
                    }
                }
            }
        }

        public int CreateShift(Shift shift)
        {
            int result = 0;

            string query = "INSERT INTO shifts (Position,Start,End,Capacity) " +
                           "VALUES (@position,@start,@end,@capacity); " +
                           " SELECT LAST_INSERT_ID(); ";

            using (MySqlConnector.MySqlConnection connection = DatabaseLink.CreateConnection())
            {
                using (MySqlConnector.MySqlCommand cmd = new MySqlConnector.MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        // Set parameters
                        cmd.Parameters.AddWithValue("@position", shift.Position);
                        cmd.Parameters.AddWithValue("@start", shift.ShiftStart);
                        cmd.Parameters.AddWithValue("@end", shift.ShiftEnd);
                        cmd.Parameters.AddWithValue("@capacity", shift.Capacity);

                        // Execute the query
                        result = Convert.ToInt32(cmd.ExecuteScalar());


                    }
                    catch (Exception ex)
                    {
                        // return $"Error saving breed: {ex.Message}";
                        throw new Exception("Failed");
                    }
                    finally { connection.Close(); }
                    foreach (Employee employee in shift.EmployeesAssigned)
                    {
                        AssignEmployee(result, employee);
                    }
                    return result;
                }
            }
        }

        public void DeleteShift(Shift shift)
        {
            foreach(Employee employee in shift.EmployeesAssigned)
            {
                this.UnAssignEmployee(shift,employee);
            }
            string query = "DELETE FROM shifts " +
                          "WHERE ShiftID = @shiftID  ";

            using (MySqlConnector.MySqlConnection connection = DatabaseLink.CreateConnection())
            {
                using (MySqlConnector.MySqlCommand cmd = new MySqlConnector.MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        // Set parameters
                        cmd.Parameters.AddWithValue("@shiftID", shift.ID);
                       


                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        // return $"Error saving breed: {ex.Message}";
                        throw new Exception("Failed");
                    }
                    finally { connection.Close(); }
                }
            }

        }

        public void AssignEmployee(Shift shift, Employee employee)
        {

            string query = "INSERT INTO shifts_emp (ShiftID,EmployeeID) " +
                           "VALUES (@shift,@emp) ";

            using (MySqlConnector.MySqlConnection connection = DatabaseLink.CreateConnection())
            {
                using (MySqlConnector.MySqlCommand cmd = new MySqlConnector.MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        // Set parameters
                        cmd.Parameters.AddWithValue("@shift", shift.ID);
                        cmd.Parameters.AddWithValue("@emp", employee.ID);



                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        // return $"Error saving breed: {ex.Message}";
                        throw new Exception("Failed");
                    }
                    finally { connection.Close(); }
                }
            }
        }

        public void AssignEmployee(int shift, Employee employee)
        {

            string query = "INSERT INTO shifts_emp (ShiftID,EmployeeID) " +
                           "VALUES (@shift,@emp) ";

            using (MySqlConnector.MySqlConnection connection = DatabaseLink.CreateConnection())
            {
                using (MySqlConnector.MySqlCommand cmd = new MySqlConnector.MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        // Set parameters
                        cmd.Parameters.AddWithValue("@shift", shift);
                        cmd.Parameters.AddWithValue("@emp", employee.ID);



                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        // return $"Error saving breed: {ex.Message}";
                        throw new Exception("Failed");
                    }
                    finally { connection.Close(); }
                }
            }
        }

        public void UnAssignEmployee(Shift shift, Employee employee)
        {
            string query = "DELETE FROM shifts_emp " +
                          "WHERE ShiftID = @shift and EmployeeID = @emp ";

            using (MySqlConnector.MySqlConnection connection = DatabaseLink.CreateConnection())
            {
                using (MySqlConnector.MySqlCommand cmd = new MySqlConnector.MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        // Set parameters
                        cmd.Parameters.AddWithValue("@shift", shift.ID);
                        cmd.Parameters.AddWithValue("@emp", employee.ID);



                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        // return $"Error saving breed: {ex.Message}";
                        throw new Exception("Failed");
                    }
                    finally { connection.Close(); }
                }
            }
        }

        public List<Shift> GetEmployeeShifts(int employeeId)
        {
            List<Shift> shifts = new List<Shift>();

            string query = "SELECT s.* FROM dbi477553.shifts s " +
                           "JOIN dbi477553.shifts_emp se ON se.ShiftID = s.ShiftID " +
                           "WHERE se.EmployeeID = @EmployeeID;";

            using (MySqlConnection connection = DatabaseLink.CreateConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@EmployeeID", employeeId);

                    try
                    {
                        connection.Open();

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Shift shift = new Shift
                                (Convert.ToInt32(reader["ShiftID"]), (Position)Convert.ToInt32(reader["Position"])
                                    , Convert.ToDateTime(reader["Start"]),
                                    Convert.ToDateTime(reader["End"]),
                                    Convert.ToInt32(reader["Capacity"]),
                                    new List<Employee>()
                                );

                                shifts.Add(shift);
                            }
                        }

                        return shifts;
                    }
                    catch (Exception ex)
                    {
                        return shifts;
                    }
                }
            }
        }


    }
}
