using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicObjectLayer;
using MySqlConnector;

namespace DataAccessLayer
{
    public class CageDAL : ICageDAL
    {

        public string SaveCage(Cage cage)
        {
            string query = "INSERT INTO cages (CageID, CageName, Region, RegionName, TypeOfAnimal, Capacity, AnimalsInCage, Size, Outdoor) " +
                           "VALUES (@CageID, @CageName, @RegionID, @RegionName, @TypeOfAnimal, @Capacity, @AnimalsInCage, @Size, @Outdoor)";

            using (MySqlConnection connection = DatabaseLink.CreateConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        // Set parameters
                        cmd.Parameters.AddWithValue("@CageID", cage.ID);
                        cmd.Parameters.AddWithValue("@CageName", cage.CageName);
                        cmd.Parameters.AddWithValue("@RegionID", cage.RegionID);
                        cmd.Parameters.AddWithValue("@RegionName", cage.RegionName);

                        cmd.Parameters.AddWithValue("@TypeOfAnimal", cage.TypeOfAnimal);
                        cmd.Parameters.AddWithValue("@Capacity", cage.Capacity);
                        cmd.Parameters.AddWithValue("@AnimalsInCage", cage.AnimalsInCage);
                        cmd.Parameters.AddWithValue("@Size", cage.Size);
                        cmd.Parameters.AddWithValue("@Outdoor", cage.Outdoor);

                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        return $"Cage saved successfully.";
                    }
                    catch (Exception ex)
                    {
                        return $"Error saving cage: {ex.Message}";
                    }
                }
            }
        }


        public List<Cage> ReadAllCages()
        {
            List<Cage> cages = new List<Cage>();

            string query = "SELECT * FROM cages";

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
                                Cage cage = new Cage
                                {
                                    ID = Convert.ToInt32(reader["CageID"]),
                                    CageName = reader["CageName"].ToString(),
                                    RegionID = Convert.ToInt32(reader["Region"]),
                                    RegionName = reader["RegionName"].ToString(),
                                    TypeOfAnimal = reader["TypeOfAnimal"].ToString(),
                                    Capacity = Convert.ToInt32(reader["Capacity"]),
                                    AnimalsInCage = Convert.ToInt32(reader["AnimalsInCage"]),
                                    Size = Convert.ToInt32(reader["Size"]),
                                    Outdoor = reader["Outdoor"].ToString()
                                };

                                cages.Add(cage);
                            }
                        }

                        return cages;
                    }
                    catch (Exception ex)
                    {
                        // Handle exception
                        Console.WriteLine($"Error reading cages: {ex.Message}");
                        return cages;
                    }
                }
            }
        }

        public string DeleteCage(int cageID)
        {
            string query = "DELETE FROM cages WHERE CageID = @CageID";

            using (MySqlConnection connection = DatabaseLink.CreateConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        // Set parameters
                        cmd.Parameters.AddWithValue("@CageID", cageID);

                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            return $"Cage with ID {cageID} deleted successfully.";
                        }
                        else
                        {
                            return $"No cage found with ID {cageID}.";
                        }
                    }
                    catch (Exception ex)
                    {
                        return $"Error deleting cage: {ex.Message}";
                    }
                }
            }
        }


        public string UpdateCage(int id, Cage updatedCage)
        {
            string query = "UPDATE cages SET CageName = @CageName, Region = @RegionID, " +
                           "RegionName = @RegionName, TypeOfAnimal = @TypeOfAnimal, " +
                           "Capacity = @Capacity, AnimalsInCage = @AnimalsInCage, " +
                           "Size = @Size, Outdoor = @Outdoor " +
                           "WHERE CageID = @Id";

            using (MySqlConnection connection = DatabaseLink.CreateConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        // Set parameters
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.Parameters.AddWithValue("@CageName", updatedCage.CageName);
                        cmd.Parameters.AddWithValue("@RegionID", updatedCage.RegionID);
                        cmd.Parameters.AddWithValue("@RegionName", updatedCage.RegionName);
                        cmd.Parameters.AddWithValue("@TypeOfAnimal", updatedCage.TypeOfAnimal);
                        cmd.Parameters.AddWithValue("@Capacity", updatedCage.Capacity);
                        cmd.Parameters.AddWithValue("@AnimalsInCage", updatedCage.AnimalsInCage);
                        cmd.Parameters.AddWithValue("@Size", updatedCage.Size);
                        cmd.Parameters.AddWithValue("@Outdoor", updatedCage.Outdoor);

                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            return $"Cage with ID {id} updated successfully.";
                        }
                        else
                        {
                            return $"No cage found with ID {id}.";
                        }
                    }
                    catch (Exception ex)
                    {
                        return $"Error updating cage: {ex.Message}";
                    }
                }
            }
        }

        public Cage GetCageById(int id)
        {
            string query = "SELECT * FROM cages WHERE CageID = @Id";

            using (MySqlConnection connection = DatabaseLink.CreateConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        // Set parameters
                        cmd.Parameters.AddWithValue("@Id", id);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Create a new Cage object based on the retrieved data
                                Cage cage = new Cage
                                {
                                    ID = Convert.ToInt32(reader["CageID"]),
                                    CageName = reader["CageName"].ToString(),
                                    RegionID = Convert.ToInt32(reader["Region"]),
                                    RegionName = reader["RegionName"].ToString(),
                                    TypeOfAnimal = reader["TypeOfAnimal"].ToString(),
                                    Capacity = Convert.ToInt32(reader["Capacity"]),
                                    AnimalsInCage = Convert.ToInt32(reader["AnimalsInCage"]),
                                    Size = Convert.ToInt32(reader["Size"]),
                                    Outdoor = reader["Outdoor"].ToString()
                                };

                                return cage;
                            }
                            else
                            {
                                // Return null if no cage is found with the specified ID
                                return null;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle the exception as needed
                        Console.WriteLine($"Error getting cage by ID: {ex.Message}");
                        return null;
                    }
                }
            }
        }


        public List<Cage> GetCagesByRegionName(string regionName)
        {
            string query = "SELECT * FROM cages WHERE RegionName = @RegionName";
            List<Cage> cages = new List<Cage>();

            using (MySqlConnection connection = DatabaseLink.CreateConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        // Set parameters
                        cmd.Parameters.AddWithValue("@RegionName", regionName);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Create a new Cage object for each row and add it to the list
                                Cage cage = new Cage
                                {
                                    ID = Convert.ToInt32(reader["CageID"]),
                                    CageName = reader["CageName"].ToString(),
                                    RegionID = Convert.ToInt32(reader["Region"]),
                                    RegionName = reader["RegionName"].ToString(),
                                    TypeOfAnimal = reader["TypeOfAnimal"].ToString(),
                                    Capacity = Convert.ToInt32(reader["Capacity"]),
                                    AnimalsInCage = Convert.ToInt32(reader["AnimalsInCage"]),
                                    Size = Convert.ToInt32(reader["Size"]),
                                    Outdoor = reader["Outdoor"].ToString()
                                };

                                cages.Add(cage);
                            }
                        }

                        return cages;
                    }
                    catch (Exception ex)
                    {
                        // Handle the exception as needed
                        Console.WriteLine($"Error getting cages by RegionName: {ex.Message}");
                        return null;
                    }
                }
            }
        }

    }
}
